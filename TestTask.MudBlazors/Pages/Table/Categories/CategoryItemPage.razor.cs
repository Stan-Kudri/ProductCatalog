using Microsoft.AspNetCore.Components;
using TestTask.Core.Models.Categories;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.Categories
{
    public partial class CategoryItemPage
    {
        [Inject] CategoryService? CategoryService { get; set; }
        [Inject] NavigationManager? Navigation { get; set; }

        private CategoryModel categoryModel { get; set; } = new CategoryModel();
        private string[] errors = { };
        private bool IsAddItem = true;

        private Category oldItem;

        [Parameter] public int? idCategory { get; set; } = null;

        protected override void OnInitialized()
        {
            if (idCategory == null)
            {
                IsAddItem = true;
                return;
            }

            if (idCategory <= 0)
            {
                NavigationInCompanyTable();
            }

            IsAddItem = false;
            oldItem = CategoryService.GetCategory((int)idCategory);
            categoryModel = oldItem.GetCategoryModel();
        }

        private void Close() => NavigationInCompanyTable();

        //Methods for add item company
        private void Add()
        {
            if (errors.Length != 0)
            {
                return;
            }

            if (!CategoryService.IsFreeName(categoryModel.Name))
            {
                return;
            }

            var item = categoryModel.GetCategory();
            CategoryService.Add(item);
            NavigationInCompanyTable();
        }

        private void ClearData() => categoryModel.ClearData();

        //Methods for edit item company
        private void Updata()
        {
            if (errors.Length != 0)
            {
                return;
            }

            var item = categoryModel.GetModifyCategory(oldItem.Id);

            if (!oldItem.Equals(item))
            {
                CategoryService.Updata(item);
            }

            NavigationInCompanyTable();
        }

        private void NavigationInCompanyTable() => Navigation.NavigateTo("/category");

        private void RecoverPastData() => categoryModel = oldItem.GetCategoryModel();

        private IEnumerable<string> ValidFormatText(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                yield return "Field is required.";
            }
        }
    }
}
