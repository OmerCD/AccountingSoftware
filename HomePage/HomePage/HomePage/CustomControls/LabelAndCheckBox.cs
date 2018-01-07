using System.Windows.Forms;

namespace HomePage.CustomControls
{
    public partial class LabelAndCheckBox : UserControl, IMainCustomControl
    {
        public LabelAndCheckBox(string text)
        {
            InitializeComponent();
            LacLabel.Text = text;
            LacCheckBox.Text = "";
        }

        public bool IsValidated()
        {
            return true;
        }

        public object Value => LacCheckBox.Checked.ToString();
    }
}
