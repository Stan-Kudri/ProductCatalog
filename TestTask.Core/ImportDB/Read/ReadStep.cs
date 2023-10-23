using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using TestTask.Core.Components.ItemsTables;
using TestTask.Core.Enum;
using TestTask.Core.Extension.ReadExtension;
using TestTask.Core.ImportDB.Component;

namespace TestTask.Core.ImportDB.Read.Header
{
    public class ReadStep
    {
        private const string StepSheetName = "Steps";

        public List<Result<Step>> Reader(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException("File does not exist.");
            }

            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
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
                    return new List<Result<Step>>();
                }

                var addMode = new List<Result<Step>>();
                for (var i = 1; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null)
                    {
                        addMode.Add(Result<Step>.CreateFail("Row should not be empty", row.RowNum));
                        continue;
                    }

                    var modeResult = row.ReadStep(header);
                    addMode.Add(modeResult);
                }

                return addMode;
            }
        }
    }
}
