using System;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.Core;
using TestTask.Core.Models;
using TestTask.Core.Models.Page;
using TestTask.Model;

namespace TestTask.Control.CategoryCantrol
{
    public partial class ListViewControl : BaseUserControl
    {
        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IListViewDataProvider _provider;
        private IMessageBox _messageBox;

        private PagedList<Entity> _pagedList;

        private bool Resizing = false;
        private float[] _percentages;

        public ListViewControl()
            : base()
        {
            InitializeComponent();
        }

        public PageModel Page { get; set; } = new PageModel();

        public void Initialize(IListViewDataProvider provider, IMessageBox messageBox)
        {
            _provider = provider;
            _messageBox = messageBox;
            float initialTotalColumnWidth = 0;
            foreach (var column in provider.Columns)
            {
                listView.Columns.Add(new ColumnHeader { Text = column.Name, Width = column.Width });
                initialTotalColumnWidth += column.Width;
            }

            _percentages = provider.Columns.Select(c => c.Width / initialTotalColumnWidth).ToArray();

            cmbPageSize.DataSource = Page.Items;
            Page.ChangeCurrentPage += LoadData;
        }

        public void Closing() => Page.ChangeCurrentPage -= LoadData;


        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (_provider.Add())
            {
                LoadData();
            }
        }

        private void BtnEditItem_Click(object sender, EventArgs e)
        {
            var indexEditItem = listView.SelectedIndices.Cast<int>();

            if (indexEditItem.Count() != 1)
            {
                _messageBox.ShowWarning("Select one item.");
                return;
            }

            var row = indexEditItem.First();
            var rowItem = listView.Items[row];
            var entity = _provider.GetEntity(rowItem);
            if (_provider.Edit(entity))
            {
                LoadData();
            }
        }

        private void BtnDeleteItems_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = listView.SelectedIndices;

            if (selectedRowIndex.Count == NoItemsSelected)
            {
                _messageBox.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!_messageBox.ShowQuestion("Delete selected items?"))
            {
                foreach (ListViewItem item in listView.Items)
                {
                    item.Selected = false;
                }
                return;
            }

            for (var i = 0; i < listView.Items.Count; i++)
            {
                var item = listView.Items[i];
                if (!item.Selected)
                {
                    continue;
                }

                var entity = _provider.GetEntity(item);
                _provider.Remove(entity);
            }

            LoadData();
        }

        protected void BtnFirstPage_Click(object sender, EventArgs e)
        {
            if (_pagedList.HasPrevious)
            {
                Page.Number = 1;
            }
        }

        protected void BtnBackPage_Click(object sender, EventArgs e)
        {
            if (_pagedList.HasPrevious)
            {
                Page.Number--;
            }
        }

        protected void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (_pagedList.HasNext)
            {
                Page.Number++;
            }
        }

        protected void BtnLastPage_Click(object sender, EventArgs e)
        {
            if (_pagedList.HasNext)
            {
                Page.Number = _pagedList.PageCount;
            }
        }

        protected void TbCurrentPage_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbCurrentPage.Text, out var pageNumber)
                && pageNumber <= _pagedList.PageCount
                && _pagedList.PageNumber == Page.Number)
            {
                Page.Number = pageNumber;
            }

            tbCurrentPage.Text = string.Format("{0}/{1}", Page.Number, _pagedList.PageCount);
        }

        protected void CmbPageSize_Changed(object sender, EventArgs e)
        {
            var pageSizeCmb = Page.Items[cmbPageSize.SelectedIndex];

            if (Page.ChangedPage(pageSizeCmb))
            {
                Page.Size = pageSizeCmb;
                Page.Number = 1;
            }
        }

        private void ListView_SizeChanged(object sender, EventArgs e) => ChangeSizeColumnListView();

        public void ChangeSizeColumnListView()
        {
            if (Resizing)
            {
                return;
            }

            Resizing = true;

            //Column Tage = Width custom size
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width = (int)(_percentages[i] * listView.ClientRectangle.Width);
            }

            Resizing = false;
        }

        public void LoadData()
        {
            _pagedList = _provider.GetPage(Page.GetPage());
            if (IsNotFirstPageEmpty())
            {
                Page.Number -= 1;
            }

            listView.Items.Clear();
            foreach (var item in _pagedList.Items)
            {
                var values = _provider.Columns
                    .Select(cl => cl.ValueSelector(item).ToString())
                    .ToArray();
                listView.Items.Add(new ListViewItem(values));
            }
            UpdateButtons();

            tbCurrentPage.Text = _pagedList.PageNumber.ToString();
        }

        private void UpdateButtons()
        {
            btnFirstPage.Enabled = btnFirstPage.Visible =
                btnLastPage.Enabled = btnLastPage.Visible =
                    btnNextPage.Enabled = btnNextPage.Visible =
                        btnBackPage.Enabled = btnBackPage.Visible =
                            tbCurrentPage.Enabled = tbCurrentPage.Visible =
                                    _pagedList.PageCount > 0 ? true : false;
        }

        private bool IsNotFirstPageEmpty() => _pagedList.Count == 0 && Page.Number != 1;
    }
}
