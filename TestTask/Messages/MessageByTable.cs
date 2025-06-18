using System.Linq;
using System.Threading.Tasks;
using TestTask.Core;
using TestTask.Core.Models;

namespace TestTask.Messages
{
    public class MessageByTable<TName>
        where TName : Entity
    {
        private readonly IMessageBox _messageBox;
        private readonly string _entityName;

        public MessageByTable(IMessageBox messageBox)
        {
            _messageBox = messageBox;
            _entityName = typeof(TName).Name;
        }

        public async Task<bool> ShouldNotBeEmpty<T>(IQueryable<T> items)
        {
            if (!items.Any())
            {
                await _messageBox.ShowWarning($"No {typeof(T).Name} was found that can be linked to the {_entityName}.");
                return false;
            }

            return true;
        }
    }
}
