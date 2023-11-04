using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem.UserBinding;
using TestTask.ChildForms.Import;
using TestTask.Core;
using TestTask.Core.Export;
using TestTask.Core.Export.SheetFillers;
using TestTask.Core.Extension;
using TestTask.Core.Import;
using TestTask.Core.Models.Company;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Steeps;
using TestTask.Extension;
using TestTask.Forms.CompanyForm;
using TestTask.Forms.StepForm;

namespace TestTask.Forms
{
    public partial class TableForm : BaseForm
    {
        private const string Company = "Company";
        private const string Step = "Step";

        private const string MessageNotSelectedItem = "No items selected";

        private const int NoItemsSelected = 0;

        //Index column from all tables
        public const int IndexId = 0;
        private const int IndexColumnCompanyName = 1;

        //Index column Company table
        private const int IndexColumnDataCreate = 2;
        private const int IndexColumnCountry = 3;

        //Index column Step table
        private const int IndexColumnTimer = 2;
        private const int IndexColumnDestination = 3;
        private const int IndexColumnSpeed = 4;
        private const int IndexColumnType = 5;
        private const int IndexColumnVolume = 6;
        private const int IndexColumnModeId = 7;

        private readonly IServiceProvider _serviceProvider;
        private readonly CompanyService _companyService;
        private readonly StepService _stepService;
        private readonly IMessageBox _messageBox;

        private PagedList<Company> _pagedListCompany;
        private PagedList<Step> _pagedListStep;

        private bool Resizing = false;

        public TableForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _companyService = _serviceProvider.GetRequiredService<CompanyService>();
            _stepService = _serviceProvider.GetRequiredService<StepService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
        }

        public PageModel PageCompany { get; set; } = new PageModel();

        public PageModel PageStep { get; set; } = new PageModel();

        private void TableForm_Load(object sender, EventArgs e)
        {
            _pagedListCompany = new PagedList<Company>(_companyService.GetQueryableAll());
            _pagedListStep = new PagedList<Step>(_stepService.GetQueryableAll());
            cmbPageSizeCompanies.DataSource = PageCompany.Items;
            cmbPageSizeSteps.DataSource = PageStep.Items;
            UpdateAllGrids();
            PageCompany.ChangeCurrentPage += LoadDataMode;
            PageStep.ChangeCurrentPage += LoadDataStep;
        }

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            PageCompany.ChangeCurrentPage -= LoadDataMode;
            PageStep.ChangeCurrentPage -= LoadDataStep;
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            using (var addFormMode = _serviceProvider.GetRequiredService<AddItemCompanyForm>())
            {
                if (addFormMode.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = addFormMode.GetCompanyModel().ToMode();
                _companyService.Add(item);
                LoadDataMode();
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

        private void BtnAddStep_Click(object sender, EventArgs e)
        {
            var listCompany = _companyService.GetQueryableAll();

            if (listCompany.Count() == 0)
            {
                _messageBox.ShowWarning("Add a company to the table to add a step.");
                return;
            }

            using (var addFormStep = _serviceProvider.GetRequiredService<AddItemStepForm>())
            {
                addFormStep.Initialize(listCompany.ToList());

                if (addFormStep.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = addFormStep.GetStepModel().ToStep();
                _stepService.Add(item);
                LoadDataStep();
            }
        }

        private void BtnEditStep_Click(object sender, EventArgs e)
        {
            var indexEditRow = listViewSteps.SelectedIndices.Cast<int>();

            if (indexEditRow.Count() != 1)
            {
                _messageBox.ShowWarning("Select one item.");
                return;
            }

            var listMode = _companyService.GetAll();
            var indexRow = indexEditRow.First();
            var oldItem = GetStep(indexRow);

            using (var editStepForm = _serviceProvider.GetRequiredService<EditItemStepForm>())
            {
                editStepForm.Initialize(listMode, oldItem);

                if (editStepForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var updateItem = editStepForm.GetEditStep();
                _stepService.Update(updateItem);
                UpdateStep(updateItem, indexRow);
            }
        }

        private void BtnDeleteStep_Click(object sender, EventArgs e)
        {
            var selectedRow = listViewSteps.SelectedIndices.Count;
            if (selectedRow == NoItemsSelected)
            {
                _messageBox.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!_messageBox.ShowQuestion("Delete selected items?"))
            {
                foreach (ListViewItem item in listViewSteps.Items)
                {
                    item.Selected = false;
                }
                return;
            }

            listViewSteps.Remove(_stepService);
            LoadDataStep();
        }

        private void TsmImportFromExcel_Click(object sender, EventArgs e)
        {
            var loadTable = new Dictionary<string, bool>()
            {
                { Company, false },
                { Step, false },
            };

            using (var impotDbForExcel = _serviceProvider.GetRequiredService<ImportDatabaseForm>())
            {
                if (impotDbForExcel.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                loadTable[Company] = impotDbForExcel.IsDownloadTableMode;
                loadTable[Step] = impotDbForExcel.IsDownloadTableStep;
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
                    var modeRead = _serviceProvider.GetRequiredService<ExcelImporter<Company>>().ImportFromFile(path);

                    foreach (var item in modeRead)
                    {
                        if (item.Success)
                        {
                            _companyService.AddImportData(item.Value);
                        }
                    }

                    LoadDataMode();

                    if (!modeRead.IsNoErrorLine(out var message))
                    {
                        _messageBox.ShowWarning(message, Company);
                    }
                }

                if (loadTable[Step])
                {
                    var stepRead = _serviceProvider.GetRequiredService<ExcelImporter<Step>>().ImportFromFile(path);

                    foreach (var item in stepRead)
                    {
                        if (item.Success)
                        {
                            _stepService.AddImportData(item.Value);
                        }
                    }

                    LoadDataStep();

                    if (!stepRead.IsNoErrorLine(out var message))
                    {
                        _messageBox.ShowWarning(message, Step);
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
                var stepSheetFiller = new StepSheetFiller(_stepService);

                var fillers = new ISheetFiller[]
                {
                companySheetFiller,
                stepSheetFiller,
                };

                var writeExcel = new ExcelExporter(fillers);
                writeExcel.ExportToFile(path);
            }
        }

        private void TlpListStep_SizeChanged(object sender, EventArgs e)
        {
            if (!Resizing)
            {
                Resizing = true;
                SizeChangedListView(listViewSteps);
            }
            Resizing = false;
        }

        private void TlpModesList_SizeChanged(object sender, EventArgs e)
        {
            if (!Resizing)
            {
                Resizing = true;
                SizeChangedListView(listViewCompanies);
            }
            Resizing = false;
        }

        private void TsmItemClose_Click(object sender, EventArgs e) => Close();

        private void CmbPageSizeModes_Changed(object sender, EventArgs e)
        {
            var pageSizeCmb = PageCompany.Items[cmbPageSizeCompanies.SelectedIndex];

            if (PageCompany.ChangedPage(pageSizeCmb))
            {
                PageCompany.Size = pageSizeCmb;
                PageCompany.Number = 1;
            }
        }

        private void CmbPageSizeSteps_Changed(object sender, EventArgs e)
        {
            var pageSizeCmb = PageStep.Items[cmbPageSizeSteps.SelectedIndex];

            if (PageStep.ChangedPage(pageSizeCmb))
            {
                PageStep.Size = pageSizeCmb;
                PageStep.Number = 1;
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

        private void TextBoxCurrentPageStep_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCurrentPageStep.Text, out var pageNumber)
                && pageNumber <= _pagedListStep.PageCount
                && _pagedListStep.PageNumber == PageStep.Number)
            {
                PageStep.Number = pageNumber;
            }

            textBoxCurrentPageStep.Text = string.Format("{0}/{1}", PageStep.Number, _pagedListStep.PageCount);
        }

        private void LoadDataMode()
        {
            _pagedListCompany = _companyService.GetQueryableAll().GetPagedList(PageCompany.GetPage());
            if (IsNotFirstPageModesEmpty())
            {
                PageCompany.Number -= 1;
            }

            var item = _pagedListCompany.Items;

            listViewCompanies.Items.Clear();
            FillListViewMode(item);
            CustomUpdateFormStateModesPagination();

            textBoxCurrentPageCompanies.Text = _pagedListCompany.PageNumber.ToString();
        }

        private void LoadDataStep()
        {
            _pagedListStep = _stepService.GetQueryableAll().GetPagedList(PageStep.GetPage());
            if (IsNotFirstPageStepsEmpty())
            {
                PageStep.Number -= 1;
            }

            var item = _pagedListStep.Items;

            listViewSteps.Items.Clear();
            FillListViewStep(item);
            CustomUpdateFormStateStepsPagination();

            textBoxCurrentPageStep.Text = _pagedListStep.PageNumber.ToString();
        }

        private void UpdateAllGrids()
        {
            LoadDataMode();
            LoadDataStep();
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

        private Step GetStep(int indexRow)
        {
            var rowItem = listViewSteps.Items[indexRow];

            var idStep = CellElement(rowItem, IndexId).ParseInt();
            var timer = CellElement(rowItem, IndexColumnTimer).ParseInt();
            var destination = CellElement(rowItem, IndexColumnDestination);
            var speed = CellElement(rowItem, IndexColumnSpeed).ParseInt();
            var type = CellElement(rowItem, IndexColumnType) ?? throw new Exception("Type cannot be null.");
            var volume = CellElement(rowItem, IndexColumnVolume).ParseInt();
            var modeId = CellElement(rowItem, IndexColumnModeId).ParseInt();

            return new Step(modeId, timer, destination, speed, type, volume, idStep);
        }

        private string CellElement(ListViewItem rowItem, int indexColumn) => rowItem.GetString(indexColumn) ?? throw new Exception("String cannot be null.");

        private void FillListViewMode(List<Company> items)
        {
            foreach (var item in items)
            {
                AddModeInListView(item);
            }
        }

        private void FillListViewStep(List<Step> items)
        {
            foreach (var item in items)
            {
                AddStepInListView(item);
            }
        }

        private void AddModeInListView(Company item)
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

        private void AddStepInListView(Step item)
        {
            var itemsRow = new string[]
            {
                item.Id.ToString(),
                _companyService.NameMode(item.CompanyId),
                item.Timer.ToString(),
                item.Destination != null ? item.Destination.ToString() : string.Empty,
                item.Speed.ToString(),
                item.Type,
                item.Volume.ToString(),
                item.CompanyId.ToString(),
            };

            var listItem = new ListViewItem(itemsRow);
            listViewSteps.Items.Add(listItem);
        }

        public void UpdateMode(Company editItem, int row)
        {
            listViewCompanies.Items[row].SubItems[IndexId].Text = editItem.Id.ToString();
            listViewCompanies.Items[row].SubItems[IndexColumnCompanyName].Text = editItem.Name.ToString();
            listViewCompanies.Items[row].SubItems[IndexColumnDataCreate].Text = editItem.DateCreation.ToString();
            listViewCompanies.Items[row].SubItems[IndexColumnCountry].Text = editItem.Country.ToString();
        }

        public void UpdateStep(Step editItem, int row)
        {
            listViewSteps.Items[row].SubItems[IndexId].Text = editItem.Id.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnCompanyName].Text = _companyService.NameMode(editItem.CompanyId);
            listViewSteps.Items[row].SubItems[IndexColumnTimer].Text = editItem.Timer.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnDestination].Text = editItem.Destination == null ? string.Empty : editItem.Destination.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnSpeed].Text = editItem.Speed.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnType].Text = editItem.Type.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnVolume].Text = editItem.Volume.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnModeId].Text = editItem.CompanyId.ToString();
        }

        private void RemoveItemRowListViewCompany()
        {
            for (var i = 0; i < listViewCompanies.Items.Count; i++)
            {
                var item = listViewCompanies.Items[i];
                if (item.Selected)
                {
                    var id = CellElement(item, IndexId).ParseInt();
                    _stepService.RemoveStepRelatedToMode(id);
                    _companyService.Remove(id);
                }
            }
        }

        private void CustomUpdateFormStateModesPagination()
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

        private void CustomUpdateFormStateStepsPagination()
        {
            var hasPageControl = _pagedListStep.PageCount > 0 ? true : false;

            btnFirstPageSteps.Enabled =
                btnLastPageSteps.Enabled =
                    btnNextPageSteps.Enabled =
                        btnBackPageSteps.Enabled =
                            textBoxCurrentPageStep.Enabled =
                                    hasPageControl;

            btnFirstPageSteps.Visible =
                btnLastPageSteps.Visible =
                    btnNextPageSteps.Visible =
                        btnBackPageSteps.Visible =
                            textBoxCurrentPageStep.Visible =
                                    hasPageControl;
        }

        private void BtnFirstPageModes_Click(object sender, EventArgs e)
        {
            if (_pagedListCompany.HasPrevious)
            {
                PageCompany.Number = 1;
            }
        }

        private void BtnBackPageModes_Click(object sender, EventArgs e)
        {
            if (_pagedListCompany.HasPrevious)
            {
                PageCompany.Number--;
            }
        }

        private void BtnNextPageModes_Click(object sender, EventArgs e)
        {
            if (_pagedListCompany.HasNext)
            {
                PageCompany.Number++;
            }
        }

        private void BtnLastPageModes_Click(object sender, EventArgs e)
        {
            if (_pagedListCompany.HasNext)
            {
                PageCompany.Number = _pagedListCompany.PageCount;
            }
        }

        private void BtnFirstPageSteps_Click(object sender, EventArgs e)
        {
            if (_pagedListStep.HasPrevious)
            {
                PageStep.Number = 1;
            }
        }

        private void BtnBackPageSteps_Click(object sender, EventArgs e)
        {
            if (_pagedListStep.HasPrevious)
            {
                PageStep.Number--;
            }
        }

        private void BtnNextPageSteps_Click(object sender, EventArgs e)
        {
            if (_pagedListStep.HasNext)
            {
                PageStep.Number++;
            }
        }

        private void BtnLastPageSteps_Click(object sender, EventArgs e)
        {
            if (_pagedListStep.HasNext)
            {
                PageStep.Number = _pagedListStep.PageCount;
            }
        }

        private bool IsNotFirstPageModesEmpty() => _pagedListCompany.Count == 0 && PageCompany.Number != 1;

        private bool IsNotFirstPageStepsEmpty() => _pagedListStep.Count == 0 && PageStep.Number != 1;

        private void SizeChangedListView(System.Windows.Forms.ListView listView)
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
