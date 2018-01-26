using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database;
using HomePage.Classes.Database.Cruds;
using HomePage.Classes.Database.Entities;

namespace HomePage.CustomControls.Calendar
{
    public partial class Day : UserControl
    {
        private readonly DateTime _dateTime;

        public Day(DateTime dateTime,bool blurred)
        {
            _dateTime = dateTime;
            InitializeComponent();
            lblDay.Text = dateTime.Day.ToString();
            if (blurred)
            {
                lblDay.ForeColor = Color.Red;
            }
            CheckDayEvents(dateTime);
        }

        private void CheckDayEvents(DateTime dateTime)
        {
            var dayEventCRUD = DbFactory.DayEventCRUD;
            var dayEvent = dayEventCRUD.GetOne("EventDate", dateTime);
            if (dayEvent != null && dayEvent.Events.Count>0)
            {
                pictureBoxEvent.Visible = true;
            }

            var jobCRUD = DbFactory.JobCRUD;
            if (jobCRUD.CheckIfJobExists(dateTime))
            {
                pictureBoxJob.Visible = true;
            }

        }

        private void Day_Click(object sender, EventArgs e)
        {
            var dayEventCRUD = DbFactory.DayEventCRUD;
            var selectedDay = dayEventCRUD.GetOne("EventDate", _dateTime);
            if (selectedDay?._id == null)
            {
                selectedDay = new DayEvent
                {
                    EventDate = _dateTime
                };
            }
            BackColor = Color.Goldenrod;
            Calendar.SelectedDayChanged?.Invoke(this,selectedDay);
        }
    }
}
