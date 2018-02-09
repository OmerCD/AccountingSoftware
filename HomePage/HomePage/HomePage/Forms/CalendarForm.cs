using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.CustomControls.Calendar;

namespace HomePage.Forms
{
    public partial class CalendarForm : Form
    {
        
        public CalendarForm()
        {
            InitializeComponent();
            eventManager1.EventAdded += NewEventAddedEvent;
        }

        private void NewEventAddedEvent(int refreshedDay,int refreshedMonth)
        {
            calendar1.RefreshDay(refreshedDay,refreshedMonth);
        }
    }
}
