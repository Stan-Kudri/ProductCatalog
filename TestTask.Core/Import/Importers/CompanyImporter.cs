using System.Collections.Generic;
using NPOI.SS.UserModel;
using TestTask.Core.Exeption;
using TestTask.Core.Extension;
using TestTask.Core.Models.Companies;

namespace TestTask.Core.Import.Importers
{
    public class CompanyImporter : IImporter<Company>
    {
        private readonly Dictionary<string, CompanyField> _columnMap = new Dictionary<string, CompanyField>
        {
            ["ID"] = CompanyField.ID,
            ["Name"] = CompanyField.Name,
            ["DateCreation"] = CompanyField.DateCreation,
            ["Country"] = CompanyField.Country,
        };

        private Dictionary<CompanyField, int> _header;

        public bool IsModelSheet(string sheetName) => sheetName == "Company";

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

        public Result<Company> ReadRow(IRow row)
        {
            if (_header == null)
            {
                throw new BusinessLogicException("You should read header");
            }

            if (row.Cells.Count < _header.Count)
            {
                return Result<Company>.CreateFail("Fewer cells than needed", row.RowNum);
            }

            var res = new Company();
            foreach (var pair in _header)
            {
                switch (pair.Key)
                {
                    case CompanyField.ID:

                        var id = row.GetInt(pair.Value, "Id");
                        if (!id.Success)
                        {
                            return id.ToError<Company>();
                        }
                        res.Id = id.Value;
                        break;

                    case CompanyField.Name:

                        var name = row.GetString(pair.Value, "Name");
                        if (!name.Success)
                        {
                            return name.ToError<Company>();
                        }
                        if (string.IsNullOrEmpty(name.Value))
                        {
                            return Result<Company>.CreateFail("Name should not be empty", row.RowNum);
                        }
                        res.Name = name.Value;
                        break;

                    case CompanyField.DateCreation:

                        var dateCreation = row.GetDate(pair.Value, "DateCreation");
                        if (!dateCreation.Success)
                        {
                            return dateCreation.ToError<Company>();
                        }
                        res.DateCreation = dateCreation.Value;
                        break;

                    case CompanyField.Country:

                        var country = row.GetString(pair.Value, "Country");
                        if (!country.Success)
                        {
                            return country.ToError<Company>();
                        }
                        if (string.IsNullOrEmpty(country.Value))
                        {
                            return Result<Company>.CreateFail("Country should not be empty", row.RowNum);
                        }
                        res.Country = country.Value;
                        break;
                }
            }

            return Result<Company>.CreateSuccess(res, row.RowNum);
        }
    }
}
