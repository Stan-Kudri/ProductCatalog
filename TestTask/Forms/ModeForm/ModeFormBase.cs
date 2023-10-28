using System;
using System.Windows.Forms;
using TestTask.BindingItem.UserBinding;
using TestTask.Core;

namespace TestTask.Forms.ModeForm
{
    public partial class ModeFormBase : BaseForm
    {
        protected readonly IMessageBox _messageBox;

        private ModeFormBase()
        {
            InitializeComponent();
        }

        public ModeFormBase(IMessageBox messageBox)
        {
            InitializeComponent();
            _messageBox = messageBox;
        }

        protected virtual void BtnSave_Click(object sender, EventArgs e)
        {
            if (tbNameMode.Text == string.Empty)
            {
                _messageBox.ShowWarning("Fill in the field Name");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, EventArgs e) => DefaultValue();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected virtual void AddModeForm_Load(object sender, EventArgs e) => DefaultValue();

        protected virtual void DefaultValue()
        {
            tbNameMode.Text = string.Empty;
            tbMaxUsedTips.Text = "0";
            tbMaxBottle.Text = "0";
        }

        private void TbMaxBottle_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        private void TbMaxUsedType_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        public ModeModel GetModeModel()
        {
            if (!int.TryParse(tbMaxBottle.Text, out var valueMaxBottle))
            {
                throw new Exception("The MaxBottleNumber field is filled in incorrectly.");
            }

            if (!int.TryParse(tbMaxUsedTips.Text, out var valueMaxUsedType))
            {
                throw new Exception("The MaxUsedType field is filled in incorrectly.");
            }

            return new ModeModel(tbNameMode.Text, valueMaxBottle, valueMaxUsedType);
        }

        private void KeyPressDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
