using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Export.SheetFillers
{
    public class CategorySheetFiller(CategoryRepository categoryRepository)
        : ISheetFiller
    {
        private readonly List<CategoryField> _columnMap = CreateColumnMap();

        public string Name => "Category";

        public List<CategoryField> ColumnMap => _columnMap;

        public async Task Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (var i = 0; i < _columnMap.Count; i++)
            {
                CategoryField column = _columnMap[i];
                row.CreateCell(i).SetCellValue(column.ToString());
            }

            var numberRow = 0;

            var allItems = await categoryRepository.GetAll();
            if (allItems == null || allItems.Count <= 0)
            {
                return;
            }

            foreach (var item in await categoryRepository.GetAll())
            {
                numberRow++;
                row = sheet.CreateRow(numberRow);

                for (var i = 0; i < _columnMap.Count; i++)
                {
                    CategoryField column = _columnMap[i];
                    ICell cell = row.CreateCell(i);
                    switch (column)
                    {
                        case CategoryField.ID:
                            cell.SetCellValue(item.Id);
                            break;
                        case CategoryField.Name:
                            cell.SetCellValue(item.Name);
                            break;
                        default:
                            throw new NotFoundException("Unknown field.");
                    }
                }
            }
        }

        private static List<CategoryField> CreateColumnMap()
            => Enum.GetValues<CategoryField>().ToList();
    }
}
