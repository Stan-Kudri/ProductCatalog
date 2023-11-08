using System;
using System.Collections.Generic;
using System.Linq;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Models.Companies
{
    public class CategoryService : IService<Category>
    {
        private readonly AppDbContext _dbContext;

        public CategoryService(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(Category item)
        {
            if (item == null)
            {
                throw new ArgumentException("The received parameters are not correct.", nameof(item));
            }

            if (_dbContext.Category.Any(e => e.Id == item.Id))
            {
                throw new ArgumentException("This company exists.");
            }

            _dbContext.Category.Add(item);
            _dbContext.SaveChanges();
        }

        public void Update(Category item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(item));
            }

            var oldItem = _dbContext.Category.FirstOrDefault(e => e.Id == item.Id) ?? throw new InvalidOperationException("Interaction element not found.");
            oldItem.Name = item.Name;
            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var category = _dbContext.Category.FirstOrDefault(e => e.Id == id) ?? throw new InvalidOperationException("Interaction element not found.");
            _dbContext.Category.Remove(category);
            _dbContext.SaveChanges();
        }

        public void AddImportData(Category item)
        {
            var duplicateId = _dbContext.Category.FirstOrDefault(e => e.Id == item.Id);
            if (duplicateId == null)
            {
                Add(item);
            }

            Update(item);
        }

        public string GetName(int id)
            => _dbContext.Category.FirstOrDefault(e => e.Id == id).Name ?? throw new ArgumentException("Interaction element not found.");

        public List<Category> GetAll() => _dbContext.Category.Count() > 0 ? _dbContext.Category.ToList() : null;

        public IQueryable<Category> GetQueryableAll() => _dbContext.Category;

        public bool IsFreeName(string name) => _dbContext.Category.FirstOrDefault(e => e.Name == name) == null;
    }
}
