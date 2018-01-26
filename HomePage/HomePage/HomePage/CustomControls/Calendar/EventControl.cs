using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database.Entities;

namespace HomePage.CustomControls.Calendar
{
    public partial class EventControl : UserControl
    {
        public event Action<object, EventArgs, string> EventClick; 
        public string EventId { get; }
        public EventControl(Color backColor, Color foreColor, Event eventInfo)
        {
            InitializeComponent();
            lblEventName.BackColor = BackColor = backColor;
            lblEventName.ForeColor = foreColor;
            lblEventName.Text = eventInfo.Name;
            EventId = eventInfo._id;
        }
        public EventControl(Event eventInfo)
        {
            InitializeComponent();
            lblEventName.BackColor = BackColor = Color.Black;
            lblEventName.ForeColor = Color.White;
            lblEventName.Text = eventInfo.Name;
            EventId = eventInfo._id;
        }

        private void lblEventName_Click(object sender, EventArgs e)
        {
            EventClick(sender, e, EventId);
        }
    }
    
}
