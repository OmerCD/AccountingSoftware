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
using HomePage.Classes.Database.Enums;
using HomePage.Forms;

namespace HomePage.CustomControls.Calendar
{
    public partial class EventManager : UserControl
    {
        private DayEvent _currentDayEvent;
        private void RefreshLists()
        {
            RefreshEventList();
            RefreshJobList();
        }

        private void RefreshJobList()
        {
            ListBoxJobList.Items.Clear();
            var jobCRUD = DbFactory.JobCRUD;
            var jobs = jobCRUD.GetJobsAtGivenDate(_currentDayEvent.EventDate);
            if (jobs != null)
                foreach (var job in jobs)
                {
                    if (job.Name == "ALL") continue;
                    var item = new ListBoxItem(job.Name, job._id);
                    ListBoxJobList.Items.Add(item);
                }
        }

        private void RefreshEventList()
        {
            ListBoxEventsList.Items.Clear();
            if (_currentDayEvent.Events != null)
                foreach (var dayEvent in _currentDayEvent.Events)
                {
                    if (dayEvent.Name == "ALL") continue;
                    var item = new ListBoxItem(dayEvent.Name, dayEvent._id);
                    ListBoxEventsList.Items.Add(item);
                }
        }

        public EventManager()
        {
            InitializeComponent();
            Calendar.SelectedDayChanged+=SelectedDayChanged;
        }

        private void SelectedDayChanged(object sender,DayEvent dayEvent)
        {
            _currentDayEvent = dayEvent;
            RefreshLists();
        }

        struct ListBoxItem
        {
            public ListBoxItem(string name, string id) : this()
            {
                Name = name;
                Id = id;
            }

            public string Name { get; set; }
            public string Id { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        private void ButtonAddEvent_Click(object sender, EventArgs e)
        {
            if (_currentDayEvent != null)
            {
                using (var frm = new CreateForm(new Event(), FormGoal.None))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var eventEntity = frm.Entity as Event;
                        _currentDayEvent.Events.Add(eventEntity);
                        DbFactory.DayEventCRUD.Upsert(_currentDayEvent);
                        RefreshLists();
                    }
                }
            }
        }
    }
}
