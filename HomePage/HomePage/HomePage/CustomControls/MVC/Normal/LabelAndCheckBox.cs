using System.Windows.Forms;

namespace HomePage.CustomControls
{
    public partial class LabelAndCheckBox
    {
        public LabelAndCheckBox(string text)
        {
            InitializeComponent();
            ControlLabel.Text = text;
            LacCheckBox.Text = "";
        }

        public override bool IsValidated()
        {
            return true;
        }

        public override object Value => LacCheckBox.Checked;
        public override void SetValue(object newValue)
        {
            LacCheckBox.Checked = (bool) newValue;
        }
    }
}
