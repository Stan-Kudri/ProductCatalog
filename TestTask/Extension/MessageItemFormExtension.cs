using System.Linq;
using TestTask.Core;

namespace TestTask.Extension
{
    public static class MessageItemFormExtension
    {
        public static bool ShouldNotBeEmpty<T>(this IMessageBox messageBox, IQueryable<T> items, string entityName)
        {
            if (items.Count() == 0)
            {
                messageBox.ShowWarning($"No {typeof(T).Name} was found that can be linked to the {entityName}.");
                return false;
            }

            return true;
        }
    }
}
