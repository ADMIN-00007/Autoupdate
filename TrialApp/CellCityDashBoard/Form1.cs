namespace CellCityDashBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void DateTimeMainLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goldwingbw-my.sharepoint.com/:x:/g/personal/adnan_cellcity_co_bw/Ea2CP8y_6eZFmIRXeWYgB30BWsa97zIkXmhcYSLD6WMoeg?e=49erkZ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimeMainLabel1.Text = DateTime.Now.ToString("dd MMM yyyy   hh:mm:ss");
        }
    }
}