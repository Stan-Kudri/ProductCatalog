using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using TestTask.Core.Import;
using TestTask.Core.Models;
using TestTask.Core.Models.Page;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Pages.Table
{
    public partial class TableViewPage<T, TSortType>
        where TSortType : SmartEnum<TSortType>
        where T : Entity
    {
        [Inject] private ExcelImporter<T> ExcelImport { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private ITableDetailProvider<T> TableProvider { get; set; } = null!;
        [Inject] private ISortEntity<T, TSortType> SortField { get; set; } = null!;
        [Inject] protected NavigationManager Navigation { get; set; } = null!;

        [Parameter] public required IDataProcessor DataProcessor { get; set; }

        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<T>? items;
        private HashSet<T> selectedItems = new HashSet<T>();
        private bool isSelectItems = true;

        private string? searchString = null;
        private PageModel pageModel = new PageModel();

        private bool isAscending { get; set; } = true;

        protected override void OnInitialized() => LoadData();

        private void OnSelectItems(HashSet<T> items)
        {
            selectedItems = items;
            isSelectItems = selectedItems.Count <= 0;
        }

        private async Task Remove()
        {
            if (selectedItems.Count <= NoItemsSelected)
            {
                ShowMessageWarning(MessageNotSelectedItem);
                return;
            }

            bool? result = await DialogService.ShowMessageBox(
                "Warning",
                "Delete selecte items?",
                yesText: "Yes", cancelText: "No");

            if (result != true)
            {
                return;
            }

            foreach (var item in selectedItems)
            {
                TableProvider.Remove(item.Id);
            }

            LoadData();
        }

        private void Update(int id) => DataProcessor.EditItemPage(id);

        private async Task Remove(int id)
        {
            bool? result = await DialogService.ShowMessageBox(
               "Warning",
               "Delete selecte items?",
               yesText: "Yes", cancelText: "No");

            if (result != true)
            {
                return;
            }

            TableProvider.Remove(id);
            LoadData();
        }

        private void ClearFilter()
        {
            isAscending = true;
            SortField.Clear();
            LoadData();
        }

        private async Task UploadFiles(IBrowserFile fileload)
        {
            if (fileload.Size == decimal.Zero)
            {
                return;
            }

            var buffer = new byte[fileload.Size];
            await fileload.OpenReadStream().ReadAsync(buffer);

            var companyRead = ExcelImport.Import(buffer);
            foreach (var row in companyRead)
            {
                if (row.Success)
                {
                    TableProvider.Upsert(row.Value);
                }
            }
            LoadData();
        }

        public void OnToggledChanged(bool toggled)
        {
            isAscending = toggled;
            LoadData();
        }

        private void OnSearch(string text)
        {
            searchString = text;
            LoadData();
        }

        private void LoadData()
        {
            IQueryable<T> queriable = TableProvider.GetQueryableAll();
            queriable = TableProvider.GetSearchName(queriable, searchString);
            queriable = SortField.Apply(queriable, isAscending);
            PagedList<T> result = queriable.GetPagedList(pageModel);
            items = result.Items;
            StateHasChanged();
        }

        private async Task ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");
    }

    public interface IDataProcessor
    {
        void AddItemPage();

        void EditItemPage(int id);
    }
}
