using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database.Entities;

namespace HomePage.CustomControls.MVC
{
    public partial class MultiFlowAdd<TControl, TOutput> : Form where TControl : LabelAndControl, new()
    {
        private readonly Dictionary<TOutput, string> _multiAnswers;
        private readonly object[] _values;
        private int _lastIndex = -1;
        private readonly List<LabelAndControl> _controls;
        private List<TOutput> _list;

        public TOutput[] Outputs => _list.ToArray();

        public MultiFlowAdd(Dictionary<TOutput, string> multiAnswers = null, params object[] values)
        {
            _multiAnswers = multiAnswers;
            _values = values;
            _controls = new List<LabelAndControl>();
            InitializeComponent();

            SetupFields(values);
        }

        private void SetupFields(IReadOnlyCollection<object> values)
        {
            if (values == null || values.Count == 0)
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
            ComboBoxControl(control, value);
            if (_multiAnswers == null)
                control.SetValue(value);

            PanelControls.Controls.Add(control);
        }

        private void ComboBoxControl(LabelAndControl control, object value = null)
        {
            if (_multiAnswers != null)
            {
                var labControl = ((LabelAndCombobox)control);
                foreach (var pair in _multiAnswers)
                {
                    labControl.Add(pair.Value, pair.Key.ToString());
                }
                if (value == null)
                    labControl.SelectBase();
                if (value != null)
                {
                    labControl.SetIndexById(((DbObject)value)._id);
                    if (labControl.SelectedIndex==-1)
                    {
                        labControl.SelectBase();
                    }
                }
            }
        }

        private void AddSingleControl()
        {
            var control = GetNewControl();
            ComboBoxControl(control);
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
            _list = GetSelectedValues();
            DialogResult = DialogResult.OK;
            Close();
        }

        private List<TOutput> GetSelectedValues()
        {
            var list = new List<TOutput>();
            foreach (var control in _controls)
            {
                TOutput value;
                if (_multiAnswers != null)
                {
                    value = (TOutput)((LabelAndCombobox)control).GetSelectedId;
                }
                else
                {
                    value = (TOutput)control.Value;
                }
                if (value != null)
                    list.Add(value);
            }
            return list;
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
