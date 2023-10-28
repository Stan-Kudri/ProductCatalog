using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using TestTask.Core.Models.Steeps;

namespace TestTask.Core.Export.SheetFillers
{
    public class StepSheetFiller : ISheetFiller
    {
        private readonly StepService _stepService;
        private readonly List<StepField> _columnMap = CreateColumnMap();

        public StepSheetFiller(StepService stepService) => _stepService = stepService;

        public string Name => "Steps";

        public List<StepField> ColumnMap => _columnMap;

        public void Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < _columnMap.Count; i++)
            {
                StepField column = _columnMap[i];
                row.CreateCell(i).SetCellValue(column.ToString());
            }

            var numberRow = 0;

            foreach (var item in _stepService.GetAll())
            {
                numberRow++;
                row = sheet.CreateRow(numberRow);

                for (int i = 0; i < _columnMap.Count; i++)
                {
                    StepField column = _columnMap[i];
                    ICell cell = row.CreateCell(i);
                    switch (column)
                    {
                        case StepField.ID:
                            cell.SetCellValue(item.Id);
                            break;
                        case StepField.ModeId:
                            cell.SetCellValue(item.ModeId);
                            break;
                        case StepField.Timer:
                            cell.SetCellValue(item.Timer);
                            break;
                        case StepField.Destination:
                            cell.SetCellValue(item.Destination);
                            break;
                        case StepField.Speed:
                            cell.SetCellValue(item.Speed);
                            break;
                        case StepField.Type:
                            cell.SetCellValue(item.Type);
                            break;
                        case StepField.Volume:
                            cell.SetCellValue(item.Volume);
                            break;
                        default:
                            throw new Exception("Unknown field.");
                    }
                }
            }
        }

        private static List<StepField> CreateColumnMap()
        {
            var columnMap = new List<StepField>();
            foreach (StepField suit in (StepField[])Enum.GetValues(typeof(StepField)))
            {
                columnMap.Add(suit);
            }

            return columnMap;
        }
    }
}
