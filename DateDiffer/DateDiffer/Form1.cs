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
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateDiffBtn_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimePickerFrom.Value.;
            DateTime dateTo = dateTimePickerTo.Value;

            daysL.Text = dateTimePickerFrom.Value.ToLongTimeString();
            hoursL.Text = dateTimePickerTo.Value.ToString();
            
        }
    }
}
