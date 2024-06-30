namespace kronometre
{
    public partial class Form1 : Form
    {
        int saniye = 0, dakika = 0, saat = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "BAÞLAT";
            button2.Text = "SIFIRLA";
        }
        int durum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (durum == 0)
            {
                button1.Text = "DURDUR";
                durum = 1;
                timer1.Start();
            }
            else if (durum == 1)
            {
                button1.Text = "BAÞLAT";
                durum = 0;
                timer1.Stop();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }

            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            label1.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saat = 0;
            dakika = 0;
            saniye = 0;
        }
    }
}