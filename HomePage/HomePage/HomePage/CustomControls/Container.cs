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
    public partial class Container : UserControl
    {
        public Container()
        {
            InitializeComponent();
           
        }
        public int _lastY = 0;
        public void Add(Control userControl)
        {
            userControl.Location = new Point(userControl.Location.X, _lastY);
            this.Controls.Add(userControl);
            _lastY += userControl.Size.Height + 10;

        }
        public void LocateButton()
        {
            this.Size = new Size(this.Width, this.Height + 35);
            this.ContainerButton.Location = new Point(this.ContainerButton.Location.X, this._lastY);


        }
    }
}
