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
using TestTask.Core.Models.Modes;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Steeps;
using TestTask.Extension;
using TestTask.Forms.ModeForm;
using TestTask.Forms.StepForm;

namespace TestTask.Forms
{
    public partial class TableForm : BaseForm
    {
        private const string Mode = "Mode";
        private const string Step = "Step";

        private const string MessageNotSelectedItem = "No items selected";

        private const int NoItemsSelected = 0;

        //Index column from all tables
        public const int IndexId = 0;
        private const int IndexColumnModeName = 1;

        //Index column Mode table
        private const int IndexColumnMaxBottle = 2;
        private const int IndexColumnMaxUsedTips = 3;

        //Index column Mode table
        private const int IndexColumnTimer = 2;
        private const int IndexColumnDestination = 3;
        private const int IndexColumnSpeed = 4;
        private const int IndexColumnType = 5;
        private const int IndexColumnVolume = 6;
        private const int IndexColumnModeId = 7;

        private readonly IServiceProvider _serviceProvider;
        private readonly ModeService _modeService;
        private readonly StepService _stepService;
        private readonly IMessageBox _messageBox;

        private PagedList<Mode> _pagedListMode;
        private PagedList<Step> _pagedListStep;

        public TableForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _modeService = _serviceProvider.GetRequiredService<ModeService>();
            _stepService = _serviceProvider.GetRequiredService<StepService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
            DoubleBuffered = true;
        }

        public PageModel PageMode { get; set; } = new PageModel();

        public PageModel PageStep { get; set; } = new PageModel();

        private void BtnAddMode_Click(object sender, EventArgs e)
        {
            using (var addFormMode = _serviceProvider.GetRequiredService<AddItemModeForm>())
            {
                if (addFormMode.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = addFormMode.GetModeModel().ToMode();
                _modeService.Add(item);
                LoadDataMode();
            }
        }

        private void BtnEditMode_Click(object sender, EventArgs e)
        {
            var indexEditItem = listViewModes.SelectedIndices.Cast<int>();

            if (indexEditItem.Count() != 1)
            {
                _messageBox.ShowWarning("Select one item.");
                return;
            }

            var row = indexEditItem.First();
            var oldItem = GetMode(row);

            using (var editModeForm = _serviceProvider.GetRequiredService<EditItemModeForm>())
            {
                editModeForm.Initialize(oldItem);

                if (editModeForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var updateItem = editModeForm.GetEditMode();
                _modeService.Update(updateItem);
                UpdateMode(updateItem, row);
            }
        }

        private void BtnDeleteMode_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = listViewModes.SelectedIndices;

            if (selectedRowIndex.Count == NoItemsSelected)
            {
                _messageBox.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!_messageBox.ShowQuestion("Delete selected items?"))
            {
                foreach (ListViewItem item in listViewModes.Items)
                {
                    item.Selected = false;
                }
                return;
            }

            RemoveItemRowListViewMode();
            LoadDataMode();
            LoadDataStep();
        }

        private void BtnAddStep_Click(object sender, EventArgs e)
        {
            var listMode = _modeService.GetModes();

            if (listMode.Count() == 0)
            {
                _messageBox.ShowWarning("Add a mode to the table to add a step.");
                return;
            }

            using (var addFormStep = _serviceProvider.GetRequiredService<AddItemStepForm>())
            {
                addFormStep.Initialize(listMode.ToList());

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

            var listMode = _modeService.GetAll();
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
                { Mode, false },
                { Step, false },
            };

            using (var impotDbForExcel = _serviceProvider.GetRequiredService<ImportDatabaseForm>())
            {
                if (impotDbForExcel.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                loadTable[Mode] = impotDbForExcel.IsDownloadTableMode;
                loadTable[Step] = impotDbForExcel.IsDownloadTableStep;
            }

            using (var openReplaceDataFromFile = _serviceProvider.GetRequiredService<OpenFileDialog>())
            {
                if (openReplaceDataFromFile.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                var path = openReplaceDataFromFile.FileName;

                if (loadTable[Mode])
                {
                    var modeRead = _serviceProvider.GetRequiredService<ExcelImporter<Mode>>().ImportFromFile(path);

                    foreach (var item in modeRead)
                    {
                        if (item.Success)
                        {
                            _modeService.AddImportData(item.Value);
                        }
                    }

                    LoadDataMode();

                    if (!modeRead.IsNoErrorLine(out var message))
                    {
                        _messageBox.ShowWarning(message, Mode);
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

                var modeSheetFiller = new ModeSheetFiller(_modeService);
                var stepSheetFiller = new StepSheetFiller(_stepService);

                var fillers = new ISheetFiller[]
                {
                modeSheetFiller,
                stepSheetFiller,
                };

                var writeExcel = new ExcelExporter(fillers);
                writeExcel.ExportToFile(path);
            }
        }

        private void TsmItemClose_Click(object sender, EventArgs e) => Close();

        private void TableForm_Load(object sender, EventArgs e)
        {
            _pagedListMode = new PagedList<Mode>(_modeService.GetModes());
            _pagedListStep = new PagedList<Step>(_stepService.GetSteps());
            UpdateAllGrids();
            cmbPageSizeModes.DataSource = PageMode.Items;
            cmbPageSizeSteps.DataSource = PageStep.Items;
        }

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e) => DialogResult = DialogResult.Cancel;

        private void CmbPageSizeModes_Changed(object sender, EventArgs e)
        {
            var pageSizeCmb = PageMode.Items[cmbPageSizeModes.SelectedIndex];

            if (PageMode.ChangedPage(pageSizeCmb))
            {
                PageMode.Size = pageSizeCmb;
                PageMode.Number = 1;
                LoadDataMode();
            }
        }

        private void CmbPageSizeSteps_Changed(object sender, EventArgs e)
        {
            var pageSizeCmb = PageStep.Items[cmbPageSizeSteps.SelectedIndex];

            if (PageStep.ChangedPage(pageSizeCmb))
            {
                PageStep.Size = pageSizeCmb;
                PageStep.Number = 1;
                LoadDataStep();
            }
        }

        private void TextBoxCurrentPageMode_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCurrentPageMode.Text, out var pageNumber)
                && pageNumber <= _pagedListMode.PageCount
                && _pagedListMode.PageNumber == PageMode.Number)
            {
                PageMode.Number = pageNumber;
                LoadDataMode();
            }

            textBoxCurrentPageMode.Text = string.Format("{0}/{1}", PageMode.Number, _pagedListMode.PageCount);
        }

        private void TextBoxCurrentPageStep_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCurrentPageStep.Text, out var pageNumber)
                && pageNumber <= _pagedListStep.PageCount
                && _pagedListStep.PageNumber == PageStep.Number)
            {
                PageStep.Number = pageNumber;
                LoadDataStep();
            }

            textBoxCurrentPageStep.Text = string.Format("{0}/{1}", PageStep.Number, _pagedListStep.PageCount);
        }

        private void LoadDataMode()
        {
            _pagedListMode = _modeService.GetModes().GetPagedList(PageMode.GetPage());
            if (IsNotFirstPageModesEmpty())
            {
                PageMode.Number -= 1;
                LoadDataMode();
            }

            var item = _pagedListMode.Items;

            listViewModes.Items.Clear();
            FillListViewMode(item);
            CustomUpdateFormStateModesPagination();

            textBoxCurrentPageMode.Text = _pagedListMode.PageNumber.ToString();
        }

        private void LoadDataStep()
        {
            _pagedListStep = _stepService.GetSteps().GetPagedList(PageStep.GetPage());
            if (IsNotFirstPageStepsEmpty())
            {
                PageStep.Number -= 1;
                LoadDataStep();
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

        private Mode GetMode(int indexRow)
        {
            var rowItem = listViewModes.Items[indexRow];

            var idMode = CellElement(rowItem, IndexId).ParseInt();
            var nameMode = CellElement(rowItem, IndexColumnModeName) ?? throw new ArgumentException("Name cannot be null.");
            var maxBottle = CellElement(rowItem, IndexColumnMaxBottle).ParseInt();
            var maxUsedTips = CellElement(rowItem, IndexColumnMaxUsedTips).ParseInt();

            return new Mode(nameMode, maxBottle, maxUsedTips, idMode);
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

        private void FillListViewMode(List<Mode> items)
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

        private void AddModeInListView(Mode item)
        {
            var itemsRow = new string[]
            {
                item.Id.ToString(),
                item.Name,
                item.MaxBottleNumber.ToString(),
                item.MaxBottleNumber.ToString()
            };
            var listItem = new ListViewItem(itemsRow);
            listViewModes.Items.Add(listItem);
        }

        private void AddStepInListView(Step item)
        {
            var itemsRow = new string[]
            {
                item.Id.ToString(),
                _modeService.NameMode(item.ModeId),
                item.Timer.ToString(),
                item.Destination != null ? item.Destination.ToString() : string.Empty,
                item.Speed.ToString(),
                item.Type,
                item.Volume.ToString(),
                item.ModeId.ToString(),
            };

            var listItem = new ListViewItem(itemsRow);
            listViewSteps.Items.Add(listItem);
        }

        public void UpdateMode(Mode editItem, int row)
        {
            listViewModes.Items[row].SubItems[IndexId].Text = editItem.Id.ToString();
            listViewModes.Items[row].SubItems[IndexColumnModeName].Text = editItem.Name.ToString();
            listViewModes.Items[row].SubItems[IndexColumnMaxBottle].Text = editItem.MaxBottleNumber.ToString();
            listViewModes.Items[row].SubItems[IndexColumnMaxUsedTips].Text = editItem.MaxUsedTips.ToString();
        }

        public void UpdateStep(Step editItem, int row)
        {
            listViewSteps.Items[row].SubItems[IndexId].Text = editItem.Id.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnModeName].Text = _modeService.NameMode(editItem.ModeId);
            listViewSteps.Items[row].SubItems[IndexColumnTimer].Text = editItem.Timer.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnDestination].Text = editItem.Destination == null ? string.Empty : editItem.Destination.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnSpeed].Text = editItem.Speed.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnType].Text = editItem.Type.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnVolume].Text = editItem.Volume.ToString();
            listViewSteps.Items[row].SubItems[IndexColumnModeId].Text = editItem.ModeId.ToString();
        }

        private void RemoveItemRowListViewMode()
        {
            for (var i = 0; i < listViewModes.Items.Count; i++)
            {
                var item = listViewModes.Items[i];
                if (item.Selected)
                {
                    var id = CellElement(item, IndexId).ParseInt();
                    _stepService.RemoveStepRelatedToMode(id);
                    _modeService.Remove(id);
                }
            }
        }

        private void CustomUpdateFormStateModesPagination()
        {
            var hasPageControl = _pagedListMode.PageCount > 0 ? true : false;

            btnFirstPageModes.Enabled =
                btnLastPageModes.Enabled =
                    btnNextPageModes.Enabled =
                        btnBackPageModes.Enabled =
                                textBoxCurrentPageMode.Enabled =
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
        }

        private void BtnFirstPageModes_Click(object sender, EventArgs e)
        {
            if (_pagedListMode.HasPrevious)
            {
                PageMode.Number = 1;
                LoadDataMode();
            }
        }

        private void BtnBackPageModes_Click(object sender, EventArgs e)
        {
            if (_pagedListMode.HasPrevious)
            {
                PageMode.Number--;
                LoadDataMode();
            }
        }

        private void BtnNextPageModes_Click(object sender, EventArgs e)
        {
            if (_pagedListMode.HasNext)
            {
                PageMode.Number++;
                LoadDataMode();
            }
        }

        private void BtnLastPageModes_Click(object sender, EventArgs e)
        {
            if (_pagedListMode.HasNext)
            {
                PageStep.Number = _pagedListMode.PageCount;
                LoadDataMode();
            }
        }

        private void BtnFirstPageSteps_Click(object sender, EventArgs e)
        {
            if (_pagedListStep.HasPrevious)
            {
                PageStep.Number = 1;
                LoadDataStep();
            }
        }

        private void BtnBackPageSteps_Click(object sender, EventArgs e)
        {
            if (_pagedListStep.HasPrevious)
            {
                PageStep.Number--;
                LoadDataStep();
            }
        }

        private void BtnNextPageSteps_Click(object sender, EventArgs e)
        {
            if (_pagedListStep.HasNext)
            {
                PageStep.Number++;
                LoadDataStep();
            }
        }

        private void BtnLastPageSteps_Click(object sender, EventArgs e)
        {
            if (_pagedListStep.HasNext)
            {
                PageStep.Number = _pagedListStep.PageCount;
                LoadDataStep();
            }
        }

        private bool IsNotFirstPageModesEmpty() => _pagedListMode.Count == 0 && PageMode.Number != 1;

        private bool IsNotFirstPageStepsEmpty() => _pagedListStep.Count == 0 && PageStep.Number != 1;
    }
}
