using System;

namespace TestTask.Core.Models.Page
{
    public class Page
    {
        public const int StartSizePage = 15;
        public const int StartNumberPage = 1;

        protected int _number;
        protected int _size;

        public Page(int number = 1, int size = 15)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number page can not be empty.", nameof(number));
            }

            if (size <= 0)
            {
                throw new ArgumentException("The page must contain item.", nameof(size));
            }

            _number = number;
            _size = size;
        }

        public int Number
        {
            get => _number;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number page can not be empty.", nameof(value));
                }

                _number = value;
            }
        }

        public int Size
        {
            get => _size;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The page must contain item.", nameof(value));
                }

                _size = value;
            }
        }
    }
}
