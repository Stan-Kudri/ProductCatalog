using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using TestTask.Core.Models.Types;

namespace TestTask.Core.Export.SheetFillers
{
    public class TypeSheetFiller : ISheetFiller
    {
        private readonly ProductTypeService _typeService;
        private readonly List<ProductTypeField> _columnMap = CreateColumnMap();

        public TypeSheetFiller(ProductTypeService stepService) => _typeService = stepService;

        public string Name => "Type";

        public List<ProductTypeField> ColumnMap => _columnMap;

        public void Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < _columnMap.Count; i++)
            {
                ProductTypeField column = _columnMap[i];
                row.CreateCell(i).SetCellValue(column.ToString());
            }

            var numberRow = 0;

            foreach (var item in _typeService.GetAll())
            {
                numberRow++;
                row = sheet.CreateRow(numberRow);

                for (int i = 0; i < _columnMap.Count; i++)
                {
                    ProductTypeField column = _columnMap[i];
                    ICell cell = row.CreateCell(i);
                    switch (column)
                    {
                        case ProductTypeField.ID:
                            cell.SetCellValue(item.Id);
                            break;
                        case ProductTypeField.Name:
                            cell.SetCellValue(item.Name);
                            break;
                        case ProductTypeField.CategoryId:
                            cell.SetCellValue(item.CategoryId);
                            break;
                        default:
                            throw new Exception("Unknown field.");
                    }
                }
            }
        }

        private static List<ProductTypeField> CreateColumnMap()
            => ((ProductTypeField[])Enum.GetValues(typeof(ProductTypeField))).ToList();
    }
}
