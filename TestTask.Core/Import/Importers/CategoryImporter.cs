using System.Collections.Generic;
using NPOI.SS.UserModel;
using TestTask.Core.Exeption;
using TestTask.Core.Extension;
using TestTask.Core.Models.Categories;

namespace TestTask.Core.Import.Importers
{
    public class CategoryImporter : IImporter<Category>
    {
        private readonly Dictionary<string, CategoryField> _columnMap = new Dictionary<string, CategoryField>
        {
            ["ID"] = CategoryField.ID,
            ["Name"] = CategoryField.Name,
        };

        private Dictionary<CategoryField, int> _header;

        public bool IsModelSheet(string sheetName) => sheetName == "Category";

        public bool ReadHeader(ISheet sheet)
        {
            try
            {
                _header = sheet.ReadHeader(_columnMap);
                return true;
            }
            catch
            {
                _header = null;
                return false;
            }
        }

        public Result<Category> ReadRow(IRow row)
        {
            if (_header == null)
            {
                throw new BusinessLogicException("You should read header");
            }

            if (row.Cells.Count < _header.Count)
            {
                return Result<Category>.CreateFail("Fewer cells than needed", row.RowNum);
            }

            var res = new Category();
            foreach (var pair in _header)
            {
                switch (pair.Key)
                {
                    case CategoryField.ID:

                        var id = row.GetInt(pair.Value, "Id");
                        if (!id.Success)
                        {
                            return id.ToError<Category>();
                        }
                        res.Id = id.Value;
                        break;

                    case CategoryField.Name:

                        var name = row.GetString(pair.Value, "Name");
                        if (!name.Success)
                        {
                            return name.ToError<Category>();
                        }
                        if (string.IsNullOrEmpty(name.Value))
                        {
                            return Result<Category>.CreateFail("Name should not be empty", row.RowNum);
                        }
                        res.Name = name.Value;
                        break;
                }

            }

            return Result<Category>.CreateSuccess(res, row.RowNum);
        }
    }
}
