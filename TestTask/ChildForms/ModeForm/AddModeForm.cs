using System;
using System.Windows.Forms;
using TestTask.BindingItem.UserBinding;

namespace TestTask.ChildForms.ModeForm
{
    public partial class AddModeForm : Form
    {
        public AddModeForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (tbNameMode.Text == string.Empty)
            {
                MessageBox.Show("Fill in the field Name", "Information", MessageBoxButtons.OK);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, System.EventArgs e) => DefoultValue();

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void DefoultValue()
        {
            tbNameMode.Text = string.Empty;
            tbMaxUsedType.Text = "0";
            tbMaxBottle.Text = "0";
        }

        private void TbMaxBottle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void TbMaxUsedType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        public ModeModel GetModeModel()
        {
            if (!int.TryParse(tbMaxBottle.Text, out var valueMaxBottle))
            {
                throw new Exception("The MaxBottleNumber field is filled in incorrectly.");
            }

            if (!int.TryParse(tbMaxUsedType.Text, out var valueMaxUsedType))
            {
                throw new Exception("The MaxUsedType field is filled in incorrectly.");
            }

            return new ModeModel(tbNameMode.Text, valueMaxBottle, valueMaxUsedType);
        }
    }
}
