using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiClock
{
    public partial class Clock : UserControl
    {
        private readonly System.Windows.Forms.Timer timer = new();

        public Clock()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int timeZone;
        public string City
        {
            get => cityLabel.Text;
            set => cityLabel.Text = value;
        }
        public int TimeZone
        {
            get { return timeZone; }
            set
            {
                timeZone = value;
                RefreshTime(this, EventArgs.Empty);
            }
        }

        private void RefreshTime(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            timeLabel.Text = time
            .AddHours(TimeZone)
            .ToString(time.Second % 2 == 0 ? "HH:mm" : "HH mm");
        }
    }
}
