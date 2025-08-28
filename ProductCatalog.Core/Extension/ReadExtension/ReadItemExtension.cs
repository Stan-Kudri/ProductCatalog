using NPOI.SS.UserModel;
using System.Collections.Generic;
using TestTask.Core.Components;
using TestTask.Core.Components.ItemsTables;
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
                    case ModeField.ID:

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

        public static Result<Step> ReadStep(this IRow row, Dictionary<StepField, int> columns)
        {
            if (row.Cells.Count < columns.Count)
            {
                return Result<Step>.CreateFail("Fewer cells than needed", row.RowNum);
            }

            var res = new Step();
            foreach (var pair in columns)
            {
                switch (pair.Key)
                {
                    case StepField.ID:

                        var id = row.GetInt(pair.Value, "Id");
                        if (!id.Success)
                        {
                            return id.ToError<Step>();
                        }
                        res.Id = id.Value;
                        break;

                    case StepField.ModeId:

                        var modeId = row.GetInt(pair.Value, "ModeId");
                        if (!modeId.Success)
                        {
                            return modeId.ToError<Step>();
                        }
                        res.ModeId = modeId.Value;
                        break;

                    case StepField.Timer:

                        var timer = row.GetInt(pair.Value, "Timer");
                        if (!timer.Success)
                        {
                            return timer.ToError<Step>();
                        }
                        res.Timer = timer.Value;
                        break;

                    case StepField.Destination:

                        var destination = row.GetString(pair.Value, "Destination");
                        if (!destination.Success)
                        {
                            return destination.ToError<Step>();
                        }
                        if (string.IsNullOrEmpty(destination.Value))
                        {
                            res.Destination = null;
                        }
                        res.Destination = destination.Value;
                        break;

                    case StepField.Speed:

                        var speed = row.GetInt(pair.Value, "Speed");
                        if (!speed.Success)
                        {
                            return speed.ToError<Step>();
                        }
                        res.Speed = speed.Value;
                        break;

                    case StepField.Type:

                        var type = row.GetString(pair.Value, "Type");
                        if (!type.Success)
                        {
                            return type.ToError<Step>();
                        }
                        if (string.IsNullOrEmpty(type.Value))
                        {
                            return Result<Step>.CreateFail("Name should not be empty", row.RowNum);
                        }
                        res.Type = type.Value;
                        break;

                    case StepField.Volume:

                        var volume = row.GetInt(pair.Value, "Volume");
                        if (!volume.Success)
                        {
                            return volume.ToError<Step>();
                        }
                        res.Volume = volume.Value;
                        break;
                }

            }

            return Result<Step>.CreateSuccess(res, row.RowNum);
        }
    }
}
