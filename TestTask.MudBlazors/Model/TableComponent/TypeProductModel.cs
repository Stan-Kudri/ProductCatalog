using Microsoft.AspNetCore.Components;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Types;

namespace TestTask.MudBlazors.Model.TableComponent
{
    public class TypeProductModel
    {
        private string _name = string.Empty;
        private Category? _category = null;

        public TypeProductModel()
        {
        }

        public TypeProductModel(string name, Category category)
        {
            Name = name;
            Category = category;
        }

        [Parameter]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        [Parameter]
        public Category? Category
        {
            get => _category;
            set => _category = value;
        }

        public ProductType GetProductType() => new ProductType(Name, Category.Id);

        public ProductType GetModifyType(int idOldItem) => new ProductType(Name, Category.Id, idOldItem);

        public void ClearData()
        {
            Name = string.Empty;
            Category = null;
        }
    }
}
