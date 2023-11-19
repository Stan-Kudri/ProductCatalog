using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask.Core.Models.Types
{
    public class ProductTypeService
    {
        private readonly AppDbContext _dbContext;

        public ProductTypeService(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(ProductType item)
        {
            if (item == null)
            {
                throw new ArgumentException("The received parameters are not correct.", nameof(item));
            }

            if (_dbContext.Type.Any(e => e.Id == item.Id))
            {
                throw new ArgumentException("This type exists.");
            }

            if (_dbContext.Category.FirstOrDefault(e => e.Id == item.CategoryId) == null)
            {
                throw new Exception("Category ID does not exist.");
            }

            _dbContext.Type.Add(item);
            _dbContext.SaveChanges();
        }

        public void Update(ProductType item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(item));
            }

            if (!_dbContext.Category.Any(e => e.Id == item.CategoryId))
            {
                throw new Exception("Category ID does not exist.");
            }

            var oldItem = _dbContext.Type.FirstOrDefault(e => e.Id == item.Id) ?? throw new InvalidOperationException("Interaction element not found.");

            oldItem.Name = item.Name;
            oldItem.CategoryId = item.CategoryId;

            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var item = _dbContext.Type.FirstOrDefault(e => e.Id == id) ?? throw new InvalidOperationException("Interaction element not found.");
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

        public void RemoveProductRelatedToCategory(int categoryId)
        {
            var item = _dbContext.Type.Where(e => e.CategoryId == categoryId).Select(e => e);

            if (item.Count() <= 0)
            {
                return;
            }

            _dbContext.Type.RemoveRange(item.ToList());
        }

        public void AddImportData(ProductType item)
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

            Update(item);
        }

        public List<ProductType> GetAll() => _dbContext.Type.Count() > 0 ? _dbContext.Type.ToList() : null;

        public IQueryable<ProductType> GetQueryableAll() => _dbContext.Type.Include(e => e.Category).Select(e => e);
    }
}
