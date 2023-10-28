using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using TestTask.Core.Enum;
using TestTask.Core.Service;

namespace TestTask.Core.ExportDB.SheetFillers
{
    public class ModeSheetFiller : ISheetFiller
    {
        private readonly ModeService _modeService;
        private readonly List<ModeField> _columnMap = CreateColumnMap();

        public ModeSheetFiller(ModeService modeService) => _modeService = modeService;

        public string Name => "Modes";

        public List<ModeField> ColumnMap => _columnMap;

        public void Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < _columnMap.Count; i++)
            {
                ModeField column = _columnMap[i];
                row.CreateCell(i).SetCellValue(column.ToString());
            }

            var numberRow = 0;

            foreach (var item in _modeService.GetAll())
            {
                numberRow++;
                row = sheet.CreateRow(numberRow);

                for (int i = 0; i < _columnMap.Count; i++)
                {
                    ModeField column = _columnMap[i];
                    ICell cell = row.CreateCell(i);
                    switch (column)
                    {
                        case ModeField.ID:
                            cell.SetCellValue(item.Id);
                            break;
                        case ModeField.Name:
                            cell.SetCellValue(item.Name);
                            break;
                        case ModeField.MaxBottleNumber:
                            cell.SetCellValue(item.MaxBottleNumber);
                            break;
                        case ModeField.MaxUsedTips:
                            cell.SetCellValue(item.MaxUsedTips);
                            break;
                        default:
                            throw new Exception("Unknown field.");
                    }
                }
            }
        }

        private static List<ModeField> CreateColumnMap()
        {
            var columnMap = new List<ModeField>();
            foreach (ModeField suit in (ModeField[])System.Enum.GetValues(typeof(ModeField)))
            {
                columnMap.Add(suit);
            }

            return columnMap;
        }
    }
}
