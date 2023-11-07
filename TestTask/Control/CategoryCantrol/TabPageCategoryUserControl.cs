using System;
using System.Collections.Generic;
using TestTask.BindingItem.Pages;

namespace TestTask.Control.CategoryCantrol
{
    public partial class TabPageCategoryUserControl : BaseUserControl
    {
        private Dictionary<int, string> mapSortCategory = new Dictionary<int, string>() { { 0, "Ascending" }, { 1, "Descending" }, };

        public TabPageCategoryUserControl()
            : base()
        {
            InitializeComponent();
        }

        public SortPageCategory SortPage = new SortPageCategory();

        public void Initialize(IServiceProvider serviceProvider)
        {
            listViewCategoryControl.Initialize(serviceProvider);
            cmbSortName.DataSource = SortPage.Items;
        }

        private void CmbSortName_Changed(object sender, EventArgs e)
        {
            listViewCategoryControl._categoryService.SortCategory = SortPage.ToSortCategory(SortCMBCategory());
            LoadData();
        }

        public void LoadData() => listViewCategoryControl.LoadData();

        public void Closing() => listViewCategoryControl.Closing();

        private bool SortCMBCategory()
        {
            if (cmbSortName.SelectedItem.ToString() == mapSortCategory[0])
            {
                return true;
            }
            else if (cmbSortName.SelectedItem.ToString() == mapSortCategory[1])
            {
                return false;
            }

            throw new ArgumentException("Uncnown sort category.");
        }
    }
}
