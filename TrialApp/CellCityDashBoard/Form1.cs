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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.office.com/Pages/ResponsePage.aspx?id=Uxo8h1TYokeM71lH3Fj_sdQBH5zizjBImbSQ_pb3sepURExWQkY2VzlVTlhWNFZERUxQVzZGMTA0RS4u");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goldwingbw-my.sharepoint.com/:x:/g/personal/adnan_cellcity_co_bw/EbhTOxKr6lxBsey0j8x3jPsB5lr95u9b2LO1feHc6O_Dgw?e=1ejAHr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1kuCpfsP2BnDou7QxRB80s3NrvZbAr1hT-iXGhiU7Klo/edit?usp=sharing");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.office.com/Pages/ResponsePage.aspx?id=Uxo8h1TYokeM71lH3Fj_sdQBH5zizjBImbSQ_pb3sepUNFQ4VFY1VTZIUklCRFRZNTFMSVE3WlpaUC4u");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goldwingbw-my.sharepoint.com/:x:/g/personal/adnan_cellcity_co_bw/Ea8PkdIBJh5EkOSPfao7hOYB7JVSR_pVCJktLR47HZALgg");
        }
    }
}