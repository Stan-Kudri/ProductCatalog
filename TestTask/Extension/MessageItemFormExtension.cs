using System.Linq;
using System.Threading.Tasks;
using TestTask.Core;

namespace TestTask.Extension
{
    public static class MessageItemFormExtension
    {
        public static async Task<bool> ShouldNotBeEmpty<T>(this IMessageBox messageBox, IQueryable<T> items, string entityName)
        {
            if (items.Count() == 0)
            {
                await messageBox.ShowWarning($"No {typeof(T).Name} was found that can be linked to the {entityName}.");
                return false;
            }

            return true;
        }
    }
}
