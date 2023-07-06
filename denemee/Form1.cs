using System.Data;

namespace denemee
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }  

        private void button6_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "4";
        }

        private void btnSekiz_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "8";
        }

        private void btnSifir_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += '0';
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnBir_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "2";
        }

        private void btnUc_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "3";
        }

        private void btnBes_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "5";
        }

        private void btnAlti_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "6";
        }

        private void btnYedi_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "7";
        }

        private void btnDokuz_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "9";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            string hesap = txtSonuc.Text;

            DataTable dt = new DataTable();

            try
            {
                var sonuc = dt.Compute(hesap, "");
                txtSonuc.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçersiz iþlem: " + ex.Message, "Hata");
            }
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "+";
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "-";
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "*";
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            txtSonuc.Text += "/";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "";
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

        }

        private void btnCos_Click(object sender, EventArgs e)
        {

        }

        private void btnTan_Click(object sender, EventArgs e)
        {

        }

        private void btnCot_Click(object sender, EventArgs e)
        {

        }

        private void btnClearOne_Click(object sender, EventArgs e)
        {
            txtSonuc.Text.ToList().RemoveAt(txtSonuc.Text.Length - 1);
        }
    }
}