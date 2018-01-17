using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.CustomControls.MVC
{
    public partial class LabelAndControl : UserControl, IMainCustomControl
    {
        public LabelAndControl()
        {
            InitializeComponent();
        }
        public virtual object Value { get; }
        public virtual void SetValue(object newValue)
        {

        }

        public virtual bool IsValidated()
        {
            return true;
        }
        public override string Text { get => ControlLabel.Text; set => ControlLabel.Text = value; }
    }
}
