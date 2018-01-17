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

namespace HomePage.CustomControls.MVC
{
    public partial class LabelAndMultiTextBox
    {
        private string[] _values;

        public LabelAndMultiTextBox(CustomAttribute attribute, params string[] valueStrings)
        {
            _values = valueStrings;
            InitializeComponent();
            ControlLabel.Text = attribute.FieldName;
            ButtonMultiAdd.Text = $"Elemanlar ({_values?.Length ?? 0})";
        }

        public override bool IsValidated()
        {
            return true;
        }

        public override object Value => _values;
        public override void SetValue(object newValue)
        {
            _values = (string[])newValue;
        }

        private void ButtonMultiAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new MultiFlowAdd<LabelAndTextbox, string>(_values))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _values = frm.Outputs;
                    ButtonMultiAdd.Text = $"Elemanlar ({_values.Length})";
                }
            }
        }
    }
}
