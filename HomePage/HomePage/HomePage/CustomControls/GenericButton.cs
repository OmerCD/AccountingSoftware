using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.CustomControls
{
    public partial class GenericButton : UserControl
    {
        public event Action<object, EventArgs> ClickEvent;

        public string ButtonText
        {
            get => LabelText.Text;
            set
            {
                LabelText.Text = value;
                var middle = this.Width / 2;
                LabelText.Location = new Point(middle-(LabelText.Width/2),LabelText.Location.Y);
            }
        }

        public Image ButtonImage
        {
            get => ButtonGeneric.BackgroundImage;
            set => ButtonGeneric.BackgroundImage = value;
        }
        public GenericButton()
        {
            InitializeComponent();
        }

        private void ButtonGeneric_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
        }
    }
}
