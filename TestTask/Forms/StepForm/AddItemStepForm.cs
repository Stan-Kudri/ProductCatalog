using System.Collections.Generic;
using TestTask.Core;
using TestTask.Core.Models.Modes;

namespace TestTask.Forms.StepForm
{
    public class AddItemStepForm : StepFormBase
    {
        public AddItemStepForm(IMessageBox messageBox, List<Mode> modes)
            : base(messageBox, modes)
        {
            Text = "Add Step";
        }
    }
}
