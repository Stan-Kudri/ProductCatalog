using TestTask.BindingItem.UserBinding.StepBinding;
using TestTask.Core.Service.Components;

namespace TestTask.ChildForms.StepForm
{
    public class AddItemStepForm : StepForm
    {
        AddItemStepForm(IMessageBox messageBox, SelectMode modes)
            : base(messageBox, modes)
        {
            Text = "Add Step";
        }
    }
}
