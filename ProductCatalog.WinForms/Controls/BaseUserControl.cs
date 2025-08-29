using System.ComponentModel;
using System.Windows.Forms;
using MaterialSkin;

namespace ProductCatalog.Controls
{
    public partial class BaseUserControl : UserControl, IMaterialControl
    {

        public BaseUserControl() => InitializeComponent();

        //IMaterialControl item
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Depth { get; set; }

        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MouseState MouseState { get; set; }
    }
}
