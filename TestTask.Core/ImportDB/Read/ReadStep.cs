using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using TestTask.Core.Enum;
using TestTask.Core.Extension.ReadExtension;

namespace TestTask.Core.ImportDB.Read.Header
{
    public class ReadStep
    {
        private const string StepSheetName = "Steps";

        public void Reader()
        {
            using (FileStream fileStream = new FileStream("DataExample.xlsx", FileMode.Open, FileAccess.Read))
            {
                var workbook = new XSSFWorkbook(fileStream);

                var columnMap = new Dictionary<string, StepField>
                {
                    ["ID"] = StepField.Id,
                    ["ModeId"] = StepField.ModeId,
                    ["Destination"] = StepField.Destination,
                    ["Speed"] = StepField.Speed,
                    ["Type"] = StepField.Type,
                    ["Volume"] = StepField.Volume,
                };

                var numberStepSheet = -1;

                for (var i = 0; i < workbook.NumberOfSheets; i++)
                {
                    if (workbook.GetSheetName(i) == StepSheetName)
                    {
                        numberStepSheet = i;
                        break;
                    }
                }

                ISheet sheet = workbook.GetSheetAt(numberStepSheet);

                Dictionary<StepField, int> header;
                try
                {
                    header = sheet.ReadHeaderStep(columnMap);
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
