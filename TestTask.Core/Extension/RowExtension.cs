using NPOI.SS.UserModel;
using System;
using TestTask.Core.ImportDB.Component;

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

            if (cell.CellType == CellType.String)
            {
                try
                {
                    var value = cell.StringCellValue;
                    return Result<int>.CreateSuccess(Convert.ToInt32(value), self.RowNum);
                }
                catch
                {
                    return Result<int>.CreateFail(valueShouldBeNumberMessage, self.RowNum);
                }
            }

            try
            {
                var value = cell.NumericCellValue;
                return Result<int>.CreateSuccess(Convert.ToInt32(value), self.RowNum);
            }
            catch
            {
                return Result<int>.CreateFail(valueShouldBeNumberMessage, self.RowNum);
            }
        }
    }
}
