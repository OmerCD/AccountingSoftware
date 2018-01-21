using System.Windows.Forms;
using HomePage.Classes;
using System.Text.RegularExpressions;

namespace HomePage.CustomControls
{
    public partial class LabelAndTextbox
    {
        public LabelAndTextbox()
        {
            InitializeComponent();
            LatTextBox.Filled();
        }
        public LabelAndTextbox(CustomAttribute attribute, bool isFilled)
        {
            InitializeComponent();
            attribute.SetMessages();
            ControlLabel.Text = attribute.FieldName + ':';
            LatTextBox.Text = LatTextBox.PlaceHolder = attribute.PlaceHolderText;
            if (isFilled)
                LatTextBox.Filled();

            if (attribute.IsPassword)
            {
                LatTextBox.PasswordChar = '*';
            }
            _attribute = attribute;
            LatTextBox.MaxLength = attribute.MaxLength;
        }
        private readonly CustomAttribute _attribute;
        public override bool IsValidated()
        {
            bool isOk = true;
            if (_attribute.Nullable && LatTextBox.TextLength == 0)
            {
                return true;
            }
            if (LatTextBox.IsPlaceHolder)
            {
                ErrorLabel.Text = _attribute.MinLengthMessage;
                return false;
            }
            if (LatTextBox.TextLength < _attribute.MinLength)
            {
                ErrorLabel.Text = _attribute.MinLengthMessage;
                isOk = false;
            }
            else if (LatTextBox.TextLength > _attribute.MaxLength)
            {
                ErrorLabel.Text = _attribute.MaxLengthMessage;
                isOk = false;
            }
            else if (string.IsNullOrEmpty(_attribute.RegexPattern) == false)
            {

                if (Regex.Match(LatTextBox.Text, _attribute.RegexPattern).Success == false)
                {
                    ErrorLabel.Text = "Veri " + _attribute.PlaceHolderText + " kuralına uymalıdır";
                    isOk = false;
                }
                else
                {
                    ErrorLabel.Text = "";
                }
            }
            else
            {
                ErrorLabel.Text = "";
            }
            return isOk;
        }

        public override object Value => LatTextBox.Text;
        public override void SetValue(object newValue)
        {
            if (newValue != null)
                LatTextBox.Text = newValue+"";
        }
    }
}
