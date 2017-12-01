using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.CustomControls;

namespace HomePage.Forms
{
    public partial class CreateForm : Form
    {
        public CreateForm(object entity)
        {
            InitializeComponent();
            var task = CtnData.SetObject(entity);
            //task.ConfigureAwait(true);
            CtnData.ButtonText = "Veri Ekle";
            CtnData.ClickEvent = ButtonClick;
            var size = new Size(CtnData.Size.Width, CtnData.Size.Height);
            this.Size = size;
            this.MaximumSize = size;
            this.MinimumSize = size;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Yeey");
        }
    }
}
