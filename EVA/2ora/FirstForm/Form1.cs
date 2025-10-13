namespace FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //quitButton.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
