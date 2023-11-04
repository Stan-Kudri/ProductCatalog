using NPOI.SS.UserModel;
using System;

namespace TestTask.Core.Extension
{
    public static class RowExtension
    {
        public static Result<string> GetString(this IRow self, int cellNumber, string columnName)
        {
            var cell = self.GetCell(cellNumber);

            if (cell == null)
            {
                return Result<string>.CreateSuccess(null, self.RowNum);
            }

            try
            {
                var value = cell.StringCellValue;
                return Result<string>.CreateSuccess(value, self.RowNum);
            }
            catch
            {
                return Result<string>.CreateFail($"{columnName} should be string", self.RowNum);
            }
        }

        public static Result<int> GetInt(this IRow self, int cellNumber, string columnName)
        {
            var cell = self.GetCell(cellNumber);

            if (cell == null)
            {
                return Result<int>.CreateFail(columnName + " cell is empty", self.RowNum);
            }

            string valueShouldBeNumberMessage = columnName + " should be number";

            if (cell.CellType == CellType.Blank)
            {
                return Result<int>.CreateFail(valueShouldBeNumberMessage, self.RowNum);
            }

            try
            {
                if (cell.CellType == CellType.String)
                {
                    var valueInStringCell = cell.StringCellValue;
                    return Result<int>.CreateSuccess(Convert.ToInt32(valueInStringCell), self.RowNum);
                }

                var valueInNumericCell = cell.NumericCellValue;
                return Result<int>.CreateSuccess(Convert.ToInt32(valueInNumericCell), self.RowNum);
            }
            catch
            {
                return Result<int>.CreateFail(valueShouldBeNumberMessage, self.RowNum);
            }
        }

        public static Result<DateTime> GetDate(this IRow self, int cellNumber, string columnName)
        {
            var cell = self.GetCell(cellNumber);

            if (cell == null)
            {
                return Result<DateTime>.CreateFail(columnName + " cell is empty", self.RowNum);
            }

            string valueShouldBeNumberMessage = columnName + " should be number";

            if (cell.CellType == CellType.Blank)
            {
                return Result<DateTime>.CreateFail(valueShouldBeNumberMessage, self.RowNum);
            }

            try
            {
                if (cell.CellType == CellType.String)
                {
                    var valueInStringCell = cell.StringCellValue;
                    return Result<DateTime>.CreateSuccess(Convert.ToDateTime(valueInStringCell), self.RowNum);
                }

                var valueInDateTimeCell = cell.DateCellValue;
                return Result<DateTime>.CreateSuccess(valueInDateTimeCell, self.RowNum);
            }
            catch
            {
                return Result<DateTime>.CreateFail(valueShouldBeNumberMessage, self.RowNum);
            }
        }
    }
}
