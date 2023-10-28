using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.ChildForms.Import;
using TestTask.ChildForms.ModeForm;
using TestTask.ChildForms.StepForm;
using TestTask.Core.Components;
using TestTask.Core.Components.ItemsTables;
using TestTask.Core.ExportDB;
using TestTask.Core.ExportDB.SheetFillers;
using TestTask.Core.Extension;
using TestTask.Core.ImportDB.Read.Header;
using TestTask.Core.Service;
using TestTask.Core.Service.Components;
using TestTask.Extension;

namespace TestTask.ChildForms
{
    public partial class TableForm : Form
    {
        private const string Mode = "Mode";
        private const string Step = "Step";

        private const string MessageNotSelectedItem = "No items selected";

        //Index column from all tables
        public const int IndexId = 0;

        //Index column Mode table
        private const int IndexColumnModeName = 1;
        private const int IndexColumnMaxBottle = 2;
        private const int IndexColumnMaxUsedTips = 3;

        //Index column Mode table
        private const int IndexColumnModeId = 1;
        private const int IndexColumnTimer = 2;
        private const int IndexColumnDestination = 3;
        private const int IndexColumnSpeed = 4;
        private const int IndexColumnType = 5;
        private const int IndexColumnVolume = 6;

        private readonly ModeService _modeService;
        private readonly StepService _stepService;
        private readonly IMessageBox _messageBox;

        public TableForm(ModeService modeService, StepService stepService, IMessageBox messageBox)
        {
            InitializeComponent();
            _modeService = modeService;
            _stepService = stepService;
            _messageBox = messageBox;
        }


        private void BtnAddMode_Click(object sender, EventArgs e)
        {
            using (var addFormMode = new AddItemModeForm(_messageBox))
            {
                if (addFormMode.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var mode = addFormMode.GetModeModel().ToMode();
                _modeService.Add(mode);
            }

            LoadDataGridMode();
        }

        private void BtnEditMode_Click(object sender, EventArgs e)
        {
            var indexEditRow = GetSelectedRowIndexesGridMode();

            if (indexEditRow.Count == 1)
            {
                var oldItem = GetMode(indexEditRow.First());

                using (var editModeForm = new EditItemModeForm(_messageBox, oldItem))
                {
                    if (editModeForm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    var updateItem = editModeForm.GetEditMode();
                    _modeService.Update(updateItem);

                    if (editModeForm.ChangedModeName())
                    {
                        LoadDataGridStep();
                    }
                }

                LoadDataGridMode();
            }
            else
            {
                _messageBox.ShowWarning("Select one item.");
            }
        }

        private void BtnDeleteMode_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = GetSelectedRowIndexesGridMode()
                .Select(i => dgvModes.Rows[i].Get<int>(IndexId))
                .ToList();

            if (selectedRowIndex.Count == 0)
            {
                _messageBox.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!_messageBox.ShowQuestion("Delete selected items?"))
            {
                return;
            }

            foreach (var id in selectedRowIndex)
            {
                RemoveItemRowGridMode(id);
                _modeService.Remove(id);
                _stepService.RemoveStepRelatedToMode(id);
            }

            UpdateAllGrids();
        }

        private void BtnAddStep_Click(object sender, EventArgs e)
        {
            var listMode = _modeService.GetAll();

            if (listMode == null || listMode.Count == 0)
            {
                _messageBox.ShowWarning("Add a mode to the table to add a step.");
                return;
            }

            using (var addFormStep = new AddItemStepForm(_messageBox, listMode))
            {
                if (addFormStep.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var step = addFormStep.GetStepModel().ToStep();
                _stepService.Add(step);
            }

            LoadDataGridStep();
        }

        private void BtnEditStep_Click(object sender, EventArgs e)
        {
            var listMode = _modeService.GetAll();
            var indexEditRow = GetSelectedRowIndexesGridStep();

            if (indexEditRow.Count == 1)
            {
                var oldItem = GetStep(indexEditRow.First());

                using (var editStepForm = new EditItemStepForm(_messageBox, listMode, oldItem))
                {
                    if (editStepForm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    var updateItem = editStepForm.GetEditStep();
                    _stepService.Update(updateItem);
                }

                LoadDataGridStep();
            }
            else
            {
                _messageBox.ShowWarning("Select one item.");
            }
        }

        private void BtnDeleteStep_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = GetSelectedRowIndexesGridStep()
                .Select(i => dgvSteps.Rows[i].Get<int>(IndexId))
                .ToList();

            if (selectedRowIndex.Count == 0)
            {
                _messageBox.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!_messageBox.ShowQuestion("Delete selected items?"))
            {
                return;
            }

            foreach (var id in selectedRowIndex)
            {
                RemoveItemRowGridSteps(id);
                _stepService.Remove(id);
            }

            LoadDataGridStep();
        }

        private void TsmImportFromExcel_Click(object sender, EventArgs e)
        {
            var loadTable = new Dictionary<string, bool>()
            {
                { Mode, false },
                { Step, false },
            };

            using (var impotDbForExcel = new ImportDatabaseForm(_messageBox))
            {
                if (impotDbForExcel.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                loadTable[Mode] = impotDbForExcel.IsDownloadTableMode;
                loadTable[Step] = impotDbForExcel.IsDownloadTableStep;
            }

            using (var openReplaceDataFromFile = new OpenFileDialog { Filter = "Excel Files |*.xls;*.xlsx;*.xlsm" })
            {
                if (openReplaceDataFromFile.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                var path = openReplaceDataFromFile.FileName;

                if (loadTable[Mode])
                {
                    var modeRead = new ReadMode().ReadExcel(path);

                    foreach (var item in modeRead)
                    {
                        if (item.Success)
                        {
                            _modeService.AddImportData(item.Value);
                        }
                    }

                    LoadDataGridMode();

                    if (!modeRead.IsNoErrorLine(out var message))
                    {
                        _messageBox.ShowWarning(message);
                    }
                }

                if (loadTable[Step])
                {
                    var stepRead = new ReadStep().ReadExcel(path);

                    foreach (var item in stepRead)
                    {
                        if (item.Success)
                        {
                            _stepService.AddImportData(item.Value);
                        }
                    }

                    LoadDataGridStep();

                    if (!stepRead.IsNoErrorLine(out var message))
                    {
                        _messageBox.ShowWarning(message);
                    }
                }
            }
        }

        private void TsmItemSaveExcel_Click(object sender, EventArgs e)
        {
            ModeSheetFiller modeSheetFiller = new ModeSheetFiller(_modeService);

            var fillers = new ISheetFiller[]
            {
                modeSheetFiller,
            };

            var writeExcel = new ExcelExporter(fillers);
            writeExcel.ExportToFile("ExcelFile.xlsx");
        }

        private void TsmItemClose_Click(object sender, EventArgs e) => Close();

        private void TableForm_Load(object sender, EventArgs e) => UpdateAllGrids();

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e) => DialogResult = DialogResult.Cancel;

        private void LoadDataGridMode()
        {
            var item = _modeService.GetAll();

            ClearGridMode();

            if (item != null)
            {
                FillGridMode(item);
            }
        }

        private void LoadDataGridStep()
        {
            var items = _stepService.GetAllItems();

            ClearGridStep();

            if (items != null)
            {
                FillGridStep(items);
            }
        }

        private Mode GetMode(int indexRow)
        {
            var rowItems = dgvModes.Rows[indexRow];
            var idMode = CellElement(rowItems, IndexId).ParseInt();
            var nameMode = CellElement(rowItems, IndexColumnModeName) ?? throw new ArgumentException("Name cannot be null.");
            var maxBottle = CellElement(rowItems, IndexColumnMaxBottle).ParseInt();
            var maxUsedTips = CellElement(rowItems, IndexColumnMaxUsedTips).ParseInt();

            return new Mode(nameMode, maxBottle, maxUsedTips, idMode);
        }

        private Step GetStep(int indexRow)
        {
            var rowItems = dgvSteps.Rows[indexRow];
            var idStep = CellElement(rowItems, IndexId).ParseInt();
            var timer = CellElement(rowItems, IndexColumnTimer).ParseInt();
            var destination = CellElement(rowItems, IndexColumnDestination);
            var speed = CellElement(rowItems, IndexColumnSpeed).ParseInt();
            var type = CellElement(rowItems, IndexColumnType) ?? throw new ArgumentException("Name cannot be null.");
            var volume = CellElement(rowItems, IndexColumnVolume).ParseInt();
            var modeId = CellElement(rowItems, IndexColumnModeId).ParseInt();

            return new Step(modeId, timer, destination, speed, type, volume, idStep);
        }

        private string CellElement(DataGridViewRow rowItem, int indexColumn) => rowItem.GetString(indexColumn) ?? throw new Exception("String cannot be null.");

        private void ClearGridMode() => dgvModes.Rows.Clear();

        private void ClearGridStep() => dgvSteps.Rows.Clear();

        private void FillGridMode(List<Mode> items)
        {
            foreach (var item in items)
            {
                dgvModes.Rows.Add(item.Id, item.Name, item.MaxBottleNumber, item.MaxUsedTips);
            }
        }

        private void FillGridStep(List<Step> items)
        {
            foreach (var item in items)
            {
                dgvSteps.Rows.Add(item.Id, item.ModeId, item.Timer, item.Destination, item.Speed, item.Type, item.Volume);
            }
        }

        private HashSet<int> GetSelectedRowIndexesGridMode() => dgvModes.GetSelectedRowIndexesGrid();

        private HashSet<int> GetSelectedRowIndexesGridStep() => dgvSteps.GetSelectedRowIndexesGrid();

        private void RemoveItemRowGridMode(int id) => dgvModes.RemoveItemRowGrid(id);

        private void RemoveItemRowGridSteps(int id) => dgvSteps.RemoveItemRowGrid(id);

        private void UpdateAllGrids()
        {
            LoadDataGridMode();
            LoadDataGridStep();
        }
    }
}
