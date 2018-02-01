using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.CustomControls.ContextMenu
{
    public partial class PopedContainer : UserControl
    {
        public PopedContainer()
        {
            InitializeComponent();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((keyData & Keys.Alt) == Keys.Alt)
                if ((keyData & Keys.F4) == Keys.F4)
                {
                    this.Parent.Hide();
                    return true;
                }

            if ((keyData & Keys.Enter) == Keys.Enter)
            {
                var button = ActiveControl as Button;
                if (button != null)
                {
                    button.PerformClick();
                    return true;
                }
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
