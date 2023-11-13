using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.ChildForms.Import;
using TestTask.Control.PageTabControls.Model;
using TestTask.Core;
using TestTask.Core.Export;
using TestTask.Core.Export.SheetFillers;
using TestTask.Core.Extension;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;

namespace TestTask.Forms
{
    public partial class MainForm : BaseForm
    {
        private const string Company = "Company";
        private const string Product = "Product";
        private const string Category = "Category";

        private readonly IServiceProvider _serviceProvider;
        private readonly CompanyService _companyService;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly IMessageBox _messageBox;

        private IInitialize[] _initializeProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _companyService = _serviceProvider.GetRequiredService<CompanyService>();
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _productService = _serviceProvider.GetRequiredService<ProductService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
            _initializeProvider = new IInitialize[] { listViewCompany, listViewCategory, listViewProduct };
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            foreach (var item in _initializeProvider)
            {
                item.Initialize(_serviceProvider);
            }
        }

        private void TabControl_Changed(object sender, EventArgs e)
        {
            var selectTab = tabControl.SelectedTab;

            if (selectTab == tabPageCompanies)
            {
                listViewCompany.LoadData();
            }
            else if (selectTab == tabPageCategory)
            {
                listViewCategory.LoadData();
            }
            else if (selectTab == tabPageProduct)
            {
                listViewProduct.LoadData();
            }

            return;
        }

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

                    listViewProduct.LoadData();

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

        private void TsmItemClose_Click(object sender, EventArgs e) => Close();
    }
}
