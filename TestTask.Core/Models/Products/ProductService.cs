using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask.Core.Models.Products
{
    public class ProductService : IService<Product>
    {
        private readonly AppDbContext _dbContext;

        public ProductService(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentException("The received parameters are not correct.", nameof(item));
            }

            if (_dbContext.Product.Any(e => e.Id == item.Id))
            {
                throw new ArgumentException("This product exists.");
            }


            InvalidDBForItemProduct(item);

            _dbContext.Product.Add(item);
            _dbContext.SaveChanges();
        }

        public void Updata(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(item));
            }

            InvalidDBForItemProduct(item);

            var oldItem = _dbContext.Product.FirstOrDefault(e => e.Id == item.Id) ?? throw new InvalidOperationException("Interaction element not found.");

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
            var item = _dbContext.Product.FirstOrDefault(e => e.Id == id) ?? throw new InvalidOperationException("Interaction element not found.");
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

        public void RemoveProductRelatedToCompany(int companyId)
        {
            var product = _dbContext.Product.Where(e => e.CompanyId == companyId).Select(e => e);

            if (product.Count() <= 0)
            {
                return;
            }

            _dbContext.Product.RemoveRange(product.ToList());
        }

        public void RemoveProductRelatedToCategory(int categoryId)
        {
            var product = _dbContext.Product.Where(e => e.CategoryId == categoryId).Select(e => e);

            if (product.Count() <= 0)
            {
                return;
            }

            _dbContext.Product.RemoveRange(product.ToList());
        }

        public void RemoveProductRelatedToType(int typeId)
        {
            var product = _dbContext.Product.Where(e => e.TypeId == typeId).Select(e => e);

            if (product.Count() <= 0)
            {
                return;
            }

            _dbContext.Product.RemoveRange(product.ToList());
        }

        public void Upsert(Product item)
        {
            if (_dbContext.Company.FirstOrDefault(e => e.Id == item.CompanyId) == null ||
                _dbContext.Category.FirstOrDefault(e => e.Id == item.CategoryId) == null ||
                _dbContext.Type.FirstOrDefault(e => e.Id == item.TypeId) == null)
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

        public List<Product> GetAll() => _dbContext.Product.Count() > 0 ? _dbContext.Product.ToList() : null;

        public IQueryable<Product> GetQueryableAll()
            => _dbContext.Product.Include(e => e.Company).Include(e => e.Category).ThenInclude(e => e.Types).Select(e => e);

        private void InvalidDBForItemProduct(Product item)
        {
            if (!_dbContext.Company.Any(e => e.Id == item.CompanyId))
            {
                throw new Exception("Company ID does not exist.");
            }

            if (!_dbContext.Category.Any(e => e.Id == item.CategoryId))
            {
                throw new Exception("Category ID does not exist.");
            }

            if (!_dbContext.Type.Any(e => e.Id == item.TypeId))
            {
                throw new Exception("Type ID does not exist.");
            }
        }
    }
}
