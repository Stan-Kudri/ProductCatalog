using TestTask.Core;

namespace TestTask.Forms.ModeForm
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
