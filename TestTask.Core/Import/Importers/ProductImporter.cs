using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using TestTask.Core.Extension;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Import.Importers
{
    public class ProductImporter : IImporter<Product>
    {
        private readonly Dictionary<string, ProductField> _columnMap = new Dictionary<string, ProductField>
        {
            ["ID"] = ProductField.ID,
            ["CompanyId"] = ProductField.CompanyId,
            ["Category"] = ProductField.Category,
            ["Type"] = ProductField.Type,
            ["Price"] = ProductField.Price,
            ["Destination"] = ProductField.Destination,
        };

        private Dictionary<ProductField, int> _header;

        public bool IsModelSheet(string sheetName) => sheetName == "Product";

        public bool ReadHeader(ISheet sheet)
        {
            _header = null;
            try
            {
                _header = sheet.ReadHeader(_columnMap);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Result<Product> ReadRow(IRow row)
        {
            if (_header == null)
            {
                throw new Exception("You should read header");
            }

            if (row.Cells.Count < _header.Count)
            {
                return Result<Product>.CreateFail("Fewer cells than needed", row.RowNum);
            }

            var res = new Product();
            foreach (var pair in _header)
            {
                switch (pair.Key)
                {
                    case ProductField.ID:

                        var id = row.GetInt(pair.Value, "Id");
                        if (!id.Success)
                        {
                            return id.ToError<Product>();
                        }
                        res.Id = id.Value;
                        break;

                    case ProductField.CompanyId:

                        var companyId = row.GetInt(pair.Value, "CompanyId");
                        if (!companyId.Success)
                        {
                            return companyId.ToError<Product>();
                        }
                        res.CompanyId = companyId.Value;
                        break;

                    case ProductField.Category:

                        var category = row.GetString(pair.Value, "Category");
                        if (!category.Success)
                        {
                            return category.ToError<Product>();
                        }
                        if (string.IsNullOrEmpty(category.Value))
                        {
                            return Result<Product>.CreateFail("Category should not be empty", row.RowNum);
                        }
                        res.Category = category.Value;
                        break;

                    case ProductField.Type:

                        var type = row.GetString(pair.Value, "Type");
                        if (!type.Success)
                        {
                            return type.ToError<Product>();
                        }
                        if (string.IsNullOrEmpty(type.Value))
                        {
                            return Result<Product>.CreateFail("Type should not be empty", row.RowNum);
                        }
                        res.Type = type.Value;
                        break;

                    case ProductField.Price:

                        var price = row.GetDecimal(pair.Value, "Price");
                        if (!price.Success)
                        {
                            return price.ToError<Product>();
                        }
                        res.Price = price.Value;
                        break;

                    case ProductField.Destination:

                        var destination = row.GetString(pair.Value, "Destination");
                        if (!destination.Success)
                        {
                            return destination.ToError<Product>();
                        }
                        if (string.IsNullOrEmpty(destination.Value))
                        {
                            res.Destination = null;
                        }
                        res.Destination = destination.Value;
                        break;
                }

            }

            return Result<Product>.CreateSuccess(res, row.RowNum);
        }
    }
}
