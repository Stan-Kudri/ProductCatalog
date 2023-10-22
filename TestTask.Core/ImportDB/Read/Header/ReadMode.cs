using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using TestTask.Core.Enum;
using TestTask.Core.Extension.ReadExtension;

namespace TestTask.Core.ImportDB.Read.Header
{
    public class ReadMode
    {
        private const string ModeSheetName = "Modes";

        public void Reader()
        {
            using (FileStream fileStream = new FileStream("DataExample.xlsx", FileMode.Open, FileAccess.Read))
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
                    header = sheet.ReadHeaderMode(columnMap);
                }
                catch
                {
                    Console.WriteLine("Failed to load title.");
                    Console.ReadLine();
                    return;
                }
            }
        }
    }
}
