using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask.Core.Models.Modes
{
    public class ModeService : IService<Mode>
    {
        private readonly AppDbContext _dbContext;

        public ModeService(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(Mode item)
        {
            if (item == null)
            {
                throw new ArgumentException("The received parameters are not correct.", nameof(item));
            }

            if (_dbContext.Modes.Any(e => e.Id == item.Id))
            {
                throw new ArgumentException("This mode exists.");
            }

            _dbContext.Modes.Add(item);
            _dbContext.SaveChanges();
        }

        public void Update(Mode item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(item));
            }

            var oldItem = _dbContext.Modes.FirstOrDefault(e => e.Id == item.Id) ?? throw new InvalidOperationException("Interaction element not found.");

            oldItem.Name = item.Name;
            oldItem.MaxBottleNumber = item.MaxBottleNumber;
            oldItem.MaxUsedTips = item.MaxUsedTips;

            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var mode = _dbContext.Modes.FirstOrDefault(e => e.Id == id) ?? throw new InvalidOperationException("Interaction element not found.");
            _dbContext.Modes.Remove(mode);
            _dbContext.SaveChanges();
        }

        public void AddImportData(Mode mode)
        {
            var duplicateId = _dbContext.Modes.FirstOrDefault(e => e.Id == mode.Id);
            if (duplicateId == null)
            {
                Add(mode);
            }

            Update(mode);
        }

        public List<Mode> GetAll() => _dbContext.Modes.Count() > 0 ? _dbContext.Modes.ToList() : null;

        public IQueryable<Mode> GetModes() => _dbContext.Modes.Select(e => e);
    }
}
