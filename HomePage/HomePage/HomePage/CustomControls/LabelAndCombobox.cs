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

namespace HomePage.CustomControls
{
    public partial class LabelAndCombobox : UserControl,IMainCustomControl
    {
        public List<string> RealValues { get; set; }

        public ComboBox ComboBox => LacComboBox;

        public LabelAndCombobox(CustomAttribute attribute,params object[] items)
        {
            InitializeComponent();
            LacLabel.Text = attribute.FieldName + ':';
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

        public bool IsValidated()
        {
            return true;
        }

        public object Value => LacComboBox.Items[LacComboBox.SelectedIndex].ToString();
    }
}
