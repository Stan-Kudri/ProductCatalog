using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using TestTask.Core.Enum;

namespace TestTask.Core.Extension.ReadExtension
{
    public static class ReadHeadExtension
    {
        public static Dictionary<ModeField, int> ReadHeaderMode(this ISheet sheet, Dictionary<string, ModeField> columns)
        {
            var result = new Dictionary<ModeField, int>(columns.Count);
            if (sheet.LastRowNum <= 0)
            {
                throw new Exception("File is empty");
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

                ModeField field;
                if (columns.TryGetValue(str.Value, out field))
                {
                    result[field] = i;
                }
            }

            if (result.Count != columns.Count)
            {
                var notFoundColumns = columns.Select(e => e.Value).Except(result.Keys).ToList();
                throw new Exception($"Unnable to find columns: [{string.Join(", ", notFoundColumns)}]");
            }

            return result;
        }

        public static Dictionary<StepField, int> ReadHeaderStep(this ISheet sheet, Dictionary<string, StepField> columns)
        {
            var result = new Dictionary<StepField, int>(columns.Count);
            if (sheet.LastRowNum <= 0)
            {
                throw new Exception("File is empty");
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

                StepField field;
                if (columns.TryGetValue(str.Value, out field))
                {
                    result[field] = i;
                }
            }

            if (result.Count != columns.Count)
            {
                var notFoundColumns = columns.Select(e => e.Value).Except(result.Keys).ToList();
                throw new Exception($"Unnable to find columns: [{string.Join(", ", notFoundColumns)}]");
            }

            return result;
        }
    }
}
