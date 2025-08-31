using ProductCatalog.WinForms.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCatalog.WinForms.Extension
{
    public static class FormShowDialogResultExtension
    {
        // Implementation of safe ShowDialogAsync
        public static async Task<DialogResult> FormShowDialogAsync(this BaseForm form)
        {
            var tcs = new TaskCompletionSource<DialogResult>();

            form.FormClosed += (s, e) =>
            {
                tcs.TrySetResult(form.DialogResult);
            };

            if (form.InvokeRequired)
            {
                // Asynchronous call on UI thread
                await form.InvokeAsync(() => form.ShowDialog());
            }
            else
            {
#pragma warning disable CA1849 // Call async methods when in an async method
                form.ShowDialog();
#pragma warning restore CA1849 // Call async methods when in an async method
            }

            return await tcs.Task;
        }
    }
}
