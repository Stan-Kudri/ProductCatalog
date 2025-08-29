using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductCatalog.Core.Models;
using ProductCatalog.Core.Models.Page;

namespace ProductCatalog.Controls.PageTabControls.Model
{
    public interface IListViewDataProvider
    {
        IReadOnlyList<ListViewColumn> Columns { get; }

        PagedList<Entity> GetPage(Page page);

        Task Remove(Entity entity);

        Entity GetEntity(ListViewItem item);

        Task<bool> Edit(Entity entity);

        Task<bool> Add();
    }
}
