using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Types;

namespace TestTask.Core.Export.SheetFillers
{
    public class TypeSheetFiller(ProductTypeRepository stepService)
        : ISheetFiller
    {
        private readonly List<ProductTypeField> _columnMap = CreateColumnMap();

        public string Name => "Type";

        public List<ProductTypeField> ColumnMap => _columnMap;

        public async Task Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < _columnMap.Count; i++)
            {
                ProductTypeField column = _columnMap[i];
                row.CreateCell(i).SetCellValue(column.ToString());
            }

            var numberRow = 0;

            var allItems = await stepService.GetAll();
            if (allItems == null || allItems.Count <= 0)
            {
                return;
            }

            foreach (var item in await stepService.GetAll())
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
                            throw new NotFoundException("Unknown field.");
                    }
                }
            }
        }

        private static List<ProductTypeField> CreateColumnMap()
            => Enum.GetValues<ProductTypeField>().ToList();
    }
}
