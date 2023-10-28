using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using TestTask.Core.Extension;
using TestTask.Core.Models.Modes;

namespace TestTask.Core.Import.Importers
{
    public class ModeImporter : IImporter<Mode>
    {
        private readonly Dictionary<string, ModeField> _columnMap = new Dictionary<string, ModeField>
        {
            ["ID"] = ModeField.ID,
            ["Name"] = ModeField.Name,
            ["MaxUsedTips"] = ModeField.MaxUsedTips,
            ["MaxBottleNumber"] = ModeField.MaxBottleNumber,
        };

        private Dictionary<ModeField, int> _header;

        public bool IsModelSheet(string sheetName) => sheetName == "Modes";

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

        public Result<Mode> ReadRow(IRow row)
        {
            if (_header == null)
            {
                throw new Exception("You should read header");
            }

            if (row.Cells.Count < _header.Count)
            {
                return Result<Mode>.CreateFail("Fewer cells than needed", row.RowNum);
            }

            var res = new Mode();
            foreach (var pair in _header)
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
    }
}
