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
    public partial class LabelAndCombobox : UserControl
    {
        public LabelAndCombobox(CustomAttribute attribute,params object[] items)
        {
            InitializeComponent();
            LacLabel.Text = attribute.FieldName + ':';
            if (items.Length > 0)
            {
                LacComboBox.Items.AddRange(items);
                LacComboBox.SelectedIndex = 0;
            }
        }

        public void Add(object item)
        {
            LacComboBox.Items.Add(item);
        }

        public void SelectBase()
        {
            LacComboBox.SelectedIndex = 0;
        }
    }
}
