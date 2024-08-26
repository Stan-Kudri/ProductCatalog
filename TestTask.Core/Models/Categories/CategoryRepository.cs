using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask.Core.Models.Categories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly AppDbContext _dbContext;

        public CategoryRepository(AppDbContext appDbContext) => _dbContext = appDbContext;

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

        public void Updata(Category item)
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

        public void Upsert(Category item)
        {
            var duplicateId = _dbContext.Category.FirstOrDefault(e => e.Id == item.Id);
            if (duplicateId == null)
            {
                Add(item);
            }

            Updata(item);
        }

        public void AddRange(List<Category> categories)
        {
            foreach (var item in categories)
            {
                Add(item);
            }
        }

        public void RemoveRange(List<int> listId)
        {
            foreach (var id in listId)
            {
                Remove(id);
            }
        }

        public Category GetCategory(int id)
            => _dbContext.Category.FirstOrDefault(e => e.Id == id) ?? throw new ArgumentException("Interaction element not found.");

        public string GetName(int id)
            => _dbContext.Category.FirstOrDefault(e => e.Id == id).Name ?? throw new ArgumentException("Interaction element not found.");

        public List<Category> GetAll() => _dbContext.Category.Count() > 0 ? _dbContext.Category.ToList() : null;

        public IQueryable<Category> GetQueryableAll() => _dbContext.Category;

        public bool IsFreeName(string name) => _dbContext.Category.FirstOrDefault(e => e.Name == name) == null;

        public bool IsFreeNameItemUpsert(Category item)
        {
            var busyItem = _dbContext.Category.FirstOrDefault(e => e.Name == item.Name);
            return busyItem == null || item.Id == busyItem.Id;
        }
    }
}
