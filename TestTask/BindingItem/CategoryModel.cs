using TestTask.Core.Models.Categories;

namespace TestTask.BindingItem
{
    public class CategoryModel(string name) : ModelBase
    {
        public string Name
        {
            get => name;
            set => SetField(ref name, value);
        }

        public Category ToCategory() => new(name);

        public Category ToCategory(int id) => new(name, id);
    }
}
