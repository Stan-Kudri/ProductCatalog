using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using TestTask.Core.Extension;
using TestTask.Core.Models.Types;

namespace TestTask.Core.Import.Importers
{
    public class TypeProductImporter : IImporter<ProductType>
    {
        private readonly Dictionary<string, ProductTypeField> _columnMap = new Dictionary<string, ProductTypeField>
        {
            ["ID"] = ProductTypeField.ID,
            ["Name"] = ProductTypeField.Name,
            ["CategoryId"] = ProductTypeField.CategoryId,
        };

        private Dictionary<ProductTypeField, int> _header;

        public bool IsModelSheet(string sheetName) => sheetName == "Product";

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

        public Result<ProductType> ReadRow(IRow row)
        {
            if (_header == null)
            {
                throw new Exception("You should read header");
            }

            if (row.Cells.Count < _header.Count)
            {
                return Result<ProductType>.CreateFail("Fewer cells than needed", row.RowNum);
            }

            var res = new ProductType();
            foreach (var pair in _header)
            {
                switch (pair.Key)
                {
                    case ProductTypeField.ID:

                        var id = row.GetInt(pair.Value, "Id");
                        if (!id.Success)
                        {
                            return id.ToError<ProductType>();
                        }
                        res.Id = id.Value;
                        break;

                    case ProductTypeField.Name:

                        var name = row.GetString(pair.Value, "Name");
                        if (!name.Success)
                        {
                            return name.ToError<ProductType>();
                        }
                        if (string.IsNullOrEmpty(name.Value))
                        {
                            return Result<ProductType>.CreateFail("Name should not be empty", row.RowNum);
                        }
                        res.Name = name.Value;
                        break;

                    case ProductTypeField.CategoryId:

                        var categoryId = row.GetInt(pair.Value, "CategoryId");
                        if (!categoryId.Success)
                        {
                            return categoryId.ToError<ProductType>();
                        }
                        res.CategoryId = categoryId.Value;
                        break;
                }

            }

            return Result<ProductType>.CreateSuccess(res, row.RowNum);
        }
    }
}
