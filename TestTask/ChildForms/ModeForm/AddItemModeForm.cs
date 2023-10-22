using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.ModeForm
{
    public class AddItemModeForm : ModeForm
    {
        public AddItemModeForm(IMessageBox messageBox)
            : base(messageBox)
        {
            Text = "Add Mode";
        }

    }
}
