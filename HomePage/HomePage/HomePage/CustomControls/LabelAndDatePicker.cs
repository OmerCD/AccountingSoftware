using System;
using System.Windows.Forms;
using HomePage.Classes;

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


        public DateTime Value
        {
            get => LadDtp.Value;
            set
            {
                if (value<LadDtp.MinDate)
                {
                    LadDtp.Value = LadDtp.MinDate;
                }
                else if (value > LadDtp.MaxDate)
                {
                    LadDtp.Value = LadDtp.MaxDate;
                }
                else
                {
                    LadDtp.Value = value;
                }

            }
        }

        object IMainCustomControl.Value => LadDtp.Value.ToLongDateString();
    }
}
