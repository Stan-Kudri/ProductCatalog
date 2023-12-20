using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
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

        public List<Result<T>> Import(byte[]? bytes)
            => Import(new MemoryStream(bytes));

        public List<Result<T>> Import(Stream stream)
        {
            var workbook = new XSSFWorkbook(stream);
            var addMode = new List<Result<T>>();

            if (!TryGetSheet(workbook, out var sheet))
            {
                addMode.Add(Result<T>.CreateFail("Failed to read sheet.", 0));
                return addMode;
            }

            var success = _importer.ReadHeader(sheet);
            if (!success)
            {
                var result = Result<T>.CreateFail("Failed to load title.", 0);
                addMode.Add(result);
                return addMode;
            }

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

        private bool TryGetSheet(XSSFWorkbook workbook, out ISheet sheet)
        {
            for (var i = 0; i < workbook.NumberOfSheets; i++)
            {
                var sheetName = workbook.GetSheetName(i);
                if (_importer.
                    IsModelSheet(sheetName))
                {
                    sheet = workbook.GetSheetAt(i);
                    return true;
                }
            }

            sheet = null;
            return false;
        }
    }
}
