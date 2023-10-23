using System;
using System.Collections.Generic;
using TestTask.Core.Components;

namespace TestTask.ChildForms.StepForm
{
    public class AddItemStepForm : StepFormBase
    {
        public AddItemStepForm(IServiceProvider serviceProvider, List<Mode> modes)
            : base(serviceProvider, modes)
        {
            Text = "Add Step";
        }
    }
}
