using System;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.WinForms.BindingItem.DBItemModel
{
    public class ProductTypeModel : ModelBase
    {
        private string _name = string.Empty;
        private Category _category = null;

        public ProductTypeModel(string name, Category category)
        {
            BusinessLogicException.ThrowIfNull(category);
            BusinessLogicException.ThrowIfNullOrEmpty(name);

            Category = category;
            Name = name;
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

        public ProductType ToProductType(Guid typeId) => new ProductType(_name, _category.Id, typeId);
    }
}
