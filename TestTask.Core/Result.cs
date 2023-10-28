using System;

namespace TestTask.Core
{
    public class Result<T>
    {
        private Result(T value, bool success, string error, int row)
        {
            Value = value;
            Success = success;
            Error = error;
            Row = row;
        }

        public T Value { get; }

        public bool Success { get; }

        public string Error { get; }

        public int Row { get; }


        public Result<T2> ToError<T2>()
        {
            if (Success)
            {
                throw new Exception("Should be error.");
            }

            return Result<T2>.CreateFail(Error, Row);
        }

        public static Result<T> CreateSuccess(T value, int row) => new Result<T>(value, true, string.Empty, row);

        public static Result<T> CreateFail(string error, int row)
        {
            if (string.IsNullOrEmpty(error))
            {
                throw new Exception("Error cannot be empty.");
            }

            return new Result<T>(default, false, error, row);
        }

        public override string ToString()
        {
            if (!Success)
            {
                return Row + ". " + Error;
            }

            return Row + ". " + Value.ToString();
        }
    }
}
