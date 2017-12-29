using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes;
using System.Text.RegularExpressions;

namespace HomePage.CustomControls
{
    public partial class LabelAndDatePicker : UserControl,IMainCustomControl
    {
        public LabelAndDatePicker(CustomAttribute attribute)
        {
            InitializeComponent();
            attribute.SetMessages();
            LadLabel.Text = attribute.FieldName + ":";

            _attribute = attribute;
       
        }

        private CustomAttribute _attribute;
        public bool IsValidated()
        {
            return true;
        }


        public object Value => LadDtp.Value.ToLongDateString();
    }
}
