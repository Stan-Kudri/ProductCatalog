using System;
using System.Collections.Generic;
using System.Data.Entity;
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

            if (_dbContext.Company.FirstOrDefault(e => e.Id == item.CompanyId) == null)
            {
                throw new Exception("Company ID does not exist.");
            }

            if (_dbContext.Category.FirstOrDefault(e => e.Id == item.CategoryId) == null)
            {
                throw new Exception("Category ID does not exist.");
            }

            _dbContext.Product.Add(item);
            _dbContext.SaveChanges();
        }

        public void Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(item));
            }

            if (!_dbContext.Company.Any(e => e.Id == item.CompanyId))
            {
                throw new Exception("Company ID does not exist.");
            }

            if (!_dbContext.Category.Any(e => e.Id == item.CategoryId))
            {
                throw new Exception("Category ID does not exist.");
            }

            var oldItem = _dbContext.Product.FirstOrDefault(e => e.Id == item.Id) ?? throw new InvalidOperationException("Interaction element not found.");

            oldItem.CompanyId = item.CompanyId;
            oldItem.CategoryId = item.CategoryId;
            oldItem.Type = item.Type;
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

        public void AddImportData(Product item)
        {
            if (_dbContext.Company.FirstOrDefault(e => e.Id == item.CompanyId) == null ||
                _dbContext.Category.FirstOrDefault(e => e.Id == item.CategoryId) == null)
            {
                return;
            }

            var duplicateId = _dbContext.Product.FirstOrDefault(e => e.Id == item.Id);
            if (duplicateId == null)
            {
                Add(item);
            }

            Update(item);
        }

        public List<Product> GetAll() => _dbContext.Product.Count() > 0 ? _dbContext.Product.ToList() : null;

        public IQueryable<Product> GetQueryableAll()
            => _dbContext.Product.Include(e => e.Company).Include(e => e.Category).Include(e => e.Category.Types).Select(e => e);
    }
}
