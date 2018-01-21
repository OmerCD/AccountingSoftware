using System;
using System.Windows.Forms;
using HomePage.Classes;

namespace HomePage.CustomControls
{
    public partial class LabelAndDatePicker
    {
        public LabelAndDatePicker(CustomAttribute attribute)
        {
            InitializeComponent();
            attribute.SetMessages();
            ControlLabel.Text = attribute.FieldName + ":";

            _attribute = attribute;
       
        }

        private CustomAttribute _attribute;
        public override bool IsValidated()
        {
            return true;
        }


        public DateTime DateValue
        {
            get => DateTime.SpecifyKind(LadDtp.Value, DateTimeKind.Utc);
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

        public override object Value => DateTime.SpecifyKind(LadDtp.Value, DateTimeKind.Utc);
    }
}
