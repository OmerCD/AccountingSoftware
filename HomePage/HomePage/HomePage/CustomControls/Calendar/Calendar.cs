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
    public partial class Calendar : UserControl
    {
        private readonly string[] _months;
        private DateTime _choosenDate;
        public Calendar(string[] monthStrings)
        {
            InitializeComponent();
            _months = monthStrings;
            _choosenDate = DateTime.Now;
            ArrangeDates(_choosenDate);
        }
        public Calendar()
        {
            InitializeComponent();
            _months = new[]
            {
                "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım",
                "Aralık"
            };
            _choosenDate = DateTime.Now;
            ArrangeDates(_choosenDate);
        }

        public DateTime ChoosenDate
        {
            get { return _choosenDate; }
            set
            {
                _choosenDate = value;
                ArrangeDates(value);
            }
        }

        private void ArrangeDates(DateTime choosenDate)
        {
            TLPDates.Controls.Clear();

            DateTime firstDayOfMonth = new DateTime(choosenDate.Year, choosenDate.Month, 1);
            int daysOfMonth = DateTime.DaysInMonth(choosenDate.Year, choosenDate.Month);
            DateTime tempDate = choosenDate.AddMonths(-1);
            int previousDaysOfMonth = DateTime.DaysInMonth(tempDate.Year, tempDate.Month);
            int dayOfWeek = (int)firstDayOfMonth.DayOfWeek - 1;
            dayOfWeek = dayOfWeek == -1 ? 6 : dayOfWeek;

            lblMonth.Text = _months[choosenDate.Month - 1];
            LabelYear.Text = choosenDate.Year.ToString();

            for (int i = 0, j = previousDaysOfMonth - (dayOfWeek - 1); i < dayOfWeek; i++, j++)
            {
                TLPDates.Controls.Add(new Day(j, null, true));
            }

            int monthDayCounter = 1;
            for (int i = 1; i <= daysOfMonth; i++)
            {
                TLPDates.Controls.Add(new Day(monthDayCounter++, null, false));
            }

            DateTime nextMonth = choosenDate.AddMonths(1);
            DateTime firstDayOfNextMonth = new DateTime(nextMonth.Year, nextMonth.Month, 1);
            int nextDayOfWeek = (int)firstDayOfNextMonth.DayOfWeek - 1;
            nextDayOfWeek = nextDayOfWeek == -1 ? 6 : nextDayOfWeek;
            for (int i = 0; i < 7 - nextDayOfWeek; i++)
            {
                TLPDates.Controls.Add(new Day(i + 1, null, true));
            }
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
