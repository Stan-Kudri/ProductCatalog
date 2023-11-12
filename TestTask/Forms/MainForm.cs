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
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Products;
using TestTask.Extension;
using TestTask.Forms.Companies;
using TestTask.Forms.Products;

namespace TestTask.Forms
{
    public partial class MainForm : BaseForm
    {
        private const string Company = "Company";
        private const string Product = "Product";
        private const string Category = "Category";

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
        private const int IndexColumnIdCategory = 7;

        private readonly IServiceProvider _serviceProvider;
        private readonly CompanyService _companyService;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly IMessageBox _messageBox;

        private PagedList<Company> _pagedListCompany;
        private PagedList<Product> _pagedListProduct;

        private bool Resizing = false;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _companyService = _serviceProvider.GetRequiredService<CompanyService>();
            _productService = _serviceProvider.GetRequiredService<ProductService>();
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
        }

        public PageModel PageCompany { get; set; } = new PageModel();

        public PageModel PageProduct { get; set; } = new PageModel();

        private void TableForm_Load(object sender, EventArgs e)
        {
            _pagedListCompany = new PagedList<Company>(_companyService.GetQueryableAll());
            _pagedListProduct = new PagedList<Product>(_productService.GetQueryableAll());
            listViewCategory.Initialize(_serviceProvider);
            listViewCompany.Initialize(_serviceProvider);
            cmbPageSizeCompanies.DataSource = PageCompany.Items;
            cmbPageSizeProduct.DataSource = PageProduct.Items;
            UpdataAllGrids();
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
                UpdateCompany(updateItem, row);
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
            UpdataAllGrids();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            var listCompany = _companyService.GetQueryableAll();
            var listCategory = _categoryService.GetQueryableAll();

            if (listCompany.Count() == 0)
            {
                _messageBox.ShowWarning("Add a company to the table to add a product.");
                return;
            }

            if (listCategory.Count() == 0)
            {
                _messageBox.ShowWarning("Add a category to the table to add a product.");
                return;
            }

            using (var addFormProduct = _serviceProvider.GetRequiredService<AddItemProductForm>())
            {
                addFormProduct.Initialize(listCompany.ToList(), listCategory.ToList());

                if (addFormProduct.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = addFormProduct.GetProductModel().ToStep();
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
            var listCategory = _categoryService.GetAll();
            var indexRow = indexEditRow.First();
            var oldItem = GetProduct(indexRow);

            using (var editProductForm = _serviceProvider.GetRequiredService<EditItemProductForm>())
            {
                editProductForm.Initialize(listCompany, listCategory, oldItem);

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
                { Category, false },
            };

            using (var impotDbForExcel = _serviceProvider.GetRequiredService<ImportDatabaseForm>())
            {
                if (impotDbForExcel.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                loadTable[Company] = impotDbForExcel.IsDownloadTableCompany;
                loadTable[Product] = impotDbForExcel.IsDownloadTableProduct;
                loadTable[Category] = impotDbForExcel.IsDownloadTableCategory;
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
                    listViewCompany.LoadData();

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

                if (loadTable[Category])
                {
                    var categoryRead = _serviceProvider.GetRequiredService<ExcelImporter<Category>>().ImportFromFile(path);

                    foreach (var item in categoryRead)
                    {
                        if (item.Success)
                        {
                            _categoryService.AddImportData(item.Value);
                        }
                    }

                    listViewCategory.LoadData();

                    if (!categoryRead.IsNoErrorLine(out var message))
                    {
                        _messageBox.ShowWarning(message, Category);
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
                var productSheetFiller = new ProductSheetFiller(_productService);
                var categorySheetFiller = new CategorySheetFiller(_categoryService);

                var fillers = new ISheetFiller[]
                {
                    companySheetFiller,
                    productSheetFiller,
                    categorySheetFiller,
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
            if (int.TryParse(tbCurrentPageCompanies.Text, out var pageNumber)
                && pageNumber <= _pagedListCompany.PageCount
                && _pagedListCompany.PageNumber == PageCompany.Number)
            {
                PageCompany.Number = pageNumber;
            }

            tbCurrentPageCompanies.Text = string.Format("{0}/{1}", PageCompany.Number, _pagedListCompany.PageCount);
        }

        private void TextBoxCurrentPageProduct_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbCurrentPageProduct.Text, out var pageNumber)
                && pageNumber <= _pagedListProduct.PageCount
                && _pagedListProduct.PageNumber == PageProduct.Number)
            {
                PageProduct.Number = pageNumber;
            }

            tbCurrentPageProduct.Text = string.Format("{0}/{1}", PageProduct.Number, _pagedListProduct.PageCount);
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
            FillListViewCompany(item);
            CustomUpdateFormStateCompanyPagination();

            tbCurrentPageCompanies.Text = _pagedListCompany.PageNumber.ToString();
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

            tbCurrentPageProduct.Text = _pagedListProduct.PageNumber.ToString();
        }

        private void UpdataAllGrids()
        {
            LoadDataCompany();
            LoadDataProduct();
            listViewCategory.LoadData();
            listViewCompany.LoadData();
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

            var idProduct = CellElement(rowItem, IndexId).ParseInt();
            var type = CellElement(rowItem, IndexColumnType) ?? throw new Exception("Type cannot be null.");
            var price = CellElement(rowItem, IndexColumnPrice).ParseDecimal();
            var destination = CellElement(rowItem, IndexColumnDestination);
            var companyId = CellElement(rowItem, IndexColumnIdCompany).ParseInt();
            var categoryId = CellElement(rowItem, IndexColumnIdCategory).ParseInt();

            return new Product(companyId, categoryId, type, destination, price, idProduct);
        }

        private string CellElement(ListViewItem rowItem, int indexColumn) => rowItem.GetString(indexColumn) ?? throw new Exception("String cannot be null.");

        private void FillListViewCompany(List<Company> items)
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
                _categoryService.GetName(item.CategoryId),
                item.Type,
                item.Price.ToString(),
                item.Destination != null ? item.Destination.ToString() : string.Empty,
                item.CompanyId.ToString(),
                item.CategoryId.ToString(),
            };

            var listItem = new ListViewItem(itemsRow);
            listViewProduct.Items.Add(listItem);
        }

        public void UpdateCompany(Company editItem, int row)
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
            listViewProduct.Items[row].SubItems[IndexColumnCategory].Text = _categoryService.GetName(editItem.CategoryId);
            listViewProduct.Items[row].SubItems[IndexColumnType].Text = editItem.Type == null ? string.Empty : editItem.Type.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnPrice].Text = editItem.Price.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnDestination].Text = editItem.Destination.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnIdCompany].Text = editItem.CompanyId.ToString();
            listViewProduct.Items[row].SubItems[IndexColumnIdCategory].Text = editItem.CategoryId.ToString();
        }

        private void RemoveItemRowListViewCompany()
        {
            for (var i = 0; i < listViewCompanies.Items.Count; i++)
            {
                var item = listViewCompanies.Items[i];
                if (item.Selected)
                {
                    var id = CellElement(item, IndexId).ParseInt();
                    _productService.RemoveProductRelatedToCompany(id);
                    _companyService.Remove(id);
                }
            }
        }

        private void CustomUpdateFormStateCompanyPagination()
        {
            btnFirstPageCompanies.Enabled = btnFirstPageCompanies.Visible =
                btnLastPageCompanies.Enabled = btnLastPageCompanies.Visible =
                    btnNextPageCompanies.Enabled = btnNextPageCompanies.Visible =
                        btnBackPageCompanies.Enabled = btnBackPageCompanies.Visible =
                                tbCurrentPageCompanies.Enabled = tbCurrentPageCompanies.Visible =
                                    _pagedListCompany.PageCount > 0 ? true : false;
        }

        private void CustomUpdateFormStateProductPagination()
        {
            btnFirstPageProducts.Enabled = btnFirstPageProducts.Visible =
                btnLastPageProduct.Enabled = btnLastPageProduct.Visible =
                    btnNextPageProduct.Enabled = btnNextPageProduct.Visible =
                        btnBackPageProducts.Enabled = btnBackPageProducts.Visible =
                            tbCurrentPageProduct.Enabled = tbCurrentPageProduct.Visible =
                                    _pagedListProduct.PageCount > 0 ? true : false;
        }

        //Button Company page click
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

        //Button Product page click
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
