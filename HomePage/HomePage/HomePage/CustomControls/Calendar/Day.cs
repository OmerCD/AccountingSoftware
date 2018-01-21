using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.CustomControls.Calendar
{
    public partial class Day : UserControl
    {
        public Day(int dayOfMonth, IReadOnlyCollection<EventInfo> events, bool blurred)
        {
            InitializeComponent();
            lblDay.Text = dayOfMonth.ToString();
            if (events?.Count > 0)
            {
                foreach (EventInfo eventInfo in events)
                {
                    flpnlEvents.Controls.Add(new Event(eventInfo));
                }
            }
            if (blurred)
            {
                lblDay.ForeColor = Color.Silver;
            }
        }
    }
}
