using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomePage.CustomControls
{
    public partial class MyTextBox : TextBox
    {
        public string PlaceHolder { get; set; }
        public MyTextBox()
        {
            InitializeComponent();
        }
        public bool IsPlaceHolder = true;

        private void MyTextBox_Enter(object sender, EventArgs e)
        {
            if (IsPlaceHolder)
            {
                Text = "";
                ForeColor = Color.Black;
                TextAlign = HorizontalAlignment.Left;
                IsPlaceHolder = false;
            }


        }

        public void Filled()
        {
            IsPlaceHolder = false;
            ForeColor = Color.Black;
            TextAlign = HorizontalAlignment.Left;
            IsPlaceHolder = false;
        }

        private void MyTextBox_Leave(object sender, EventArgs e)
        {
            if (this.TextLength == 0 && string.IsNullOrEmpty(PlaceHolder) == false)
            {
                this.Text = PlaceHolder;
                this.ForeColor = Color.Silver;
                this.TextAlign = HorizontalAlignment.Center;
                this.IsPlaceHolder = true;
            }

        }
    }
}
