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
using HomePage.Classes.Database.Entities;

namespace HomePage.CustomControls.Calendar
{
    public partial class Event : UserControl
    {
        public event EventControl.EventClickAction EventClick;
        public string EventId { get; }
        public Event(Color backColor, Color foreColor, EventInfo eventInfo)
        {
            InitializeComponent();
            lblEventName.BackColor = BackColor = backColor;
            lblEventName.ForeColor = foreColor;
            lblEventName.Text = eventInfo.Name;
            EventId = eventInfo._id;
        }
        public Event(EventInfo eventInfo)
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
    public class EventControl
    {
        public delegate void EventClickAction(object sender, EventArgs e, string eventId);
    }

    public class EventInfo:DbObject
    {
        [Custom(FieldName = "Olay Adı",MaxLength = 25)]
        public string Name { get; set; }
        [Custom(FieldName = "Olay Tarihi")]
        public DateTime EventDate { get; set; }
    }
}
