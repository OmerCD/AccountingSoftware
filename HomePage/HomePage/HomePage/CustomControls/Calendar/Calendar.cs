﻿using System;
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
    public partial class Calendar : UserControl
    {
        struct DayIndetifier
        {
            public int Day { get; set; }
            public int Month { get; set; }
        }
        private readonly string[] _months;
        private DateTime _choosenDate;
        public static Action<Day, DayEvent> SelectedDayChanged;
        public static DateTime ChoosenDateTime;
        private Day _lastChooseDayControl;
        private bool _isDesigner = false;
        private Dictionary<DayIndetifier, Day> _controlList;
        public Calendar(string[] monthStrings)
        {

            InitializeComponent();
            _months = monthStrings;
            _choosenDate = DateTime.Now;
            ArrangeDates(_choosenDate);
        }
        public Calendar(bool designer)
        {
            _isDesigner = designer;
            InitializeComponent();
            _months = new[]
            {
                "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım",
                "Aralık"
            };
            _choosenDate = DateTime.Now;
            SelectedDayChanged += SelectedDayChangeEvent;
            ArrangeDates(_choosenDate);
        }

        private void SelectedDayChangeEvent(Day sender, DayEvent dayEvent)
        {
            if (_lastChooseDayControl != sender)
            {
                if (_lastChooseDayControl != null)
                {
                    _lastChooseDayControl.BackColor = Color.FromArgb(67, 67, 67);
                    _lastChooseDayControl.ForeColor = Color.White;
                }
                _lastChooseDayControl = sender;
            }
        }

        public DateTime ChoosenDate
        {
            get => _choosenDate;
            set
            {
                _choosenDate = value;
                ArrangeDates(value);
            }
        }

        public void RefreshDay(int day, int month)
        {
            var givenDay = new DayIndetifier {Day = day, Month = month};
            var dayControl = _controlList[givenDay];
            dayControl.RefreshDay();
        }
        public void RefreshCalendar()
        {
            ArrangeDates(_choosenDate);
        }
        private void ArrangeDates(DateTime choosenDate)
        {
            TLPDates.Controls.Clear();
            _controlList = new Dictionary<DayIndetifier, Day>();

            DateTime firstDayOfMonth = new DateTime(choosenDate.Year, choosenDate.Month, 1);
            int daysOfMonth = DateTime.DaysInMonth(choosenDate.Year, choosenDate.Month);
            DateTime previousMonth = choosenDate.AddMonths(-1);
            int previousDaysOfMonth = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            int dayOfWeek = (int)firstDayOfMonth.DayOfWeek - 1;
            dayOfWeek = dayOfWeek == -1 ? 6 : dayOfWeek;

            lblMonth.Text = _months[choosenDate.Month - 1];
            LabelYear.Text = choosenDate.Year.ToString();

            for (int i = 0, j = previousDaysOfMonth - (dayOfWeek - 1); i < dayOfWeek; i++, j++)
            {
                var date = new DateTime(previousMonth.Year, previousMonth.Month, j);
                AddDayControl(date,true);
            }

            int monthDayCounter = 1;
            for (int i = 1; i <= daysOfMonth; i++)
            {
                var date = new DateTime(choosenDate.Year, choosenDate.Month, monthDayCounter++);

                AddDayControl(date,false);
            }

            DateTime nextMonth = choosenDate.AddMonths(1);
            DateTime firstDayOfNextMonth = new DateTime(nextMonth.Year, nextMonth.Month, 1);
            int nextDayOfWeek = (int)firstDayOfNextMonth.DayOfWeek - 1;
            nextDayOfWeek = nextDayOfWeek == -1 ? 6 : nextDayOfWeek;
            for (int i = 0; i < 7 - nextDayOfWeek; i++)
            {
                var date = new DateTime(nextMonth.Year, nextMonth.Month, (i + 1));

                AddDayControl(date,true);
            }
        }

        private void AddDayControl(DateTime date,bool blurred)
        {
            var day = new Day(date, blurred, _isDesigner);
            _controlList.Add(new DayIndetifier { Day = date.Day, Month = date.Month }, day);
            TLPDates.Controls.Add(day);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            _choosenDate = _choosenDate.AddMonths(1);
            ArrangeDates(_choosenDate);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            _choosenDate = _choosenDate.AddMonths(-1);
            ArrangeDates(_choosenDate);
        }
    }
}
