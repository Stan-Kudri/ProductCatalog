using System;
using System.Collections.Generic;
using System.Linq;
using NPOI.SS.UserModel;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Companies;

namespace TestTask.Core.Export.SheetFillers
{
    public class CompanySheetFiller : ISheetFiller
    {
        private readonly CompanyRepository _companyRepository;
        private readonly List<CompanyField> _columnMap = CreateColumnMap();

        public CompanySheetFiller(CompanyRepository companyRepository) => _companyRepository = companyRepository;

        public string Name => "Company";

        public List<CompanyField> ColumnMap => _columnMap;

        public void Fill(ISheet sheet)
        {
            IRow row = sheet.CreateRow(0);
            for (int i = 0; i < _columnMap.Count; i++)
            {
                CompanyField column = _columnMap[i];
                row.CreateCell(i).SetCellValue(column.ToString());
            }

            var numberRow = 0;

            var allItems = _companyRepository.GetAll();
            if (allItems == null || allItems.Count <= 0)
            {
                return;
            }

            foreach (var item in _companyRepository.GetAll())
            {
                numberRow++;
                row = sheet.CreateRow(numberRow);

                for (int i = 0; i < _columnMap.Count; i++)
                {
                    CompanyField column = _columnMap[i];
                    ICell cell = row.CreateCell(i);
                    switch (column)
                    {
                        case CompanyField.ID:
                            cell.SetCellValue(item.Id);
                            break;
                        case CompanyField.Name:
                            cell.SetCellValue(item.Name);
                            break;
                        case CompanyField.DateCreation:
                            cell.SetCellValue(item.DateCreation.ToString("d"));
                            break;
                        case CompanyField.Country:
                            cell.SetCellValue(item.Country);
                            break;
                        default:
                            throw new NotFoundException("Unknown field.");
                    }
                }
            }
        }

        private static List<CompanyField> CreateColumnMap()
            => Enum.GetValues<CompanyField>().ToList();
    }
}
