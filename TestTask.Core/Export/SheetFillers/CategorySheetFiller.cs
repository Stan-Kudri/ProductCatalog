using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;

namespace TestTask.Core.Export.SheetFillers
{
    public class CategorySheetFiller : ISheetFiller
    {
        private readonly CategoryService _categoryService;
        private readonly List<CategoryField> _columnMap = CreateColumnMap();

        public CategorySheetFiller(CategoryService categoryService) => _categoryService = categoryService;

        public string Name => "Company";

        public List<CategoryField> ColumnMap => _columnMap;

        public void Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < _columnMap.Count; i++)
            {
                CategoryField column = _columnMap[i];
                row.CreateCell(i).SetCellValue(column.ToString());
            }

            var numberRow = 0;

            foreach (var item in _categoryService.GetAll())
            {
                numberRow++;
                row = sheet.CreateRow(numberRow);

                for (int i = 0; i < _columnMap.Count; i++)
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
                            throw new Exception("Unknown field.");
                    }
                }
            }
        }

        private static List<CategoryField> CreateColumnMap()
            => ((CategoryField[])Enum.GetValues(typeof(CategoryField))).ToList();
    }
}
