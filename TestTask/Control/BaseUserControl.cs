using MaterialSkin;
using System.Windows.Forms;

namespace TestTask.Control
{
    public partial class BaseUserControl : UserControl, IMaterialControl
    {
        public BaseUserControl() => InitializeComponent();

        //IMaterialControl item
        public int Depth { get; set; }

        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        public MouseState MouseState { get; set; }
    }
}
