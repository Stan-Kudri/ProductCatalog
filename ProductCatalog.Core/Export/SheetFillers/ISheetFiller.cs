using System.Threading.Tasks;
using NPOI.SS.UserModel;

namespace ProductCatalog.Core.Export.SheetFillers
{
    public interface ISheetFiller
    {
        string Name { get; }

        Task Fill(ISheet sheet);
    }
}
