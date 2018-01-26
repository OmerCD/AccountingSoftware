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
    public partial class LabelAndMultiControl<T> where T : LabelAndControl, new()
    {
        private readonly Dictionary<string, string> _multiAnswers;
        private readonly dynamic _crudObject;
        private object[] _values;
        public LabelAndMultiControl(CustomAttribute attribute, Dictionary<string, string> multiAnswers = null, dynamic crudObject = null, params object[] values)
        {
            _multiAnswers = multiAnswers;
            _crudObject = crudObject;
            _values = values;
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
            _values = newValue as object[];
        }

        private void ButtonMultiAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new MultiFlowAdd<T, string>(_multiAnswers, _values))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (_multiAnswers == null)
                    {
                        _values = frm.Outputs;
                    }
                    else
                    {
                        _values = GetEntityValues(frm.Outputs);
                    }
                    ButtonMultiAdd.Text = $"Elemanlar ({_values.Length})";
                }
            }
        }

        private object[] GetEntityValues(string[] entityKeys)
        {
            var entities = new object[entityKeys.Length];

            for (int i = 0; i < entityKeys.Length; i++)
            {
                entities[i] = _crudObject.GetOne(entityKeys[i]);
            }
            return entities;
        }
    }
}
