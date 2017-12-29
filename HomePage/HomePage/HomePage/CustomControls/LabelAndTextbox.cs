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
    public partial class LabelAndTextbox : UserControl,IMainCustomControl
    {

        public LabelAndTextbox(CustomAttribute attribute)
        {
            InitializeComponent();
            attribute.SetMessages();
            LatLabel.Text = attribute.FieldName + ':';
            LatTextBox.Text = LatTextBox.PlaceHolder = attribute.PlaceHolderText;

            if (attribute.IsPassword)
            {
                LatTextBox.PasswordChar = '*';
            }
            _attribute = attribute;
            LatTextBox.MaxLength = attribute.MaxLength;
        }
        private readonly CustomAttribute _attribute;
        public bool IsValidated()
        {
            bool isOk = true;
            if (LatTextBox.TextLength < _attribute.MinLength)
            {
                LatErrorLabel.Text = _attribute.MinLengthMessage;
                isOk = false;
            }
            else if (LatTextBox.TextLength > _attribute.MaxLength)
            {
                LatErrorLabel.Text = _attribute.MaxLengthMessage;
                isOk = false;
            }
            else if (string.IsNullOrEmpty(_attribute.RegexPattern) == false)
            {

                if (Regex.Match(LatTextBox.Text, _attribute.RegexPattern).Success == false)
                {
                    LatErrorLabel.Text = "Veri " + _attribute.PlaceHolderText + " kuralına uymalıdır";
                    isOk = false;
                }
                else
                {
                    LatErrorLabel.Text = "";
                }
            }
            else
            {
                LatErrorLabel.Text = "";
            }
            return isOk;
        }


        public object Value => LatTextBox.Text;
    }
}
