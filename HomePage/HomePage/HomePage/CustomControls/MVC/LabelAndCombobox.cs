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

        public int SelectedIndex => LacComboBox.SelectedIndex;
        public string GetSelectedId => RealValues[LacComboBox.SelectedIndex];
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
        public override void SetValue(object newValue)
        {
            ComboBox.SelectedIndex = (int) newValue;
        }
    }
}
