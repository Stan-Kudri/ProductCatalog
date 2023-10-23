using System;

namespace TestTask.ChildForms.ModeForm
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
