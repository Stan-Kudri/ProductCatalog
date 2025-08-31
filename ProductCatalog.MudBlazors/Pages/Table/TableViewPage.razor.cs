using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using ProductCatalog.Core;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Models;
using ProductCatalog.Core.Models.Page;
using ProductCatalog.Core.Models.SortModel;
using ProductCatalog.MudBlazors.Extension;
using ProductCatalog.MudBlazors.Model;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Pages.Table
{
    public partial class TableViewPage<T, TSortType, TItemDialog>
        where TSortType : SmartEnum<TSortType>
        where T : Entity
        where TItemDialog : ComponentBase, IItemDialog
    {
        [Inject] private ISnackbar Snackbar { get; set; } = null!;
        [Inject] private ExcelImporter<T> ExcelImport { get; set; } = null!;
        [Inject] private IMessageBox MessageDialog { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private ITableDetailProvider<T> TableProvider { get; set; } = null!;
        [Inject] private ISortEntity<T> SortField { get; set; } = null!;
        [Inject] protected NavigationManager Navigation { get; set; } = null!;

        private const string MessageNotSelectedItem = "No items selected.";
        private const string MessageRemoveItem = "Remove item";
        private const string MessageEditItem = "Upload data";

        private const int NoItemsSelected = 0;

        private IEnumerable<T>? items;
        private HashSet<T> selectedItems = new HashSet<T>();
        private bool isSelectItems = true;

        private string? _searchString = null;
        private readonly PageModel _pageModel = new PageModel();
        private PagedList<T>? _pagedList = null;

        private bool IsAscending { get; set; } = true;

        protected override void OnInitialized() => LoadData();

        private async Task SaveDialogItem(Guid? id = null)
        {
            var parameters = new DialogParameters<TItemDialog> { { x => x.Id, id } };
            var options = new DialogOptions { CloseOnEscapeKey = true, FullWidth = true };
            var title = id == null ? "Add Item" : "Edit Item";

            var dialog = await DialogService.ShowAsync<TItemDialog>(title, parameters, options);
            var result = await dialog.Result;

            if (!result.Canceled)
            {
                Snackbar.Add(title, Severity.Success);
                LoadData();
            }
        }

        private void OnSelectItems(HashSet<T> items)
        {
            selectedItems = items;
            isSelectItems = selectedItems.Count <= 0;
        }

        private async Task Remove()
        {
            if (selectedItems.Count <= NoItemsSelected)
            {
                await MessageDialog.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!await MessageDialog.ShowQuestion("Delete selecte items?"))
            {
                return;
            }

            foreach (var item in selectedItems)
            {
                await TableProvider.Remove(item.Id);
            }

            LoadData();
            Snackbar.Add(MessageRemoveItem, Severity.Success);
        }

        private async Task Remove(Guid id)
        {
            if (!await MessageDialog.ShowQuestion("Delete items?"))
            {
                return;
            }

            await TableProvider.Remove(id);
            LoadData();
            Snackbar.Add(MessageRemoveItem, Severity.Success);
        }

        private void ClearFilter()
        {
            IsAscending = true;
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
            await fileload.OpenReadStream().ReadExactlyAsync(buffer);

            var companyRead = ExcelImport.Import(buffer);
            foreach (var row in companyRead)
            {
                if (row.Success)
                {
                    await TableProvider.Upsert(row.Value);
                }
            }

            LoadData();
            Snackbar.Add(MessageEditItem, Severity.Success);
        }

        public void OnToggledChanged(bool toggled)
        {
            IsAscending = toggled;
            LoadData();
        }

        private void OnSearch(string text)
        {
            _searchString = text;
            LoadData();
        }

        private void PageChanged(int i)
        {
            _pageModel.Number = i;
            LoadData();
        }

        private void LoadData()
        {
            IQueryable<T> queriable = TableProvider.GetQueryableAll();
            queriable = TableProvider.GetSearchName(queriable, _searchString);
            queriable = SortField.Apply(queriable, IsAscending);
            _pagedList = queriable.GetPagedList(_pageModel);
            items = _pagedList.Items;
            StateHasChanged();
        }
    }
}
