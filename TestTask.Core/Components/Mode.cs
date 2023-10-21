using System;

namespace TestTask.Core.Components
{
    public class Mode : Entity
    {
        private Mode()
        {
        }

        public Mode(string name, int maxBottleNumber, int maxUsedTips)
        {
            if (name == string.Empty || name == null)
            {
                throw new ArgumentException("The step name cannot be empty.", nameof(name));
            }

            if (maxBottleNumber < 0)
            {
                throw new ArgumentException("The maximum number of bottles cannot be less than zero.", nameof(maxBottleNumber));
            }

            if (maxBottleNumber < 0)
            {
                throw new ArgumentException("The maximum used of tips cannot be less than zero.", nameof(maxUsedTips));
            }

            Name = name;
            MaxBottleNumber = maxBottleNumber;
            MaxUsedTips = maxBottleNumber;
        }

        public string Name { get; set; } = string.Empty;

        public int MaxBottleNumber { get; set; } = 0;

        public int MaxUsedTips { get; set; } = 0;
    }
}
