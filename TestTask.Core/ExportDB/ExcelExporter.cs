using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.IO;
using TestTask.Core.ExportDB.SheetFillers;

namespace TestTask.Core.ExportDB
{
    public class ExcelExporter
    {
        private readonly IReadOnlyCollection<ISheetFiller> _fillers;

        public ExcelExporter(IReadOnlyCollection<ISheetFiller> fillers)
        {
            _fillers = fillers;
        }

        public void Export(Stream destination)
        {
            var workbook = new XSSFWorkbook();

            foreach (var filler in _fillers)
            {
                var sheet = workbook.CreateSheet(filler.Name);
                filler.Fill(sheet);
            }

            workbook.Write(destination);
        }

        public void ExportToFile(string path)
        {
            using (var fileStream = File.OpenWrite(Path.Combine(path)))
            {
                Export(fileStream);
            }
        }
    }
}
