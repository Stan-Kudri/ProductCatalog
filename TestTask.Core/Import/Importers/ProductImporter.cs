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
            ["Name"] = ProductField.Name,
            ["CompanyId"] = ProductField.CompanyId,
            ["CategoryId"] = ProductField.CategoryId,
            ["TypeId"] = ProductField.TypeId,
            ["Price"] = ProductField.Price,
            ["Destination"] = ProductField.Destination,
        };

        private Dictionary<ProductField, int> _header;

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

                    case ProductField.Name:

                        var name = row.GetString(pair.Value, "Name");
                        if (!name.Success)
                        {
                            return name.ToError<Product>();
                        }
                        res.Name = name.Value;
                        break;

                    case ProductField.CompanyId:

                        var companyId = row.GetInt(pair.Value, "CompanyId");
                        if (!companyId.Success)
                        {
                            return companyId.ToError<Product>();
                        }
                        res.CompanyId = companyId.Value;
                        break;

                    case ProductField.CategoryId:

                        var categoryId = row.GetInt(pair.Value, "CategoryId");
                        if (!categoryId.Success)
                        {
                            return categoryId.ToError<Product>();
                        }
                        res.CategoryId = categoryId.Value;
                        break;

                    case ProductField.TypeId:

                        var typeId = row.GetInt(pair.Value, "TypeId");
                        if (!typeId.Success)
                        {
                            return typeId.ToError<Product>();
                        }
                        res.TypeId = typeId.Value;
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
