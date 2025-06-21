using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TestTask.Core.DBContext;
using TestTask.Core.Exeption;

namespace TestTask.Core.Models.Categories
{
    public class CategoryRepository(AppDbContext appDbContext) : IRepository<Category>
    {
        public void Add(Category item)
        {
            BusinessLogicException.ThrowIfNull(item);

            if (appDbContext.Category.Any(e => e.Id == item.Id))
            {
                throw NotFoundException.NotFoundIdProperty<Category>(item.Id);
            }

            appDbContext.Category.Add(item);
            appDbContext.SaveChanges();
        }

        public void Updata(Category item)
        {
            BusinessLogicException.ThrowIfNull(item);

            var oldItem = appDbContext.Category.FirstOrDefault(e => e.Id == item.Id)
                            ?? throw NotFoundException.NotFoundIdProperty<Category>(item.Id);
            oldItem.Name = item.Name;
            appDbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var category = appDbContext.Category.FirstOrDefault(e => e.Id == id)
                            ?? throw NotFoundException.NotFoundIdProperty<Category>(id);

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
            ?? throw NotFoundException.NotFoundIdProperty<Category>(id);

        public string GetName(int id)
            => appDbContext.Category.AsNoTracking().FirstOrDefault(e => e.Id == id).Name
            ?? throw NotFoundException.NotFoundIdProperty<Category>(id);

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
