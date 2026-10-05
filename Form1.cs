using System;
using System.Drawing;
using System.Windows.Forms;

namespace roomreservation
{
    public partial class Form1 : Form
    {
        int vaxtOtaq1 = 0;
        int vaxtOtaq2 = 0;
        int vaxtOtaq3 = 0;
        int vaxtOtaq4 = 0;
        int vaxtOtaq5 = 0;
        int vaxtOtaq6 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer1.Start();
        }

        // Ad soyad: yalnız hərf, boşluq və defis (ə, ü, ö, ğ, ı, ş, ç daxil)
        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '-')
                return;

            e.Handled = true;
        }

        // Müddət: yalnız rəqəm
        private void txtMuddet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // Ctrl+V ilə yapışdırılan yanlış simvolları silir
        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            string temiz = "";
            foreach (char c in txtAdSoyad.Text)
            {
                if (char.IsLetter(c) || c == ' ' || c == '-')
                    temiz += c;
            }

            if (temiz != txtAdSoyad.Text)
            {
                int pos = txtAdSoyad.SelectionStart;
                txtAdSoyad.Text = temiz;
                txtAdSoyad.SelectionStart = Math.Min(pos, txtAdSoyad.Text.Length);
            }
        }

        private void txtMuddet_TextChanged(object sender, EventArgs e)
        {
            string temiz = "";
            foreach (char c in txtMuddet.Text)
            {
                if (char.IsDigit(c))
                    temiz += c;
            }

            if (temiz != txtMuddet.Text)
            {
                int pos = txtMuddet.SelectionStart;
                txtMuddet.Text = temiz;
                txtMuddet.SelectionStart = Math.Min(pos, txtMuddet.Text.Length);
            }
        }

        private bool MelumatlariYoxla(out int muddet)
        {
            muddet = 0;
            string ad = txtAdSoyad.Text.Trim();
            string muddetText = txtMuddet.Text.Trim();

            if (ad == "")
            {
                MessageBox.Show("Ad və soyad boş ola bilməz!");
                txtAdSoyad.Focus();
                return false;
            }

            if (muddetText == "")
            {
                MessageBox.Show("Müddət boş ola bilməz!");
                txtMuddet.Focus();
                return false;
            }

            if (!AdDuzgundur(ad))
            {
                MessageBox.Show("Ad və soyad yalnız hərflərdən ibarət olmalıdır!");
                txtAdSoyad.Focus();
                return false;
            }

            if (!int.TryParse(muddetText, out muddet))
            {
                MessageBox.Show("Müddət yalnız rəqəm olmalıdır!");
                txtMuddet.Focus();
                return false;
            }

            if (muddet == 0)
            {
                MessageBox.Show("Müddət 0 ola bilməz!");
                txtMuddet.Focus();
                return false;
            }

            if (muddet < 1)
            {
                MessageBox.Show("Müddət 1-dən böyük olmalıdır!");
                txtMuddet.Focus();
                return false;
            }

            return true;
        }

        private bool AdDuzgundur(string ad)
        {
            bool herfVar = false;

            foreach (char c in ad)
            {
                if (char.IsLetter(c))
                {
                    herfVar = true;
                    continue;
                }

                if (c == ' ' || c == '-')
                    continue;

                return false;
            }

            return herfVar;
        }

        private void btnOtaq1_Click(object sender, EventArgs e)
        {
            int muddet;
            if (!MelumatlariYoxla(out muddet))
                return;

            vaxtOtaq1 = muddet;
            lblOtaq1Vaxt.Text = vaxtOtaq1.ToString();
            btnOtaq1.BackColor = Color.Red;
            btnOtaq1.Enabled = false;
        }

        private void btnOtaq2_Click(object sender, EventArgs e)
        {
            int muddet;
            if (!MelumatlariYoxla(out muddet))
                return;

            vaxtOtaq2 = muddet;
            lblOtaq2Vaxt.Text = vaxtOtaq2.ToString();
            btnOtaq2.BackColor = Color.Red;
            btnOtaq2.Enabled = false;
        }

        private void btnOtaq3_Click(object sender, EventArgs e)
        {
            int muddet;
            if (!MelumatlariYoxla(out muddet))
                return;

            vaxtOtaq3 = muddet;
            lblOtaq3Vaxt.Text = vaxtOtaq3.ToString();
            btnOtaq3.BackColor = Color.Red;
            btnOtaq3.Enabled = false;
        }

        private void btnOtaq4_Click(object sender, EventArgs e)
        {
            int muddet;
            if (!MelumatlariYoxla(out muddet))
                return;

            vaxtOtaq4 = muddet;
            lblOtaq4Vaxt.Text = vaxtOtaq4.ToString();
            btnOtaq4.BackColor = Color.Red;
            btnOtaq4.Enabled = false;
        }

        private void btnOtaq5_Click(object sender, EventArgs e)
        {
            int muddet;
            if (!MelumatlariYoxla(out muddet))
                return;

            vaxtOtaq5 = muddet;
            lblOtaq5Vaxt.Text = vaxtOtaq5.ToString();
            btnOtaq5.BackColor = Color.Red;
            btnOtaq5.Enabled = false;
        }

        private void btnOtaq6_Click(object sender, EventArgs e)
        {
            int muddet;
            if (!MelumatlariYoxla(out muddet))
                return;

            vaxtOtaq6 = muddet;
            lblOtaq6Vaxt.Text = vaxtOtaq6.ToString();
            btnOtaq6.BackColor = Color.Red;
            btnOtaq6.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vaxtOtaq1 > 0)
            {
                vaxtOtaq1 = vaxtOtaq1 - 1;
                lblOtaq1Vaxt.Text = vaxtOtaq1.ToString();
                if (vaxtOtaq1 == 0)
                {
                    btnOtaq1.BackColor = Color.White;
                    btnOtaq1.Enabled = true;
                }
            }

            if (vaxtOtaq2 > 0)
            {
                vaxtOtaq2 = vaxtOtaq2 - 1;
                lblOtaq2Vaxt.Text = vaxtOtaq2.ToString();
                if (vaxtOtaq2 == 0)
                {
                    btnOtaq2.BackColor = Color.White;
                    btnOtaq2.Enabled = true;
                }
            }

            if (vaxtOtaq3 > 0)
            {
                vaxtOtaq3 = vaxtOtaq3 - 1;
                lblOtaq3Vaxt.Text = vaxtOtaq3.ToString();
                if (vaxtOtaq3 == 0)
                {
                    btnOtaq3.BackColor = Color.White;
                    btnOtaq3.Enabled = true;
                }
            }

            if (vaxtOtaq4 > 0)
            {
                vaxtOtaq4 = vaxtOtaq4 - 1;
                lblOtaq4Vaxt.Text = vaxtOtaq4.ToString();
                if (vaxtOtaq4 == 0)
                {
                    btnOtaq4.BackColor = Color.White;
                    btnOtaq4.Enabled = true;
                }
            }

            if (vaxtOtaq5 > 0)
            {
                vaxtOtaq5 = vaxtOtaq5 - 1;
                lblOtaq5Vaxt.Text = vaxtOtaq5.ToString();
                if (vaxtOtaq5 == 0)
                {
                    btnOtaq5.BackColor = Color.White;
                    btnOtaq5.Enabled = true;
                }
            }

            if (vaxtOtaq6 > 0)
            {
                vaxtOtaq6 = vaxtOtaq6 - 1;
                lblOtaq6Vaxt.Text = vaxtOtaq6.ToString();
                if (vaxtOtaq6 == 0)
                {
                    btnOtaq6.BackColor = Color.White;
                    btnOtaq6.Enabled = true;
                }
            }
        }
    }
}