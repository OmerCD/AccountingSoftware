using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.CustomControls;

namespace HomePage.Forms
{
    public partial class CreateForm : Form
    {
        private object _entity;
        public CreateForm(object entity)
        {
            InitializeComponent();
            HandleCreated += CreateForm_HandleCreated;
            _entity = entity;
        }

        private void CreateForm_HandleCreated(object sender, EventArgs e)
        {
            CtnData.SetObject(_entity);
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
