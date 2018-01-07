using System.Drawing;
using System.Windows.Forms;
using HomePage.Classes.Database.Enums;

namespace HomePage.CustomControls
{
    public partial class OperationsPanel : UserControl
    {
        public OperationsPanel()
        {
            InitializeComponent();
        }

        public void AddComponents(UserTypes usertype)
        {
            Button btn = new Button();
            btn.Size = new Size(this.Width, 100);
            
        }
    }
}
