using System;
using System.Collections.Generic;
using System.Linq;
using NPOI.SS.UserModel;
using TestTask.Core.Exeption;

namespace TestTask.Core.Extension
{
    public static class SheetExtension
    {
        public static Dictionary<T, int> ReadHeader<T>(this ISheet sheet, Dictionary<string, T> columns) where T : Enum
        {
            var result = new Dictionary<T, int>(columns.Count);
            if (sheet.LastRowNum <= 0)
            {
                throw new BusinessLogicException("File is empty");
            }

            var rowFirst = sheet.GetRow(0);
            var column = rowFirst.Cells.Count;

            for (int i = 0; i < column; i++)
            {
                var cell = rowFirst.GetCell(i);
                if (cell == null)
                {
                    continue;
                }

                var str = rowFirst.GetString(i, string.Empty);
                if (!str.Success || string.IsNullOrEmpty(str.Value))
                {
                    continue;
                }

                T field;
                if (columns.TryGetValue(str.Value, out field))
                {
                    result[field] = i;
                }
            }

            if (result.Count != columns.Count)
            {
                var notFoundColumns = columns.Select(e => e.Value).Except(result.Keys).ToList();
                throw new BusinessLogicException($"Unnable to find columns: [{string.Join(", ", notFoundColumns)}]");
            }

            return result;
        }
    }
}
