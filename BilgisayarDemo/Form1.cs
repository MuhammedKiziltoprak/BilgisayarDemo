namespace BilgisayarDemo
{
    public partial class Form1 : Form
    {
        Bilgisayar bilgisayar = new Bilgisayar();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bilgisayar App";
            lsonuc.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Bilgisayar bilgisayar = new Bilgisayar();
            //bilgisayar.Marka = "ASUS";
            //Bilgisayar bilgisayar = new Bilgisayar()
            //{
            //    Marka = "ASUS",
            //    Aciklama="Muhammedin Bilgisayarý",
            //    Hiz= 3.8,

            //};


            bilgisayar.Marka = tbMarka.Text.Trim();
            bilgisayar.Aciklama = textBox2.Text.Trim();
            bilgisayar.Hiz = Convert.ToDouble(textBox1.Text.Trim());
            //Ram= Convert.ToByte(nudRam.Value),
            bilgisayar.Ram = Convert.ToByte(ddlRam.Text.Remove(ddlRam.Text.Length - 3));
            bilgisayar.SuSogutma = checkBox1.Checked;
            bilgisayar.UretimTarihi = dtpUretim.Value;

            lsonuc.Text = "Bilgisayar Oluþturuldu.";
            MessageBox.Show(lsonuc.Text);
        }

        private void bGoster_Click(object sender, EventArgs e)
        {
            lsonuc.Text = "Marka: " + bilgisayar.Marka + "\r\n";
            lsonuc.Text += "Açýklama: " + bilgisayar.Aciklama + "\r\n";
            lsonuc.Text += "Hiz: " + bilgisayar.Hiz + "\r\n";
            lsonuc.Text += "Su Soðutma: " + bilgisayar.SuSogutma;
            lsonuc.Text += "Tarih: " + bilgisayar.UretimTarihi;


        }

    }
}


