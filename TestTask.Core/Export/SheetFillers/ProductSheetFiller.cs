using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Export.SheetFillers
{
    public class ProductSheetFiller : ISheetFiller
    {
        private readonly ProductRepository _productRepository;
        private readonly List<ProductField> _columnMap = CreateColumnMap();

        public ProductSheetFiller(ProductRepository stepService) => _productRepository = stepService;

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

            var allItems = _productRepository.GetAll();
            if (allItems == null || allItems.Count <= 0)
            {
                return;
            }

            foreach (var item in _productRepository.GetAll())
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
                            throw new Exception("Unknown field.");
                    }
                }
            }
        }

        private static List<ProductField> CreateColumnMap()
            => ((ProductField[])Enum.GetValues(typeof(ProductField))).ToList();
    }
}
