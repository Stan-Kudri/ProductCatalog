using System.Linq;
using System.Threading.Tasks;
using ProductCatalog.Core;
using ProductCatalog.Core.Models;

namespace ProductCatalog.WinForms.Messages
{
    public class MessageByTable<TName>(IMessageBox messageBox)
        where TName : Entity
    {
        private readonly string _entityName = typeof(TName).Name;

        public async Task<bool> ShouldNotBeEmpty<T>(IQueryable<T> items)
        {
            if (!items.Any())
            {
                await messageBox.ShowWarning($"No {typeof(T).Name} was found that can be linked to the {_entityName}.");
                return false;
            }

            return true;
        }
    }
}
