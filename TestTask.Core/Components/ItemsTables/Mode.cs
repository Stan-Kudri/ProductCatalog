using System;
using System.Collections.Generic;
using TestTask.Core.Components.ItemsTables;

namespace TestTask.Core.Components
{
    public class Mode : Entity
    {
        private Mode()
        {
        }

        public Mode(string name, int maxBottleNumber, int maxUsedTips, int id)
            : this(name, maxBottleNumber, maxUsedTips)
        {
            Id = id > 0 ? Id = id : throw new ArgumentException("The ID must be greater than zero.", nameof(id));
        }

        public Mode(string name, int maxBottleNumber, int maxUsedTips, List<Step> steps = null)
        {
            Name = name != string.Empty && name != null ? Name = name : throw new ArgumentException("The step name cannot be empty.", nameof(name));

            MaxBottleNumber = maxBottleNumber >= 0 ?
                MaxBottleNumber = maxBottleNumber :
                throw new ArgumentException("The maximum number of bottles cannot be less than zero.", nameof(maxBottleNumber));

            MaxUsedTips = maxUsedTips >= 0 ?
                MaxUsedTips = maxUsedTips :
                throw new ArgumentException("The maximum used of tips cannot be less than zero.", nameof(maxUsedTips));

            Steps = steps;
        }

        public string Name { get; set; } = string.Empty;

        public int MaxBottleNumber { get; set; } = 0;

        public int MaxUsedTips { get; set; } = 0;

        public List<Step> Steps { get; set; } = null;

        public override bool Equals(object obj) => Equals(obj as Mode);

        public bool Equals(Mode other)
        {
            if (other == null)
            {
                return false;
            }

            return other.Id == Id
                   && other.Name == Name
                   && other.MaxBottleNumber == MaxBottleNumber
                   && other.MaxUsedTips == MaxUsedTips;
        }

        public override int GetHashCode() => Id.GetHashCode() + MaxBottleNumber.GetHashCode() + MaxUsedTips.GetHashCode();

        public override string ToString() => Name;
    }
}
