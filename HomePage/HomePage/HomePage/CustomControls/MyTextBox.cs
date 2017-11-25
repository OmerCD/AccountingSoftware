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
     public partial class MyTextBox : TextBox
    {
        public string PlaceHolder { get; set; }
        public MyTextBox()
        {
            InitializeComponent();
        }
       public bool _isPlaceHolder = true;
        public  void MyTextBox_Enter(object sender, EventArgs e)
        {
            if (_isPlaceHolder == true)
            {
                (sender as TextBox).Text = "";
                (sender as TextBox).ForeColor = Color.Black;
                (sender as TextBox).TextAlign = HorizontalAlignment.Left;
                _isPlaceHolder = false;
            }
            

        }

        public void MyTextBox_Leave(object sender, EventArgs e)
        {
            if (this.TextLength == 0 && string.IsNullOrEmpty(PlaceHolder) == false)
            {
                this.Text = PlaceHolder;
                this.ForeColor = Color.Silver;
                this.TextAlign = HorizontalAlignment.Center;
                this._isPlaceHolder = true; 
            }
        
         }
    }
}
