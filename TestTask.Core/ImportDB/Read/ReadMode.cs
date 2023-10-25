using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using TestTask.Core.Components;
using TestTask.Core.Enum;
using TestTask.Core.Extension.ReadExtension;
using TestTask.Core.ImportDB.Component;

namespace TestTask.Core.ImportDB.Read.Header
{
    public class ReadMode
    {
        private const string ModeSheetName = "Modes";

        public List<Result<Mode>> ReadExcel(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException("File does not exist.");
            }

            using (FileStream fileStream = new FileStream(Path.Combine(path), FileMode.Open, FileAccess.Read))
            {
                var workbook = new XSSFWorkbook(fileStream);

                var columnMap = new Dictionary<string, ModeField>
                {
                    ["ID"] = ModeField.Id,
                    ["Name"] = ModeField.Name,
                    ["MaxUsedTips"] = ModeField.MaxUsedTips,
                    ["MaxBottleNumber"] = ModeField.MaxBottleNumber,
                };

                var numberModeSheet = -1;

                for (var i = 0; i < workbook.NumberOfSheets; i++)
                {
                    if (workbook.GetSheetName(i) == ModeSheetName)
                    {
                        numberModeSheet = i;
                        break;
                    }
                }

                ISheet sheet = workbook.GetSheetAt(numberModeSheet);

                Dictionary<ModeField, int> header;
                try
                {
                    header = sheet.ReadHeader(columnMap);
                }
                catch
                {
                    Console.WriteLine("Failed to load title.");
                    Console.ReadLine();
                    return new List<Result<Mode>>();
                }

                var addMode = new List<Result<Mode>>();
                for (var i = 1; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null)
                    {
                        addMode.Add(Result<Mode>.CreateFail("Row should not be empty", row.RowNum));
                        continue;
                    }

                    var modeResult = row.ReadMode(header);
                    addMode.Add(modeResult);
                }

                return addMode;
            }
        }
    }
}
