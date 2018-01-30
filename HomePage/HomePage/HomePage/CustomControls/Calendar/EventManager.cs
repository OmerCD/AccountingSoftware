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
        private Type _lastType;
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
            EventViewer.ButtonClickEvent += EventViewer_ButtonClickEvent;
        }

        private void EventViewer_ButtonClickEvent(object arg1, EventArgs arg2)
        {
            var type = _lastType;
            var genericType = typeof(CRUD<>).MakeGenericType(type);

            var genericCRUD = Activator.CreateInstance(genericType);
            var method = genericType.GetMethod("Update");
            var objectC = EventViewer.Object;
            string id="";
            if (type == typeof(Job))
            {
                int selectedIndex = ListBoxJobList.SelectedIndex;
                if (selectedIndex!=-1)
                {
                    id = ((ListBoxItem) ListBoxJobList.Items[selectedIndex]).Id;
                }
            }
            else if (type == typeof(DayEvent))
            {
                int selectedIndex = ListBoxEventsList.SelectedIndex;
                if (selectedIndex!=-1)
                {
                    id = ((ListBoxItem)ListBoxEventsList.Items[selectedIndex]).Id;
                    var newEvent = (Event)EventViewer.Object;
                    var oldEventIndex = _currentDayEvent.Events.FindIndex(x => x._id == id);
                    _currentDayEvent.Events[oldEventIndex] = newEvent;
                    objectC = _currentDayEvent;
                }
            }

            method?.Invoke(genericCRUD, new[] { id, objectC });

        }

        private void SelectedDayChanged(object sender,DayEvent dayEvent)
        {
            _currentDayEvent = dayEvent;
            EventViewer.Object = null;
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

        private void ButtonAddJob_Click(object sender, EventArgs e)
        {
            if (_currentDayEvent != null)
            {
                using (var frm = new CreateForm(new Job{EventDate = _currentDayEvent.EventDate}, FormGoal.Add))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshLists();
                    }
                }
            }
        }

        private void ListBoxEventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxEventsList.SelectedIndex!=-1)
            {
                EventViewer.Object=_currentDayEvent.Events.First(x => x._id == ((ListBoxItem) ListBoxEventsList.SelectedItem).Id);
                _lastType = typeof(DayEvent);
            }
        }

        private void ListBoxJobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxJobList.SelectedIndex!=-1)
            {
                EventViewer.Object = DbFactory.JobCRUD.GetOne(((ListBoxItem) ListBoxJobList.SelectedItem).Id);
                _lastType = typeof(Job);
            }
        }
    }
}
