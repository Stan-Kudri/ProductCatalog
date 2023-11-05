using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.ChildForms.Import;
using TestTask.Core;
using TestTask.Core.Export;
using TestTask.Core.Export.SheetFillers;
using TestTask.Core.Extension;
using TestTask.Core.Import;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Products;
using TestTask.Extension;
using TestTask.Forms.CompanyForm;
using TestTask.Forms.StepForm;

namespace TestTask.Forms
{
    public partial class TableForm : BaseForm
    {
        private const string Company = "Company";
        private const string Product = "Product";

        private const string MessageNotSelectedItem = "No items selected";

        private const int NoItemsSelected = 0;

        //Index column from all tables
        public const int IndexId = 0;
        private const int IndexColumnCompanyName = 1;

        //Index column Company table
        private const int IndexColumnDataCreate = 2;
        private const int IndexColumnCountry = 3;

        //Index column Product table
        private const int IndexColumnCategory = 2;
        private const int IndexColumnType = 3;
        private const int IndexColumnPrice = 4;
        private const int IndexColumnDestination = 5;
        private const int IndexColumnIdCompany = 6;

        private readonly IServiceProvider _serviceProvider;
        private readonly CompanyService _companyService;
        private readonly ProductService _productService;
        private readonly IMessageBox _messageBox;

        private PagedList<Company> _pagedListCompany;
        private PagedList<Product> _pagedListProduct;

        private bool Resizing = false;

        public TableForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _companyService = _serviceProvider.GetRequiredService<CompanyService>();
            _productService = _serviceProvider.GetRequiredService<ProductService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
        }

        public PageModel PageCompany { get; set; } = new PageModel();

        public PageModel PageProduct { get; set; } = new PageModel();

        private void TableForm_Load(object sender, EventArgs e)
        {
            _pagedListCompany = new PagedList<Company>(_companyService.GetQueryableAll());
            _pagedListProduct = new PagedList<Product>(_productService.GetQueryableAll());
            cmbPageSizeCompanies.DataSource = PageCompany.Items;
            cmbPageSizeProduct.DataSource = PageProduct.Items;
            UpdateAllGrids();
            PageCompany.ChangeCurrentPage += LoadDataCompany;
            PageProduct.ChangeCurrentPage += LoadDataProduct;
        }

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            PageCompany.ChangeCurrentPage -= LoadDataCompany;
            PageProduct.ChangeCurrentPage -= LoadDataProduct;
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            using (var addFormMode = _serviceProvider.GetRequiredService<AddItemCompanyForm>())
            {
                if (addFormMode.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = addFormMode.GetCompanyModel().ToCompany();
                _companyService.Add(item);
                LoadDataCompany();
            }
        }

        private void BtnEditCompany_Click(object sender, EventArgs e)
        {
            var indexEditItem = listViewCompanies.SelectedIndices.Cast<int>();

            if (indexEditItem.Count() != 1)
            {
                _messageBox.ShowWarning("Select one item.");
                return;
            }

            var row = indexEditItem.First();
            var oldItem = GetCompany(row);

            using (var editCompanyForm = _serviceProvider.GetRequiredService<EditItemCompanyForm>())
            {
                editCompanyForm.Initialize(oldItem);

                if (editCompanyForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var updateItem = editCompanyForm.GetEditCompany();
                _companyService.Update(updateItem);
                UpdateMode(updateItem, row);
            }
        }

        private void BtnDeleteCompany_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = listViewCompanies.SelectedIndices;

            if (selectedRowIndex.Count == NoItemsSelected)
            {
                _messageBox.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!_messageBox.ShowQuestion("Delete selected items?"))
            {
                foreach (ListViewItem item in listViewCompanies.Items)
                {
                    item.Selected = false;
                }
                return;
            }

            RemoveItemRowListViewCompany();
            UpdateAllGrids();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            var listCompany = _companyService.GetQueryableAll();

            if (listCompany.Count() == 0)
            {
                _messageBox.ShowWarning("Add a company to the table to add a product.");
                return;
            }

            using (var addFormProduct = _serviceProvider.GetRequiredService<AddItemProductForm>())
            {
                addFormProduct.Initialize(listCompany.ToList());

                if (addFormProduct.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = addFormProduct.GetStepModel().ToStep();
                _productService.Add(item);
                LoadDataProduct();
            }
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            var indexEditRow = listViewProduct.SelectedIndices.Cast<int>();

            if (indexEditRow.Count() != 1)
            {
                _messageBox.ShowWarning("Select one item.");
                return;
            }

            var listCompany = _companyService.GetAll();
            var indexRow = indexEditRow.First();
            var oldItem = GetProduct(indexRow);

            using (var editProductForm = _serviceProvider.GetRequiredService<EditItemProductForm>())
            {
                editProductForm.Initialize(listCompany, oldItem);

                if (editProductForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var updateItem = editProductForm.GetEditProduct();
                _productService.Update(updateItem);
                UpdateProduct(updateItem, indexRow);
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedRow = listViewProduct.SelectedIndices.Count;
            if (selectedRow == NoItemsSelected)
            {
                _messageBox.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!_messageBox.ShowQuestion("Delete selected items?"))
            {
                foreach (ListViewItem item in listViewProduct.Items)
                {
                    item.Selected = false;
                }
                return;
            }

            listViewProduct.Remove(_productService);
            LoadDataProduct();
        }

        private void TsmImportFromExcel_Click(object sender, EventArgs e)
        {
            var loadTable = new Dictionary<string, bool>()
            {
                { Company, false },
                { Product, false },
            };

            using (var impotDbForExcel = _serviceProvider.GetRequiredService<ImportDatabaseForm>())
            {
                if (impotDbForExcel.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                loadTable[Company] = impotDbForExcel.IsDownloadTableMode;
                loadTable[Product] = impotDbForExcel.IsDownloadTableStep;
            }

            using (var openReplaceDataFromFile = _serviceProvider.GetRequiredService<OpenFileDialog>())
            {
                if (openReplaceDataFromFile.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                var path = openReplaceDataFromFile.FileName;

                if (loadTable[Company])
                {
                    var companyRead = _serviceProvider.GetRequiredService<ExcelImporter<Company>>().ImportFromFile(path);

                    foreach (var item in companyRead)
                    {
                        if (item.Success)
                        {
                            _companyService.AddImportData(item.Value);
                        }
                    }

                    LoadDataCompany();

                    if (!companyRead.IsNoErrorLine(out var message))
                    {
                        _messageBox.ShowWarning(message, Company);
                    }
                }

                if (loadTable[Product])
                {
                    var productRead = _serviceProvider.GetRequiredService<ExcelImporter<Product>>().ImportFromFile(path);

                    foreach (var item in productRead)
                    {
                        if (item.Success)
                        {
                            _productService.AddImportData(item.Value);
                        }
                    }

                    LoadDataProduct();

                    if (!productRead.IsNoErrorLine(out var message))
                    {
                        _messageBox.ShowWarning(message, Product);
                    }
                }
            }
        }

        private void TsmItemSaveExcel_Click(object sender, EventArgs e)
        {
            using (var exportFileData = _serviceProvider.GetRequiredService<SaveFileDialog>())
            {
                if (exportFileData.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                var path = exportFileData.FileName;

                var companySheetFiller = new CompanySheetFiller(_companyService);
                var stepSheetFiller = new ProductSheetFiller(_productService);

                var fillers = new ISheetFiller[]
                {
                companySheetFiller,
                stepSheetFiller,
                };

                var writeExcel = new ExcelExporter(fillers);
                writeExcel.ExportToFile(path);
            }
        }

        private void TlpCompanyList_SizeChanged(object sender, EventArgs e)
        {
            if (!Resizing)
            {
                Resizing = true;
                SizeChangedListView(listViewCompanies);
            }
            Resizing = false;
        }

        private void TlpProductList_SizeChanged(object sender, EventArgs e)
        {
            if (!Resizing)
            {
                Resizing = true;
                SizeChangedListView(listViewProduct);
            }
            Resizing = false;
        }

        private void TsmItemClose_Click(object sender, EventArgs e) => Close();

        private void CmbPageSizeCompany_Changed(object sender, EventArgs e)
        {
            var pageSizeCmb = PageCompany.Items[cmbPageSizeCompanies.SelectedIndex];

            if (PageCompany.ChangedPage(pageSizeCmb))
            {
                PageCompany.Size = pageSizeCmb;
                PageCompany.Number = 1;
            }
        }

        private void CmbPageSizeProduct_Changed(object sender, EventArgs e)
        {
            var pageSizeCmb = PageProduct.Items[cmbPageSizeProduct.SelectedIndex];

            if (PageProduct.ChangedPage(pageSizeCmb))
            {
                PageProduct.Size = pageSizeCmb;
                PageProduct.Number = 1;
            }
        }

        private void TextBoxCurrentPageMode_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCurrentPageCompanies.Text, out var pageNumber)
                && pageNumber <= _pagedListCompany.PageCount
                && _pagedListCompany.PageNumber == PageCompany.Number)
            {
                PageCompany.Number = pageNumber;
            }

            textBoxCurrentPageCompanies.Text = string.Format("{0}/{1}", PageCompany.Number, _pagedListCompany.PageCount);
        }

        private void TextBoxCurrentPageProduct_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCurrentPageProduct.Text, out var pageNumber)
                && pageNumber <= _pagedListProduct.PageCount
                && _pagedListProduct.PageNumber == PageProduct.Number)
            {
                PageProduct.Number = pageNumber;
            }

            textBoxCurrentPageProduct.Text = string.Format("{0}/{1}", PageProduct.Number, _pagedListProduct.PageCount);
        }

        private void LoadDataCompany()
        {
            _pagedListCompany = _companyService.GetQueryableAll().GetPagedList(PageCompany.GetPage());
            if (IsNotFirstPageCompanyEmpty())
            {
                PageCompany.Number -= 1;
            }

            var item = _pagedListCompany.Items;

            listViewCompanies.Items.Clear();
            FillListViewMode(item);
            CustomUpdateFormStateCompanyPagination();

            textBoxCurrentPageCompanies.Text = _pagedListCompany.PageNumber.ToString();
        }

        private void LoadDataProduct()
        {
            _pagedListProduct = _productService.GetQueryableAll().GetPagedList(PageProduct.GetPage());
            if (IsNotFirstPageProductEmpty())
            {
                PageProduct.Number -= 1;
            }

            var item = _pagedListProduct.Items;

            listViewProduct.Items.Clear();
            FillListViewProduct(item);
            CustomUpdateFormStateProductPagination();

            textBoxCurrentPageProduct.Text = _pagedListProduct.PageNumber.ToString();
        }

        private void UpdateAllGrids()
        {
            LoadDataCompany();
            LoadDataProduct();
        }

        private Company GetCompany(int indexRow)
        {
            var rowItem = listViewCompanies.Items[indexRow];

            var id = CellElement(rowItem, IndexId).ParseInt();
            var name = CellElement(rowItem, IndexColumnCompanyName) ?? throw new ArgumentException("Name cannot be null.");
            var strDateCreation = CellElement(rowItem, IndexColumnDataCreate);
            DateTime dateCreation = strDateCreation != null ? DateTime.Parse(strDateCreation) : throw new ArgumentException("Data create cannot be null.");
            var country = CellElement(rowItem, IndexColumnCountry) ?? throw new ArgumentException("Country cannot be null.");

            return new Company(name, dateCreation, country, id);
        }

        private Product GetProduct(int indexRow)
        {
            var rowItem = listViewProduct.Items[indexRow];

            var idStep = CellElement(rowItem, IndexId).ParseInt();
            var category = CellElement(rowItem, IndexColumnCategory) ?? throw new Exception("Type cannot be null.");
            var type = CellElement(rowItem, IndexColumnType) ?? throw new Exception("Type cannot be null.");
            var price = CellElement(rowItem, IndexColumnPrice).ParseDecimal();
            var destination = CellElement(rowItem, IndexColumnDestination);
            var companyId = CellElement(rowItem, IndexColumnIdCompany).ParseInt();

            return new Product(companyId, category, type, destination, price, idStep);
        }

        private string CellElement(ListViewItem rowItem, int indexColumn) => rowItem.GetString(indexColumn) ?? throw new Exception("String cannot be null.");

        private void FillListViewMode(List<Company> items)
        {
            foreach (var item in items)
            {
                AddCompanyInListView(item);
            }
        }

        private void FillListViewProduct(List<Product> items)
        {
            foreach (var item in items)
            {
                AddProductInListView(item);
            }
        }

        private void AddCompanyInListView(Company item)
        {
            var itemsRow = new string[]
            {
                item.Id.ToString(),
                item.Name,
                item.DateCreation.ToString("d"),
                item.Country
            };
            var listItem = new ListViewItem(itemsRow);
            listViewCompanies.Items.Add(listItem);
        }

        private void AddProductInListView(Product item)
        {
            var itemsRow = new string[]
            {
                item.Id.ToString(),
                _companyService.CompanyName(item.CompanyId),
                item.Category,
                item.Type,
                item.Price.ToString(),
                item.Destination != null ? item.Destination.ToString() : string.Empty,
                item.CompanyId.ToString(),
            };

            var listItem = new ListViewItem(itemsRow);
            listViewProduct.Items.Add(listItem);
        }

        public void UpdateMode(Company editItem, int row)
        {
            listViewCompanies.Items[row].SubItems[IndexId].Text = editItem.Id.ToString();
            listViewCompanies.Items[row].SubItems[IndexColumnCompanyName].Text = editItem.Name.ToString();
            listViewCompanies.Items[row].SubItems[IndexColumnDataCreate].Text = editItem.DateCreation.ToString("d");
            listViewCompanies.Items[row].SubItems[IndexColumnCountry].Text = editItem.Country.ToString();
        }

        public void UpdateProduct(Product editItem, int row)
        {
            listViewProduct.Items[row].SubItems[IndexId].Text = editItem.Id.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnCompanyName].Text = _companyService.CompanyName(editItem.CompanyId);
            listViewProduct.Items[row].SubItems[IndexColumnCategory].Text = editItem.Category == null ? string.Empty : editItem.Category.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnType].Text = editItem.Type == null ? string.Empty : editItem.Type.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnPrice].Text = editItem.Price.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnDestination].Text = editItem.Destination.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnIdCompany].Text = editItem.CompanyId.ToString();
        }

        private void RemoveItemRowListViewCompany()
        {
            for (var i = 0; i < listViewCompanies.Items.Count; i++)
            {
                var item = listViewCompanies.Items[i];
                if (item.Selected)
                {
                    var id = CellElement(item, IndexId).ParseInt();
                    _productService.RemoveStepRelatedToMode(id);
                    _companyService.Remove(id);
                }
            }
        }

        private void CustomUpdateFormStateCompanyPagination()
        {
            var hasPageControl = _pagedListCompany.PageCount > 0 ? true : false;

            btnFirstPageCompanies.Enabled =
                btnLastPageCompanies.Enabled =
                    btnNextPageCompanies.Enabled =
                        btnBackPageCompanies.Enabled =
                                textBoxCurrentPageCompanies.Enabled =
                                    hasPageControl;

            btnFirstPageCompanies.Visible =
                btnLastPageCompanies.Visible =
                    btnNextPageCompanies.Visible =
                        btnBackPageCompanies.Visible =
                                textBoxCurrentPageCompanies.Visible =
                                    hasPageControl;
        }

        private void CustomUpdateFormStateProductPagination()
        {
            var hasPageControl = _pagedListProduct.PageCount > 0 ? true : false;

            btnFirstPageProducts.Enabled =
                btnLastPageProduct.Enabled =
                    btnNextPageProduct.Enabled =
                        btnBackPageProducts.Enabled =
                            textBoxCurrentPageProduct.Enabled =
                                    hasPageControl;

            btnFirstPageProducts.Visible =
                btnLastPageProduct.Visible =
                    btnNextPageProduct.Visible =
                        btnBackPageProducts.Visible =
                            textBoxCurrentPageProduct.Visible =
                                    hasPageControl;
        }

        private void BtnFirstPageCompany_Click(object sender, EventArgs e)
        {
            if (_pagedListCompany.HasPrevious)
            {
                PageCompany.Number = 1;
            }
        }

        private void BtnBackPageCompany_Click(object sender, EventArgs e)
        {
            if (_pagedListCompany.HasPrevious)
            {
                PageCompany.Number--;
            }
        }

        private void BtnNextPageCompany_Click(object sender, EventArgs e)
        {
            if (_pagedListCompany.HasNext)
            {
                PageCompany.Number++;
            }
        }

        private void BtnLastPageCompany_Click(object sender, EventArgs e)
        {
            if (_pagedListCompany.HasNext)
            {
                PageCompany.Number = _pagedListCompany.PageCount;
            }
        }

        private void BtnFirstPageProduct_Click(object sender, EventArgs e)
        {
            if (_pagedListProduct.HasPrevious)
            {
                PageProduct.Number = 1;
            }
        }

        private void BtnBackPageProduct_Click(object sender, EventArgs e)
        {
            if (_pagedListProduct.HasPrevious)
            {
                PageProduct.Number--;
            }
        }

        private void BtnNextPageProduct_Click(object sender, EventArgs e)
        {
            if (_pagedListProduct.HasNext)
            {
                PageProduct.Number++;
            }
        }

        private void BtnLastPageProduct_Click(object sender, EventArgs e)
        {
            if (_pagedListProduct.HasNext)
            {
                PageProduct.Number = _pagedListProduct.PageCount;
            }
        }

        private bool IsNotFirstPageCompanyEmpty() => _pagedListCompany.Count == 0 && PageCompany.Number != 1;

        private bool IsNotFirstPageProductEmpty() => _pagedListProduct.Count == 0 && PageProduct.Number != 1;

        private void SizeChangedListView(ListView listView)
        {
            if (listView != null)
            {
                float totalColumnWidth = 0;

                for (int i = 0; i < listView.Columns.Count; i++)
                    totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                //Column Tage = Width custom size
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    float colPercenTage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                    listView.Columns[i].Width = (int)(colPercenTage * listView.ClientRectangle.Width);
                }
            }
        }
    }
}
