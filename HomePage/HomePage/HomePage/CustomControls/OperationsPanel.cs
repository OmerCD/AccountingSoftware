using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
