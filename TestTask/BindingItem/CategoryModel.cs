using TestTask.Core.Models.Categories;

namespace TestTask.BindingItem
{
    public class CategoryModel : ModelBase
    {
        private string _name;

        public CategoryModel(string name)
        {
            _name = name;
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public Category ToCategory() => new Category(_name);

        public Category ToCategory(int id) => new Category(_name);
    }
}
