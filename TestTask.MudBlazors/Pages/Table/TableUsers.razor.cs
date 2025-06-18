using Microsoft.AspNetCore.Components;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table
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
