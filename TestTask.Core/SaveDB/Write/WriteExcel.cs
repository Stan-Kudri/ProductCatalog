using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.IO;
using TestTask.Core.Enum;
using TestTask.Core.Extension.WriteExtension;
using TestTask.Core.Service;
using TestTask.Core.Service.Components;

namespace TestTask.Core.SaveDB.Write
{
    public class WriteExcel
    {
        private readonly StepService _stepService;
        private readonly ModeService _modeService;

        public WriteExcel(StepService stepService, ModeService modeService, IMessageBox messageBox)
        {
            _stepService = stepService;
            _modeService = modeService;
        }

        public void Write()
        {
            IWorkbook workbook = new XSSFWorkbook();

            var items = _modeService.GetAllMode();

            if (items == null)
            {
                return;
            }

            ISheet sheet = workbook.CreateSheet<ModeField>();

            var columnMap = new Dictionary<int, string>
            {
                [((int)ModeField.ID)] = ModeField.ID.ToString(),
                [((int)ModeField.Name)] = ModeField.Name.ToString(),
                [((int)ModeField.MaxBottleNumber)] = ModeField.MaxBottleNumber.ToString(),
                [((int)ModeField.MaxUsedTips)] = ModeField.MaxUsedTips.ToString(),
            };

            var columnNumber = columnMap.Count;
            IRow row = sheet.CreateRow(0);
            for (var j = 0; j < columnNumber; j++)
            {
                row.CreateCell(j).SetCellValue(columnMap[j]);
            }

            var numberRow = 0;

            foreach (var item in items)
            {
                numberRow++;
                row = sheet.CreateRow(numberRow);
                row.CreateCell(0).SetCellValue(item.Id);
                row.CreateCell(1).SetCellValue(item.Name);
                row.CreateCell(2).SetCellValue(item.MaxBottleNumber);
                row.CreateCell(3).SetCellValue(item.MaxUsedTips);
            }

            using (FileStream fileStream = new FileStream("newFileExcel.xlsx", FileMode.Create))
            {
                workbook.Write(fileStream);
            }
        }
    }
}
