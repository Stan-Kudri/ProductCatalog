using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Export.SheetFillers
{
    public class ProductSheetFiller(ProductRepository stepService)
        : ISheetFiller
    {
        private readonly List<ProductField> _columnMap = CreateColumnMap();

        public string Name => "Product";

        public List<ProductField> ColumnMap => _columnMap;

        public async Task Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < _columnMap.Count; i++)
            {
                ProductField column = _columnMap[i];
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
                    ProductField column = _columnMap[i];
                    ICell cell = row.CreateCell(i);
                    switch (column)
                    {
                        case ProductField.ID:
                            cell.SetCellValue(item.Id);
                            break;
                        case ProductField.Name:
                            cell.SetCellValue(item.Name);
                            break;
                        case ProductField.CompanyId:
                            cell.SetCellValue(item.CompanyId);
                            break;
                        case ProductField.CategoryId:
                            cell.SetCellValue(item.CategoryId);
                            break;
                        case ProductField.TypeId:
                            cell.SetCellValue(item.TypeId);
                            break;
                        case ProductField.Price:
                            var price = Convert.ToDouble(item.Price);
                            cell.SetCellValue(price);
                            break;
                        case ProductField.Destination:
                            cell.SetCellValue(item.Destination);
                            break;
                        default:
                            throw new NotFoundException("Unknown field.");
                    }
                }
            }
        }

        private static List<ProductField> CreateColumnMap()
            => Enum.GetValues<ProductField>().ToList();
    }
}
