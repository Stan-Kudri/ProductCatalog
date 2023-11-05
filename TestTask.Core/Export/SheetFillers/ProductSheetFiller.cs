using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Export.SheetFillers
{
    public class ProductSheetFiller : ISheetFiller
    {
        private readonly ProductService _productService;
        private readonly List<ProductField> _columnMap = CreateColumnMap();

        public ProductSheetFiller(ProductService stepService) => _productService = stepService;

        public string Name => "Product";

        public List<ProductField> ColumnMap => _columnMap;

        public void Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < _columnMap.Count; i++)
            {
                ProductField column = _columnMap[i];
                row.CreateCell(i).SetCellValue(column.ToString());
            }

            var numberRow = 0;

            foreach (var item in _productService.GetAll())
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
                        case ProductField.CompanyId:
                            cell.SetCellValue(item.CompanyId);
                            break;
                        case ProductField.Category:
                            cell.SetCellValue(item.Category);
                            break;
                        case ProductField.Type:
                            cell.SetCellValue(item.Type);
                            break;
                        case ProductField.Price:
                            var price = Convert.ToDouble(item.Price);
                            cell.SetCellValue(price);
                            break;
                        case ProductField.Destination:
                            cell.SetCellValue(item.Destination);
                            break;
                        default:
                            throw new Exception("Unknown field.");
                    }
                }
            }
        }

        private static List<ProductField> CreateColumnMap()
        {
            var columnMap = new List<ProductField>();
            foreach (ProductField suit in (ProductField[])Enum.GetValues(typeof(ProductField)))
            {
                columnMap.Add(suit);
            }

            return columnMap;
        }
    }
}
