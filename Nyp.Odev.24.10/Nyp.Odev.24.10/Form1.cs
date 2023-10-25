namespace Nyp.Odev._24._10
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ýþçi");
            comboBox1.Items.Add("Mühendis");

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text), comboBox1.Text);

            if (comboBox1.Text == "Ýþçi")
            {
                MessageBox.Show(pers.ucretHesapla().ToString());
            }
            else
            {
                pers.ucretHesapla(1000);
            }
        }

        
    }
}