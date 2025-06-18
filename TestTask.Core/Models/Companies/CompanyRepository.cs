using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TestTask.Core.DBContext;

namespace TestTask.Core.Models.Companies
{
    public class CompanyRepository : IRepository<Company>
    {
        private readonly AppDbContext _dbContext;

        public CompanyRepository(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(Company item)
        {
            if (item == null)
            {
                throw new ArgumentException("The received parameters are not correct.", nameof(item));
            }

            if (_dbContext.Company.Any(e => e.Id == item.Id))
            {
                throw new ArgumentException("This company exists.");
            }

            _dbContext.Company.Add(item);
            _dbContext.SaveChanges();
        }

        public void Updata(Company item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(item));
            }

            var oldItem = _dbContext.Company.FirstOrDefault(e => e.Id == item.Id)
                            ?? throw new InvalidOperationException("Interaction element not found.");

            oldItem.Name = item.Name;
            oldItem.DateCreation = item.DateCreation;
            oldItem.Country = item.Country;

            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var company = _dbContext.Company.FirstOrDefault(e => e.Id == id)
                            ?? throw new InvalidOperationException("Interaction element not found.");

            _dbContext.Company.Remove(company);
            _dbContext.SaveChanges();
        }

        public void AddRange(List<Company> companies)
        {
            foreach (var item in companies)
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

        public void Upsert(Company company)
        {
            var duplicateId = _dbContext.Company.FirstOrDefault(e => e.Id == company.Id);

            if (duplicateId == null)
            {
                Add(company);
            }

            Updata(company);
        }

        public string CompanyName(int id)
            => _dbContext.Company.FirstOrDefault(e => e.Id == id).Name
            ?? throw new ArgumentException("Interaction element not found.");

        public Company GetCompany(int? id)
            => _dbContext.Company.FirstOrDefault(e => e.Id == id);

        public List<Company> GetAll()
            => _dbContext.Company.Any() ? _dbContext.Company.AsNoTracking().ToList() : null;

        public IQueryable<Company> GetQueryableAll()
            => _dbContext.Company.AsNoTracking();

        public bool IsFreeName(string name)
            => _dbContext.Company.FirstOrDefault(e => e.Name == name) == null;

        public bool IsFreeNameItemUpsert(Company item)
        {
            var busyItem = _dbContext.Company.FirstOrDefault(e => e.Name == item.Name);
            return busyItem == null || item.Id == busyItem.Id;
        }
    }
}
