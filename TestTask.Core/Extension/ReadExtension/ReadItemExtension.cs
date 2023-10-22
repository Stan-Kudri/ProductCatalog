using NPOI.SS.UserModel;
using System.Collections.Generic;
using TestTask.Core.Components;
using TestTask.Core.Enum;
using TestTask.Core.ImportDB.Component;

namespace TestTask.Core.Extension.ReadExtension
{
    public static class ReadItemExtension
    {
        public static Result<Mode> ReadMode(this IRow row, Dictionary<ModeField, int> columns)
        {
            if (row.Cells.Count < columns.Count)
            {
                return Result<Mode>.CreateFail("Fewer cells than needed", row.RowNum);
            }

            var res = new Mode();
            foreach (var pair in columns)
            {
                switch (pair.Key)
                {
                    case ModeField.Id:

                        var id = row.GetInt(pair.Value, "Id");
                        if (!id.Success)
                        {
                            return id.ToError<Mode>();
                        }
                        res.Id = id.Value;
                        break;

                    case ModeField.Name:

                        var name = row.GetString(pair.Value, "Name");
                        if (!name.Success)
                        {
                            return name.ToError<Mode>();
                        }
                        if (string.IsNullOrEmpty(name.Value))
                        {
                            return Result<Mode>.CreateFail("Name should not be empty", row.RowNum);
                        }
                        res.Name = name.Value;
                        break;

                    case ModeField.MaxBottleNumber:

                        var bottleNumber = row.GetInt(pair.Value, "MaxBottle");
                        if (!bottleNumber.Success)
                        {
                            return bottleNumber.ToError<Mode>();
                        }
                        res.MaxBottleNumber = bottleNumber.Value;
                        break;

                    case ModeField.MaxUsedTips:

                        var maxUsedTips = row.GetInt(pair.Value, "MaxUsedTips");
                        if (!maxUsedTips.Success)
                        {
                            return maxUsedTips.ToError<Mode>();
                        }
                        res.MaxUsedTips = maxUsedTips.Value;
                        break;
                }

            }

            return Result<Mode>.CreateSuccess(res, row.RowNum);
        }
    }
}
