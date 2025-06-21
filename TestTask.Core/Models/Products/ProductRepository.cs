using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestTask.Core.DBContext;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Types;

namespace TestTask.Core.Models.Products
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(Product item)
        {
            BusinessLogicException.ThrowIfNull(item);

            if (_dbContext.Product.Any(e => e.Id == item.Id))
            {
                BusinessLogicException.ThrowUniqueIDPropertyError<Product>(item);
            }

            InvalidDBForItemProduct(item);

            _dbContext.Product.Add(item);
            _dbContext.SaveChanges();
        }

        public void Updata(Product item)
        {
            BusinessLogicException.ThrowIfNull(item);

            var oldItem = _dbContext.Product.FirstOrDefault(e => e.Id == item.Id)
                            ?? throw NotFoundException.NotFoundIdProperty<Product>(item.Id);

            InvalidDBForItemProduct(item);

            oldItem.Name = item.Name;
            oldItem.CompanyId = item.CompanyId;
            oldItem.CategoryId = item.CategoryId;
            oldItem.TypeId = item.TypeId;
            oldItem.Price = item.Price;
            oldItem.Destination = item.Destination;

            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var item = _dbContext.Product.FirstOrDefault(e => e.Id == id)
                        ?? throw NotFoundException.NotFoundIdProperty<Product>(id);
            _dbContext.Product.Remove(item);
            _dbContext.SaveChanges();
        }

        public void AddRange(List<Product> products)
        {
            foreach (var item in products)
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

        public void Upsert(Product item)
        {
            if (_dbContext.Company.FirstOrDefault(e => e.Id == item.CompanyId) == null
                || _dbContext.Category.FirstOrDefault(e => e.Id == item.CategoryId) == null
                || _dbContext.Type.FirstOrDefault(e => e.Id == item.TypeId) == null)
            {
                return;
            }

            var duplicateId = _dbContext.Product.FirstOrDefault(e => e.Id == item.Id);
            if (duplicateId == null)
            {
                Add(item);
            }

            Updata(item);
        }

        public List<Product> GetAll() => _dbContext.Product.Any() ? _dbContext.Product.AsNoTracking().ToList() : null;

        public bool IsFreeName(string name) => _dbContext.Product.FirstOrDefault(e => e.Name == name) == null;

        public bool IsFreeNameItemUpsert(Product item)
        {
            var busyItem = _dbContext.Product.FirstOrDefault(e => e.Name == item.Name);
            return busyItem == null || item.Id == busyItem.Id;
        }

        public Product GetItem(int id)
            => _dbContext.Product.FirstOrDefault(e => e.Id == id)
            ?? throw NotFoundException.NotFoundIdProperty<Product>(id);

        public IQueryable<Product> GetQueryableAll()
            => _dbContext.Product.Include(e => e.Company).Include(e => e.Category).ThenInclude(e => e.Types).AsNoTracking();

        private void InvalidDBForItemProduct(Product item)
        {
            if (!_dbContext.Company.Any(e => e.Id == item.CompanyId))
            {
                throw NotFoundException.NotFoundIdProperty<Company>(item.CompanyId);
            }

            if (!_dbContext.Category.Any(e => e.Id == item.CategoryId))
            {
                throw NotFoundException.NotFoundIdProperty<Category>(item.CategoryId);
            }

            if (!_dbContext.Type.Any(e => e.Id == item.TypeId))
            {
                throw NotFoundException.NotFoundIdProperty<ProductType>(item.TypeId);
            }
        }
    }
}
