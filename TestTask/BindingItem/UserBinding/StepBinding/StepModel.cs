using System;
using TestTask.Core.Models.Company;
using TestTask.Core.Models.Steeps;

namespace TestTask.BindingItem.UserBinding
{
    public class StepModel : ModelBase
    {
        private Company _company = null;
        private int _timer = 0;
        private string _destination = null;
        private int _speed = 0;
        private string _type = string.Empty;
        private int _volume = 0;

        public StepModel(Company company, int timer, string destination, int speed, string type, int volume)
        {
            Company = company ?? throw new ArgumentException("The company cannot be null.", nameof(company));

            Timer = timer >= 0 ? Timer = timer : throw new ArgumentException("The timer value is greater than zero.", nameof(timer));

            Destination = destination;

            Speed = speed >= 0 ? Speed = speed : throw new ArgumentException("The speed value is greater than zero.", nameof(speed));

            Type = type != string.Empty && type != null ?
                Type = type :
                throw new ArgumentException("The type name cannot be empty.", nameof(type));

            Volume = volume >= 0 ? Volume = volume : throw new ArgumentException("The volume cannot be less than zero.", nameof(volume));
        }


        public Company Company
        {
            get => _company;
            set => SetField(ref _company, value);
        }

        public int Timer
        {
            get => _timer;
            set => SetField(ref _timer, value);
        }

        public string Destination
        {
            get => _destination;
            set => SetField(ref _destination, value);
        }

        public int Speed
        {
            get => _speed;
            set => SetField(ref _speed, value);
        }

        public string Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        public int Volume
        {
            get => _volume;
            set => SetField(ref _volume, value);
        }

        public Step ToStep() => new Step(_company.Id, _timer, _destination, _speed, _type, _volume);

        public Step ToStep(int stepId) => new Step(_company.Id, _timer, _destination, _speed, _type, _volume, stepId);
    }
}
