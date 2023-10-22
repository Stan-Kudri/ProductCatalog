using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.ChildForms.ModeForm;
using TestTask.ChildForms.StepForm;
using TestTask.Core.Components;
using TestTask.Core.Components.ItemsTables;
using TestTask.Core.Service;
using TestTask.Core.Service.Components;
using TestTask.Extension;
using SelectMode = TestTask.BindingItem.UserBinding.StepBinding.SelectMode;

namespace TestTask.ChildForms
{
    public partial class TableForm : Form
    {
        private const string MessageNotSelectedItem = "No items selected";

        //Index column from all tables
        private const int IndexId = 0;

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

        private SelectMode _selectMode;

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

            UpdateSelectMode();
            LoadDataGridMode();
        }

        private void BtnAddItemStep_Click(object sender, EventArgs e)
        {
            if (_selectMode.Items == null || _selectMode.Items.Count == 0)
            {
                _messageBox.ShowWarning("Add a mode to the table to add a step.");
                return;
            }

            using (var addFormStep = new AddStepForm(_messageBox, _selectMode))
            {
                if (addFormStep.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var step = addFormStep.GetModeModel().ToStep();
                _stepService.Add(step);
            }

            LoadDataGridStep();
        }

        private void BtnDeliteMode_Click(object sender, EventArgs e)
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
            }

            LoadDataGridMode();
        }

        private void BtnDeliteStep_Click(object sender, EventArgs e)
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

        private void BtnEditMode_Click(object sender, EventArgs e)
        {
            var indexEditRow = GetSelectedRowIndexesGridMode();

            if (indexEditRow.Count == 1)
            {
                var oldItem = GetMode(indexEditRow.First());
                var editModeForm = new EditItemModeForm(_messageBox, oldItem);

                if (editModeForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var updateItem = editModeForm.GetEditMode();
                _modeService.Update(updateItem);
                LoadDataGridMode();
            }
            else
            {
                _messageBox.ShowWarning("Select one item.");
            }

        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            UpdateSelectMode();
            LoadDataGridMode();
            LoadDataGridStep();
        }

        private void UpdateSelectMode() => _selectMode = new SelectMode(_modeService.GetAllMode());

        private void LoadDataGridMode()
        {
            var item = _modeService.GetAllMode();

            if (item != null)
            {
                ClearGridMode();
                FillGridMode(item);
            }
        }

        private void LoadDataGridStep()
        {
            var items = _stepService.GetAllItems();

            if (items != null)
            {
                ClearGridStep();
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

        private HashSet<int> GetSelectedRowIndexesGridMode()
        {
            var result = new HashSet<int>();

            foreach (DataGridViewRow dgvModeSelectedRow in dgvModes.SelectedRows)
            {
                result.Add(dgvModeSelectedRow.Index);
            }

            foreach (DataGridViewCell dgvModeSelectedCell in dgvModes.SelectedCells)
            {
                result.Add(dgvModeSelectedCell.RowIndex);
            }

            return result;
        }

        private HashSet<int> GetSelectedRowIndexesGridStep()
        {
            var result = new HashSet<int>();

            foreach (DataGridViewRow dgvStepSelectedRow in dgvSteps.SelectedRows)
            {
                result.Add(dgvStepSelectedRow.Index);
            }

            foreach (DataGridViewCell dgvStepSelectedCell in dgvSteps.SelectedCells)
            {
                result.Add(dgvStepSelectedCell.RowIndex);
            }

            return result;
        }

        private void RemoveItemRowGridMode(int id)
        {
            foreach (DataGridViewRow row in dgvModes.Rows)
            {
                var idItem = row.Get<int>(IndexId);
                if (idItem != null && idItem == id)
                {
                    dgvModes.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        private void RemoveItemRowGridSteps(int id)
        {
            foreach (DataGridViewRow row in dgvSteps.Rows)
            {
                var idItem = row.Get<int>(IndexId);
                if (idItem != null && idItem == id)
                {
                    dgvSteps.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }
    }
}
