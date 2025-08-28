using Microsoft.AspNetCore.Components;
using ProductCatalog.Core.Models.Page;
using ProductCatalog.Core.Models.Users;
using ProductCatalog.MudBlazors.Extension;
using ProductCatalog.MudBlazors.Model;

namespace ProductCatalog.MudBlazors.Pages.Table
{
    public partial class TableUsers
    {
        [Inject] UserService UserService { get; set; } = null!;

        private IEnumerable<User>? items;

        private readonly PageModel _pageModel = new PageModel();

        protected override void OnInitialized() => LoadData();

        private void LoadData()
        {
            IQueryable<User> queriable = UserService.GetQueryableAll();
            PagedList<User> result = queriable.GetPagedList(_pageModel);
            items = result.Items;
            StateHasChanged();
        }
    }
}
