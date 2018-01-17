using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.CustomControls.MVC
{
    public partial class MultiFlowAdd<TControl, TOutput> : Form where TControl : LabelAndControl, new()
    {
        private readonly object[] _values;
        private int _lastIndex = -1;
        private readonly List<LabelAndControl> _controls;
        private List<TOutput> _list;

        public TOutput[] Outputs => _list.ToArray();

        public MultiFlowAdd(params object[] values)
        {
            _values = values;
            _controls = new List<LabelAndControl>();
            InitializeComponent();

            SetupFields(values);
        }

        private void SetupFields(IReadOnlyCollection<object> values)
        {
            if (values==null || values.Count == 0)
            {
                AddSingleControl();
            }
            else if (values.Count > 0)
            {
                foreach (var value in values)
                {
                    AddSingleControl(value);
                }
            }
        }

        private void AddSingleControl(object value)
        {
            var control = GetNewControl();
            control.SetValue(value);
            PanelControls.Controls.Add(control);
        }
        private void AddSingleControl()
        {
            var control = GetNewControl();
            PanelControls.Controls.Add(control);
        }
        private void ButtonAddField_Click(object sender, EventArgs e)
        {
            AddSingleControl();
        }
        private void ButtonRemoveField_Click(object sender, EventArgs e)
        {
            if (_controls.Count != 0)
            {
                RemoveLastControl();
            }
        }

        private void RemoveLastControl()
        {
            var controlToRemove = _controls[_lastIndex];
            PanelControls.Controls.Remove(controlToRemove);
            _controls.RemoveAt(_lastIndex--);
        }

        private LabelAndControl GetNewControl(string labelText = null)
        {
            var control = new TControl() as LabelAndControl;

            control.Name = "Control" + _lastIndex;
            control.Text = labelText ?? ("Eleman " + (_lastIndex + 2));
            _lastIndex++;
            _controls.Add(control);
            return control;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            _list = new List<TOutput>();
            foreach (var control in _controls)
            {
                var value = (TOutput)control.Value;
                if (value != null)
                    _list.Add(value);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonRemoveAll_Click(object sender, EventArgs e)
        {
            RemoveAllControls();
        }

        private void RemoveAllControls()
        {
            PanelControls.Controls.Clear();
            _controls.Clear();
            _lastIndex = -1;
        }

        private void ButtonRevert_Click(object sender, EventArgs e)
        {
            RemoveAllControls();
            if (_values.Length > 0)
            {
                foreach (var value in _values)
                {
                    AddSingleControl(value);
                }
            }
        }
    }
}
