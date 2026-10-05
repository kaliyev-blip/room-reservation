using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace roomreservation
{
    public partial class Form1
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            Font fontBold = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Font fontReg = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);

            this.txtAdSoyad = new TextBox() { Location = new Point(120, 50), Size = new Size(220, 26), Font = fontReg, MaxLength = 50 };
            this.txtMuddet = new TextBox() { Location = new Point(390, 50), Size = new Size(220, 26), Font = fontReg, MaxLength = 4 };

            this.label1 = new Label() { Location = new Point(120, 25), Size = new Size(110, 20), Font = fontBold, ForeColor = Color.White, Text = "Ad və soyad", AutoSize = true };
            this.label2 = new Label() { Location = new Point(390, 25), Size = new Size(133, 20), Font = fontBold, ForeColor = Color.White, Text = "Müddət (dəqiqə)", AutoSize = true };

            this.lblOtaq1Vaxt = new Label() { Location = new Point(120, 110), Font = fontBold, ForeColor = Color.White, Text = "0", AutoSize = true };
            this.lblOtaq2Vaxt = new Label() { Location = new Point(350, 110), Font = fontBold, ForeColor = Color.White, Text = "0", AutoSize = true };
            this.lblOtaq3Vaxt = new Label() { Location = new Point(580, 110), Font = fontBold, ForeColor = Color.White, Text = "0", AutoSize = true };
            this.lblOtaq4Vaxt = new Label() { Location = new Point(120, 245), Font = fontBold, ForeColor = Color.White, Text = "0", AutoSize = true };
            this.lblOtaq5Vaxt = new Label() { Location = new Point(350, 245), Font = fontBold, ForeColor = Color.White, Text = "0", AutoSize = true };
            this.lblOtaq6Vaxt = new Label() { Location = new Point(580, 245), Font = fontBold, ForeColor = Color.White, Text = "0", AutoSize = true };

            this.btnOtaq1 = new Button() { Location = new Point(50, 135), Size = new Size(160, 90), Font = fontBold, BackColor = Color.White, Text = "Otaq 1" };
            this.btnOtaq2 = new Button() { Location = new Point(280, 135), Size = new Size(160, 90), Font = fontBold, BackColor = Color.White, Text = "Otaq 2" };
            this.btnOtaq3 = new Button() { Location = new Point(510, 135), Size = new Size(160, 90), Font = fontBold, BackColor = Color.White, Text = "Otaq 3" };
            this.btnOtaq4 = new Button() { Location = new Point(50, 270), Size = new Size(160, 90), Font = fontBold, BackColor = Color.White, Text = "Otaq 4" };
            this.btnOtaq5 = new Button() { Location = new Point(280, 270), Size = new Size(160, 90), Font = fontBold, BackColor = Color.White, Text = "Otaq 5" };
            this.btnOtaq6 = new Button() { Location = new Point(510, 270), Size = new Size(160, 90), Font = fontBold, BackColor = Color.White, Text = "Otaq 6" };

            // Klik hadisələri (Eventlər)
            this.btnOtaq1.Click += new EventHandler(this.btnOtaq1_Click);
            this.btnOtaq2.Click += new EventHandler(this.btnOtaq2_Click);
            this.btnOtaq3.Click += new EventHandler(this.btnOtaq3_Click);
            this.btnOtaq4.Click += new EventHandler(this.btnOtaq4_Click);
            this.btnOtaq5.Click += new EventHandler(this.btnOtaq5_Click);
            this.btnOtaq6.Click += new EventHandler(this.btnOtaq6_Click);

            // Daxil etmə yoxlamaları
            this.txtAdSoyad.KeyPress += new KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            this.txtMuddet.KeyPress += new KeyPressEventHandler(this.txtMuddet_KeyPress);
            this.txtAdSoyad.TextChanged += new EventHandler(this.txtAdSoyad_TextChanged);
            this.txtMuddet.TextChanged += new EventHandler(this.txtMuddet_TextChanged);

            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer1.Tick += new EventHandler(this.timer1_Tick);

            this.BackColor = Color.Gray;
            this.ClientSize = new Size(720, 400);
            this.Text = "Room reservation";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Bütün elementləri ekrana əlavə edirik
            this.Controls.AddRange(new Control[] { txtAdSoyad, txtMuddet, label1, label2,
                btnOtaq1, btnOtaq2, btnOtaq3, btnOtaq4, btnOtaq5, btnOtaq6,
                lblOtaq1Vaxt, lblOtaq2Vaxt, lblOtaq3Vaxt, lblOtaq4Vaxt, lblOtaq5Vaxt, lblOtaq6Vaxt });

            this.Load += new EventHandler(this.Form1_Load);
        }

        private TextBox txtAdSoyad, txtMuddet;
        private Label label1, label2, lblOtaq1Vaxt, lblOtaq2Vaxt, lblOtaq3Vaxt, lblOtaq4Vaxt, lblOtaq5Vaxt, lblOtaq6Vaxt;
        private Button btnOtaq1, btnOtaq2, btnOtaq3, btnOtaq4, btnOtaq5, btnOtaq6;
        private System.Windows.Forms.Timer timer1;
    }
}