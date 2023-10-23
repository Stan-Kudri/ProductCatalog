using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.ModeForm
{
    public class AddItemModeForm : ModeFormBase
    {
        public AddItemModeForm(IMessageBox messageBox)
            : base(messageBox)
        {
            Text = "Add Mode";
        }

    }
}
