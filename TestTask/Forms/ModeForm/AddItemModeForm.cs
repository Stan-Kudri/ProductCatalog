using System;

namespace TestTask.Forms.ModeForm
{
    public class AddItemModeForm : ModeFormBase
    {
        public AddItemModeForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Add Mode";
        }

    }
}
