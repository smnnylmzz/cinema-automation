namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, kola, toplam;
            string ad, soyad;
            ad = txtAd.Text;
            soyad = textBox2.Text;

            misir = Convert.ToInt32(txtMsr.Text);
            bilet = Convert.ToInt32(txtBlt.Text);
            su = Convert.ToInt32(txtSu.Text);
            cay = Convert.ToInt32(txtCy.Text);
            kola = Convert.ToInt32(txtKola.Text);
            toplam = cay * 4 + misir * 10 + su * 3 + kola * 20 + bilet * 30;
            lblToplam.Text = toplam.ToString() + " TL ";
            kasatutar += kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + " TL ";
            listBox1.Items.Add(" Ad: " + ad + " Soyadý: " + soyad + "~~" + "Toplam Tutar: " + kasatutar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblKasa_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBlt.Text = "";
            txtCy.Text = "";
            txtKola.Text = "";
            txtMsr.Text = "";
            txtSu.Text = "";
            txtMsr.Focus();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}