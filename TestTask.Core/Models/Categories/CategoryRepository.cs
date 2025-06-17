using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TestTask.Core.DBContext;

namespace TestTask.Core.Models.Categories
{
    public class CategoryRepository(AppDbContext appDbContext) : IRepository<Category>
    {
        public void Add(Category item)
        {
            if (item == null)
            {
                throw new ArgumentException("The received parameters are not correct.", nameof(item));
            }

            if (appDbContext.Category.Any(e => e.Id == item.Id))
            {
                throw new ArgumentException("This company exists.");
            }

            appDbContext.Category.Add(item);
            appDbContext.SaveChanges();
        }

        public void Updata(Category item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "The format of the transmitted data is incorrect.");
            }

            var oldItem = appDbContext.Category.FirstOrDefault(e => e.Id == item.Id) ?? throw new InvalidOperationException("Interaction element not found.");
            oldItem.Name = item.Name;
            appDbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var category = appDbContext.Category.FirstOrDefault(e => e.Id == id)
                            ?? throw new InvalidOperationException("Interaction element not found.");

            appDbContext.Category.Remove(category);
            appDbContext.SaveChanges();
        }

        public void Upsert(Category item)
        {
            var duplicateId = appDbContext.Category.FirstOrDefault(e => e.Id == item.Id);

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
            => appDbContext.Category.FirstOrDefault(e => e.Id == id)
            ?? throw new ArgumentException("Interaction element not found.");

        public string GetName(int id)
            => appDbContext.Category.FirstOrDefault(e => e.Id == id).Name
            ?? throw new ArgumentException("Interaction element not found.");

        public List<Category> GetAll()
            => appDbContext.Category.Any() ? [.. appDbContext.Category.AsNoTracking()] : null;

        public IQueryable<Category> GetQueryableAll() => appDbContext.Category.AsNoTracking();

        public bool IsFreeName(string name)
            => appDbContext.Category.FirstOrDefault(e => e.Name == name) == null;

        public bool IsFreeNameItemUpsert(Category item)
        {
            var busyItem = appDbContext.Category.FirstOrDefault(e => e.Name == item.Name);
            return busyItem == null || item.Id == busyItem.Id;
        }
    }
}
