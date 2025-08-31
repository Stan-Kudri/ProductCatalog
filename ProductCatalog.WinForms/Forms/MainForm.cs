using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Controls.PageTabControls.Model;
using ProductCatalog.Core;
using ProductCatalog.Core.DataTable;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Export;
using ProductCatalog.Core.Export.SheetFillers;
using ProductCatalog.Core.Export.SheetFillers.Model;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.WinForms.Forms.Import;
using ProductCatalog.WinForms.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductCatalog.WinForms.Forms
{
    public partial class MainForm : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly CompanyService _companyService;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly ProductTypeService _typeRepository;
        private readonly ExcelImporterModel _importExcel;
        private readonly IMessageBox _messageBox;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _companyService = _serviceProvider.GetRequiredService<CompanyService>();
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _typeRepository = _serviceProvider.GetRequiredService<ProductTypeService>();
            _productService = _serviceProvider.GetRequiredService<ProductService>();
            _importExcel = _serviceProvider.GetRequiredService<ExcelImporterModel>();
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
            var selectTable = new HashSet<Table>();

            using (var impotDbForExcel = _serviceProvider.GetRequiredService<ImportDatabaseForm>())
            {
                if (impotDbForExcel.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                selectTable = impotDbForExcel.GetSelectTable();
            }

            using (var openReplaceDataFromFile = _serviceProvider.GetRequiredService<OpenFileDialog>())
            {
                if (openReplaceDataFromFile.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                var path = openReplaceDataFromFile.FileName;
                try
                {
                    await _importExcel.UpdataDB(selectTable, path);
                }
                catch (BusinessLogicException exeption)
                {
                    await _messageBox.ShowError(exeption.Message);
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

                var fillers = new ISheetFiller[]
                {
                    new CompanySheetFiller(_companyService),
                    new ProductSheetFiller(_productService),
                    new CategorySheetFiller(_categoryService),
                    new TypeSheetFiller(_typeRepository),
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
