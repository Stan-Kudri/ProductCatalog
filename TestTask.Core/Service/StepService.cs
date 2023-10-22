using System;
using System.Linq;
using TestTask.Core.Components.ItemsTables;
using TestTask.Core.Db;

namespace TestTask.Core.Service
{
    public class StepService
    {
        private readonly AppDbContext _dbContext;

        public StepService(AppDbContext appDbContext) => _dbContext = appDbContext;

        public void Add(Step step)
        {
            if (step == null)
            {
                throw new ArgumentException("The received parameters are not correct.", nameof(step));
            }

            if (_dbContext.Modes.FirstOrDefault(e => e.Id == step.ModeId) == null)
            {
                throw new Exception("Mode ID does not exist.");
            }

            _dbContext.Steps.Add(step);
            _dbContext.SaveChanges();
        }

        public void Edit(Step step)
        {
            if (step == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(step));
            }

            if (_dbContext.Modes.FirstOrDefault(e => e.Id == step.ModeId) != null)
            {
                throw new Exception("Mode ID does not exist.");
            }

            var item = _dbContext.Steps.FirstOrDefault(e => e.Id == step.Id) ?? throw new InvalidOperationException("Interaction element not found.");

            item.ModeId = step.ModeId;
            item.Timer = step.Timer;
            item.Destination = step.Destination;
            item.Speed = step.Speed;
            item.Type = step.Type;
            item.Volume = step.Volume;

            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var step = _dbContext.Steps.FirstOrDefault(e => e.Id == id) ?? throw new InvalidOperationException("Interaction element not found.");
            _dbContext.Steps.Remove(step);
            _dbContext.SaveChanges();
        }
    }
}
