using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Core;
using TestTask.Core.DataTable;
using TestTask.Core.Extension;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;

namespace TestTask.Model
{
    public class ExcelImporterModel
    {
        private const string Company = "Company";
        private const string Product = "Product";
        private const string Category = "Category";
        private const string Type = "Type";

        private readonly IMessageBox _messageBox;

        private readonly CompanyRepository _companyRepository;
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductTypeRepository _typeRepository;

        private readonly ExcelImporter<Company> _excelImportCompany;
        private readonly ExcelImporter<Category> _excelImportCategory;
        private readonly ExcelImporter<ProductType> _excelImportTypeProduct;
        private readonly ExcelImporter<Product> _excelImportProduct;

        public ExcelImporterModel(IMessageBox messageBox,
                                  CompanyRepository companyRepository,
                                  ProductRepository productRepository,
                                  CategoryRepository categoryRepository,
                                  ProductTypeRepository typeRepository,
                                  ExcelImporter<Company> excelImportCompany,
                                  ExcelImporter<Category> excelImportCategory,
                                  ExcelImporter<ProductType> excelImportTypeProduct,
                                  ExcelImporter<Product> excelImportProduct)
        {
            _messageBox = messageBox;
            _companyRepository = companyRepository;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _typeRepository = typeRepository;
            _excelImportCompany = excelImportCompany;
            _excelImportCategory = excelImportCategory;
            _excelImportTypeProduct = excelImportTypeProduct;
            _excelImportProduct = excelImportProduct;
        }

        public async Task UpsertData(HashSet<Tables> selectTable, string path)
        {
            if (selectTable.Contains(Tables.Company))
            {
                var companyRead = _excelImportCompany.ImportFromFile(path);

                foreach (var item in companyRead)
                {
                    if (item.Success)
                    {
                        _companyRepository.Upsert(item.Value);
                    }
                }

                if (!companyRead.IsNoErrorLine(out var message))
                {
                    await _messageBox.ShowWarning(message, Company);
                }
            }
            if (selectTable.Contains(Tables.Category))
            {
                var companyRead = _excelImportCategory.ImportFromFile(path);

                foreach (var item in companyRead)
                {
                    if (item.Success)
                    {
                        _categoryRepository.Upsert(item.Value);
                    }
                }

                if (!companyRead.IsNoErrorLine(out var message))
                {
                    await _messageBox.ShowWarning(message, Category);
                }
            }

            if (selectTable.Contains(Tables.TypeProduct))
            {
                var typeRead = _excelImportTypeProduct.ImportFromFile(path);

                foreach (var item in typeRead)
                {
                    if (item.Success)
                    {
                        _typeRepository.Upsert(item.Value);
                    }
                }

                if (!typeRead.IsNoErrorLine(out var message))
                {
                    await _messageBox.ShowWarning(message, Type);
                }
            }

            if (selectTable.Contains(Tables.Product))
            {
                var productRead = _excelImportProduct.ImportFromFile(path);

                foreach (var item in productRead)
                {
                    if (item.Success)
                    {
                        _productRepository.Upsert(item.Value);
                    }
                }

                if (!productRead.IsNoErrorLine(out var message))
                {
                    await _messageBox.ShowWarning(message, Product);
                }
            }
        }
    }
}
