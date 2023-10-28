using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using TestTask.Core.Import.Importers;

namespace TestTask.Core.Import
{
    public class ExcelImporter<T>
    {
        private IImporter<T> _importer;

        public ExcelImporter(IImporter<T> importer)
        {
            _importer = importer;
        }

        public List<Result<T>> ImportFromFile(string path)
        {
            using (var file = File.OpenRead(path))
            {
                return Import(file);
            }
        }

        public List<Result<T>> Import(Stream stream)
        {
            var workbook = new XSSFWorkbook(stream);
            var sheet = GetSheet(workbook);

            var success = _importer.ReadHeader(sheet);
            if (!success)
            {
                Console.WriteLine("Failed to load title.");
                Console.ReadLine();
                return new List<Result<T>>();
            }

            var addMode = new List<Result<T>>();
            for (var i = 1; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row == null)
                {
                    addMode.Add(Result<T>.CreateFail("Row should not be empty", row.RowNum));
                    continue;
                }

                var modeResult = _importer.ReadRow(row);
                addMode.Add(modeResult);
            }

            return addMode;
        }

        private ISheet GetSheet(XSSFWorkbook workbook)
        {
            var numberSheet = 0;
            for (var i = 0; i < workbook.NumberOfSheets; i++)
            {
                var sheetName = workbook.GetSheetName(i);
                if (_importer.IsModelSheet(sheetName))
                {
                    numberSheet = i;
                    break;
                }
            }

            return workbook.GetSheetAt(numberSheet);
        }
    }
}
