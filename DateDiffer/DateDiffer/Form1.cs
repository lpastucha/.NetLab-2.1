using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateDiffer
{
    public partial class Form1 : Form
    {
        const int DAY = 86400000;
        const int HOUR = 3600000;
        const int MINUTE = 60000;
        const int SECOND = 1000;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateDiffBtn_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = DateTime.Parse(dateTimePickerFrom.Value.ToString());
            DateTime dateTo = DateTime.Parse(dateTimePickerTo.Value.ToString());

            TimeSpan  t = dateTo - dateFrom;
            double miliseconds = t.TotalMilliseconds;
        
            int days =(int) (miliseconds/DAY);
            miliseconds = miliseconds - (days * DAY);

            int hours =(int) (miliseconds/HOUR);
            miliseconds = miliseconds - (hours * HOUR);

            int minutes =(int)( miliseconds/MINUTE);
            miliseconds = miliseconds - (minutes * MINUTE);

            int seconds =(int) (miliseconds/SECOND);

            daysL.Text = days.ToString();
            hoursL.Text = hours.ToString();
            minutesL.Text = minutes.ToString();
            SecondL.Text = seconds.ToString();
            
        }
    }
}
