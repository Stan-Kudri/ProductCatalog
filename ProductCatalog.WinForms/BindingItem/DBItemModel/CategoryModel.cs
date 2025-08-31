using System;
using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.WinForms.BindingItem.DBItemModel
{
    public class CategoryModel(string name) : ModelBase
    {
        public string Name
        {
            get => name;
            set => SetField(ref name, value);
        }

        public Category ToCategory() => new(name);

        public Category ToCategory(Guid id) => new(name, id);
    }
}
