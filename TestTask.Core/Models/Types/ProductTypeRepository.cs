using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestTask.Core.DBContext;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Models.Types
{
    public class ProductTypeRepository : IRepository<ProductType>
    {
        private readonly AppDbContext _dbContext;

        public ProductTypeRepository(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(ProductType item)
        {
            BusinessLogicException.ThrowIfNull(item);

            if (_dbContext.Type.Any(e => e.Id == item.Id))
            {
                BusinessLogicException.ThrowUniqueIDPropertyError<ProductType>(item);
            }

            if (_dbContext.Category.FirstOrDefault(e => e.Id == item.CategoryId) == null)
            {
                throw NotFoundException.NotFoundIdProperty<Category>(item.CategoryId);
            }

            _dbContext.Type.Add(item);
            _dbContext.SaveChanges();
        }

        public void Updata(ProductType item)
        {
            BusinessLogicException.ThrowIfNull(item);

            if (!_dbContext.Category.Any(e => e.Id == item.CategoryId))
            {
                throw new BusinessLogicException("Category ID does not exist.");
            }

            var oldItem = _dbContext.Type.FirstOrDefault(e => e.Id == item.Id)
                            ?? throw NotFoundException.NotFoundIdProperty<ProductType>(item.Id);

            oldItem.Name = item.Name;
            oldItem.CategoryId = item.CategoryId;

            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var item = _dbContext.Type.FirstOrDefault(e => e.Id == id)
                        ?? throw NotFoundException.NotFoundIdProperty<ProductType>(id);

            _dbContext.Type.Remove(item);
            _dbContext.SaveChanges();
        }

        public void AddRange(List<ProductType> types)
        {
            foreach (var item in types)
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

        public void Upsert(ProductType item)
        {
            if (_dbContext.Category.FirstOrDefault(e => e.Id == item.CategoryId) == null)
            {
                return;
            }

            var duplicateId = _dbContext.Type.FirstOrDefault(e => e.Id == item.Id);
            if (duplicateId == null)
            {
                Add(item);
            }

            Updata(item);
        }

        public List<ProductType> GetAll()
            => _dbContext.Type.Any() ? _dbContext.Type.AsNoTracking().ToList() : null;

        public List<ProductType> GetListTypesByCategory(int idCategory)
            => _dbContext.Type.Where(e => e.CategoryId == idCategory).AsNoTracking().ToList();

        public bool IsFreeName(string name)
            => _dbContext.Type.FirstOrDefault(e => e.Name == name) == null;

        public bool IsFreeNameItemUpsert(ProductType item)
        {
            var busyItem = _dbContext.Type.FirstOrDefault(e => e.Name == item.Name);
            return busyItem == null || item.Id == busyItem.Id;
        }

        public ProductType GetItem(int id)
            => _dbContext.Type.FirstOrDefault(e => e.Id == id)
            ?? throw NotFoundException.NotFoundIdProperty<ProductType>(id);

        public IQueryable<ProductType> GetQueryableAll()
            => _dbContext.Type.Include(e => e.Category).Select(e => e);
    }
}
