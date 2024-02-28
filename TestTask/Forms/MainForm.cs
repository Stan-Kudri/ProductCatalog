using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.ChildForms.Import;
using TestTask.Controls.PageTabControls.Model;
using TestTask.Core;
using TestTask.Core.Export;
using TestTask.Core.Export.SheetFillers;
using TestTask.Core.Extension;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;

namespace TestTask.Forms
{
    public partial class MainForm : BaseForm
    {
        private const string Company = "Company";
        private const string Product = "Product";
        private const string Category = "Category";
        private const string Type = "Type";

        private readonly IServiceProvider _serviceProvider;
        private readonly CompanyRepository _companyRepository;
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductTypeRepository _typeRepository;
        private readonly IMessageBox _messageBox;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _companyRepository = _serviceProvider.GetRequiredService<CompanyRepository>();
            _categoryRepository = _serviceProvider.GetRequiredService<CategoryRepository>();
            _typeRepository = _serviceProvider.GetRequiredService<ProductTypeRepository>();
            _productRepository = _serviceProvider.GetRequiredService<ProductRepository>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl.Controls)
            {
                foreach (var control in tab.Controls)
                {
                    if (control is IInitialize controlInitialize)
                    {
                        controlInitialize.Initialize(_serviceProvider);
                    }
                }
            }
        }

        private void TabControl_Changed(object sender, EventArgs e)
            => LoadDataSelectTabPage();

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
            => DialogResult = DialogResult.Cancel;

        private async void TsmImportFromExcel_Click(object sender, EventArgs e)
        {
            var loadTable = new Dictionary<string, bool>()
            {
                { Company, false },
                { Product, false },
                { Category, false },
                { Type, false },
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
                loadTable[Type] = impotDbForExcel.IsDownloadTableType;
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
                            _companyRepository.Upsert(item.Value);
                        }
                    }

                    if (!companyRead.IsNoErrorLine(out var message))
                    {
                        await _messageBox.ShowWarning(message, Company);
                    }
                }

                if (loadTable[Category])
                {
                    var categoryRead = _serviceProvider.GetRequiredService<ExcelImporter<Category>>().ImportFromFile(path);

                    foreach (var item in categoryRead)
                    {
                        if (item.Success)
                        {
                            _categoryRepository.Upsert(item.Value);
                        }
                    }

                    if (!categoryRead.IsNoErrorLine(out var message))
                    {
                        await _messageBox.ShowWarning(message, Category);
                    }
                }

                if (loadTable[Type])
                {
                    var typeRead = _serviceProvider.GetRequiredService<ExcelImporter<ProductType>>().ImportFromFile(path);

                    foreach (var item in typeRead)
                    {
                        if (item.Success)
                        {
                            _typeRepository.Upsert(item.Value);
                        }
                    }

                    if (!typeRead.IsNoErrorLine(out var message))
                    {
                        await _messageBox.ShowWarning(message, Category);
                    }
                }

                if (loadTable[Product])
                {
                    var productRead = _serviceProvider.GetRequiredService<ExcelImporter<Product>>().ImportFromFile(path);

                    foreach (var item in productRead)
                    {
                        if (item.Success)
                        {
                            _productRepository.Upsert(item.Value);
                        }
                    }

                    if (!productRead.IsNoErrorLine(out var message))
                    {
                        await _messageBox.ShowWarning(message, Product);
                    }
                }
            }

            LoadDataSelectTabPage();
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

                var companySheetFiller = new CompanySheetFiller(_companyRepository);
                var productSheetFiller = new ProductSheetFiller(_productRepository);
                var categorySheetFiller = new CategorySheetFiller(_categoryRepository);
                var typeSheetFiller = new TypeSheetFiller(_typeRepository);

                var fillers = new ISheetFiller[]
                {
                    companySheetFiller,
                    productSheetFiller,
                    categorySheetFiller,
                    typeSheetFiller,
                };

                var writeExcel = new ExcelExporter(fillers);
                writeExcel.ExportToFile(path);
            }
        }

        private void TsmItemClose_Click(object sender, EventArgs e) => Close();

        private void LoadDataSelectTabPage()
        {
            var selectTab = tabControl.SelectedTab;

            foreach (var control in selectTab.Controls)
            {
                if (control is ILoad loadListView)
                {
                    loadListView.LoadData();
                }
            }
        }
    }
}
