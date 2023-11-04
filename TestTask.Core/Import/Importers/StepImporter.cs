using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using TestTask.Core.Extension;
using TestTask.Core.Models.Steeps;

namespace TestTask.Core.Import.Importers
{
    public class StepImporter : IImporter<Step>
    {
        private readonly Dictionary<string, StepField> _columnMap = new Dictionary<string, StepField>
        {
            ["ID"] = StepField.ID,
            ["ModeId"] = StepField.ModeId,
            ["Destination"] = StepField.Destination,
            ["Speed"] = StepField.Speed,
            ["Type"] = StepField.Type,
            ["Volume"] = StepField.Volume,
        };

        private Dictionary<StepField, int> _header;

        public bool IsModelSheet(string sheetName) => sheetName == "Steps";

        public bool ReadHeader(ISheet sheet)
        {
            _header = null;
            try
            {
                _header = sheet.ReadHeader(_columnMap);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Result<Step> ReadRow(IRow row)
        {
            if (_header == null)
            {
                throw new Exception("You should read header");
            }

            if (row.Cells.Count < _header.Count)
            {
                return Result<Step>.CreateFail("Fewer cells than needed", row.RowNum);
            }

            var res = new Step();
            foreach (var pair in _header)
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
                        res.CompanyId = modeId.Value;
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
