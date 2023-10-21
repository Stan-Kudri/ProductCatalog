using System;

namespace TestTask.Core.Components.ItemsTables
{
    public class Step : Entity
    {
        private Step()
        {
        }

        public Step(int modeId, int timer, string destination, int speed, string type, int volume)
        {
            ModeId = modeId > 0 ? ModeId = modeId : throw new ArgumentException("Step ID greater than zero.", nameof(modeId));

            Timer = timer >= 0 ? Timer = timer : throw new ArgumentException("The timer value is greater than zero.", nameof(timer));

            Destination = destination;

            Speed = speed >= 0 ? Speed = speed : throw new ArgumentException("The speed value is greater than zero.", nameof(speed));

            Type = type != string.Empty && type != null ?
                Type = type :
                throw new ArgumentException("The type name cannot be empty.", nameof(type));

            Volume = volume >= 0 ? Volume = volume : throw new ArgumentException("The volume cannot be less than zero.", nameof(volume));
        }

        public int ModeId { get; set; } = 0;

        public int Timer { get; set; } = 0;

        public string Destination { get; set; } = null;

        public int Speed { get; set; } = 0;

        public string Type { get; set; } = string.Empty;

        public int Volume { get; set; } = 0;

        public override bool Equals(object obj) => Equals(obj as Step);

        public bool Equals(Step other)
        {
            if (other == null)
            {
                return false;
            }

            return other.Id == Id
                   && other.ModeId == ModeId
                   && other.Timer == Timer
                   && other.Destination == Destination
                   && other.Speed == Speed
                   && other.Type == Type
                   && other.Volume == Volume;
        }

        public override int GetHashCode() => Id.GetHashCode() * ModeId.GetHashCode() + Type.GetHashCode();
    }
}
