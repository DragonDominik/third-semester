using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ButtonHunter
{
    public partial class ButtonHunter : Form
    {
        private int points = 0;
        private Random generator = new Random();
        private DateTime startTime;
        private System.Windows.Forms.Timer timer;
        private bool isClosing = false;


        public ButtonHunter()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += UpdateStatusBar;

            this.FormClosing += GameClosing;
        }

        private void btnClick(object sender, EventArgs e)
        {
            int x = ClientSize.Width - pushButton.Width;
            int y = ClientSize.Height - pushButton.Height - statusStrip.Height;
            pushButton.Location = new Point(generator.Next(x), generator.Next(y));

            if (!timer.Enabled)
            {
                startTime = DateTime.Now;
                timer.Start();
            }
            else
            {
                ++points;
            }

            UpdateStatusBar(sender, e);
        }

        private void UpdateStatusBar(object sender, EventArgs e)
        {
            if (isClosing) return; 

            double elapsedSeconds = (DateTime.Now - startTime).TotalSeconds;
            statusLabel.Text = $"Pontok: {points} | Eltelt idő: {elapsedSeconds:F0} másodperc";
        }


        private void statusStripClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameClosing(object sender, FormClosingEventArgs e)
        {
            isClosing = true;

            if (e.CloseReason == CloseReason.UserClosing && timer.Enabled)
            {
                double elapsedSeconds = (DateTime.Now - startTime).TotalSeconds;
                double pushPerSeconds = points / elapsedSeconds;
                MessageBox.Show($"Gombnyomás per másodperc: {pushPerSeconds:F2}", "Eredmények",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
