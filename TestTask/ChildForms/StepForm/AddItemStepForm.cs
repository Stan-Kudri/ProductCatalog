using System.Collections.Generic;
using TestTask.Core.Components;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.StepForm
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
