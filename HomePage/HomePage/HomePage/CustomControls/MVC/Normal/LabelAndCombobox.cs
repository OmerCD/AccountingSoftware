using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HomePage.Classes;

namespace HomePage.CustomControls
{
    public partial class LabelAndCombobox
    {
        private List<string> RealValues { get; set; }

        public ComboBox ComboBox => LacComboBox;

        public LabelAndCombobox(CustomAttribute attribute,params object[] items)
        {
            InitializeComponent();
            ControlLabel.Text = attribute.FieldName + ':';
            RealValues = new List<string>();

            if (items.Length > 0)
            {
                LacComboBox.Items.AddRange(items);
                LacComboBox.SelectedIndex = 0;
            }
        }

        public LabelAndCombobox()
        {
            InitializeComponent();
            RealValues = new List<string>();
        }

        public int SelectedIndex => LacComboBox.SelectedIndex;
        public object GetSelectedId => RealValues[LacComboBox.SelectedIndex];
        public string this[int index] => RealValues[index];
        public void Add(object item,string id)
        {
            RealValues.Add(id);
            LacComboBox.Items.Add(item);
        }

        public void SelectBase()
        {
            LacComboBox.SelectedIndex = 0;
        }

        public override bool IsValidated()
        {
            return true;
        }
        
        public override object Value => LacComboBox.Items[LacComboBox.SelectedIndex].ToString();

        public void SetIndexById(string id)
        {
            LacComboBox.SelectedIndex = RealValues.IndexOf(id);
        }
        public override void SetValue(object newValue)
        {
            try
            {
                ComboBox.SelectedIndex = (int) newValue;
            }
            catch (InvalidCastException)
            {
                var stringValue = newValue.ToString();
                for (int i = 0; i < ComboBox.Items.Count; i++)
                {
                    if (ComboBox.Items[i].ToString() == stringValue)
                    {
                        ComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
