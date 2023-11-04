using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask.Core.Models.Steeps
{
    public class StepService : IService<Step>
    {
        private readonly AppDbContext _dbContext;

        public StepService(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(Step item)
        {
            if (item == null)
            {
                throw new ArgumentException("The received parameters are not correct.", nameof(item));
            }

            if (_dbContext.Company.FirstOrDefault(e => e.Id == item.CompanyId) == null)
            {
                throw new Exception("Company ID does not exist.");
            }

            _dbContext.Steps.Add(item);
            _dbContext.SaveChanges();
        }

        public void Update(Step item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(item));
            }

            if (!_dbContext.Company.Any(e => e.Id == item.CompanyId))
            {
                throw new Exception("Company ID does not exist.");
            }

            var oldItem = _dbContext.Steps.FirstOrDefault(e => e.Id == item.Id) ?? throw new InvalidOperationException("Interaction element not found.");

            oldItem.CompanyId = item.CompanyId;
            oldItem.Timer = item.Timer;
            oldItem.Destination = item.Destination;
            oldItem.Speed = item.Speed;
            oldItem.Type = item.Type;
            oldItem.Volume = item.Volume;

            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var step = _dbContext.Steps.FirstOrDefault(e => e.Id == id) ?? throw new InvalidOperationException("Interaction element not found.");
            _dbContext.Steps.Remove(step);
            _dbContext.SaveChanges();
        }

        public void RemoveStepRelatedToMode(int modeId)
        {
            var steps = _dbContext.Steps.Where(e => e.CompanyId == modeId).Select(e => e);

            if (steps.Count() <= 0)
            {
                return;
            }

            _dbContext.Steps.RemoveRange(steps.ToList());
        }

        public void AddImportData(Step step)
        {
            if (_dbContext.Company.FirstOrDefault(e => e.Id == step.CompanyId) == null)
            {
                return;
            }

            var duplicateId = _dbContext.Steps.FirstOrDefault(e => e.Id == step.Id);
            if (duplicateId == null)
            {
                Add(step);
            }

            Update(step);
        }

        public List<Step> GetAll() => _dbContext.Steps.Count() > 0 ? _dbContext.Steps.ToList() : null;

        public IQueryable<Step> GetQueryableAll() => _dbContext.Steps.Select(e => e);
    }
}
