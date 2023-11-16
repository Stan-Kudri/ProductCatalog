using System;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Types;

namespace TestTask.BindingItem
{
    public class ProductTypeModel : ModelBase
    {
        private string _name = string.Empty;
        private Category _category = null;

        public ProductTypeModel(string name, Category category)
        {
            Category = category ?? throw new ArgumentException("The category cannot be null.", nameof(category));

            Name = name != string.Empty && name != null ?
                Name = name :
                throw new ArgumentException("The type product cannot be empty.", nameof(name));
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public Category Category
        {
            get => _category;
            set => SetField(ref _category, value);
        }

        public ProductType ToProductType() => new ProductType(_name, _category.Id);

        public ProductType ToProductType(int typeId) => new ProductType(_name, _category.Id, typeId);
    }
}
