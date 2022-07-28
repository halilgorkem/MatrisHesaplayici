using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrisHesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(a11.Text =="" || a12.Text == "" || a13.Text == "" ||
                a21.Text == "" || a22.Text == "" || a23.Text == "" ||
                a31.Text == "" || a32.Text == "" || a33.Text == ""||
                 s11.Text == "" || s12.Text == "" || s13.Text == "" ||
                  s21.Text == "" || s22.Text == "" || s23.Text == "" ||
                   s31.Text == "" || s32.Text == "" || s33.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int A11 = Convert.ToInt16(a11.Text);
                int S11 = Convert.ToInt16(s11.Text);
                int sonuc11 = A11 + S11;
                p11.Text = sonuc11.ToString();

                int A12 = Convert.ToInt16(a12.Text);
                int S12 = Convert.ToInt16(s12.Text);
                int sonuc12 = A12 + S12;
                p12.Text = sonuc12.ToString();

                int A13 = Convert.ToInt16(a13.Text);
                int S13 = Convert.ToInt16(s13.Text);
                int sonuc13 = A13 + S13;
                p13.Text = sonuc13.ToString();

                int A21 = Convert.ToInt16(a21.Text);
                int S21 = Convert.ToInt16(s21.Text);
                int sonuc21 = A21 + S21;
                p21.Text = sonuc21.ToString();

                int A22 = Convert.ToInt16(a22.Text);
                int S22 = Convert.ToInt16(s22.Text);
                int sonuc22 = A22 + S22;
                p22.Text = sonuc22.ToString();

                int A23 = Convert.ToInt16(a23.Text);
                int S23 = Convert.ToInt16(s23.Text);
                int sonuc23 = A23 + S23;
                p23.Text = sonuc23.ToString();

                int A31 = Convert.ToInt16(a31.Text);
                int S31 = Convert.ToInt16(s31.Text);
                int sonuc31 = A31 + S31;
                p31.Text = sonuc31.ToString();

                int A32 = Convert.ToInt16(a32.Text);
                int S32 = Convert.ToInt16(s32.Text);
                int sonuc32 = A32 + S32;
                p32.Text = sonuc32.ToString();

                int A33 = Convert.ToInt16(a33.Text);
                int S33 = Convert.ToInt16(s33.Text);
                int sonuc33 = A33 + S33;
                p33.Text = sonuc33.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a11.Text == "" || a12.Text == "" || a13.Text == "" ||
                a21.Text == "" || a22.Text == "" || a23.Text == "" ||
                a31.Text == "" || a32.Text == "" || a33.Text == "" ||
                s11.Text == "" || s12.Text == "" || s13.Text == "" ||
                  s21.Text == "" || s22.Text == "" || s23.Text == "" ||
                   s31.Text == "" || s32.Text == "" || s33.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int A11 = Convert.ToInt16(a11.Text);
                int S11 = Convert.ToInt16(s11.Text);
                int sonuc11 = A11 - S11;
                p11.Text = sonuc11.ToString();

                int A12 = Convert.ToInt16(a12.Text);
                int S12 = Convert.ToInt16(s12.Text);
                int sonuc12 = A12 - S12;
                p12.Text = sonuc12.ToString();

                int A13 = Convert.ToInt16(a13.Text);
                int S13 = Convert.ToInt16(s13.Text);
                int sonuc13 = A13 - S13;
                p13.Text = sonuc13.ToString();

                int A21 = Convert.ToInt16(a21.Text);
                int S21 = Convert.ToInt16(s21.Text);
                int sonuc21 = A21 - S21;
                p21.Text = sonuc21.ToString();

                int A22 = Convert.ToInt16(a22.Text);
                int S22 = Convert.ToInt16(s22.Text);
                int sonuc22 = A22 - S22;
                p22.Text = sonuc22.ToString();

                int A23 = Convert.ToInt16(a23.Text);
                int S23 = Convert.ToInt16(s23.Text);
                int sonuc23 = A23 - S23;
                p23.Text = sonuc23.ToString();

                int A31 = Convert.ToInt16(a31.Text);
                int S31 = Convert.ToInt16(s31.Text);
                int sonuc31 = A31 - S31;
                p31.Text = sonuc31.ToString();

                int A32 = Convert.ToInt16(a32.Text);
                int S32 = Convert.ToInt16(s32.Text);
                int sonuc32 = A32 - S32;
                p32.Text = sonuc32.ToString();

                int A33 = Convert.ToInt16(a33.Text);
                int S33 = Convert.ToInt16(s33.Text);
                int sonuc33 = A33 - S33;
                p33.Text = sonuc33.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a11.Text == "" || a12.Text == "" || a13.Text == "" ||
                a21.Text == "" || a22.Text == "" || a23.Text == "" ||
                a31.Text == "" || a32.Text == "" || a33.Text == "" ||
                s11.Text == "" || s12.Text == "" || s13.Text == "" ||
                  s21.Text == "" || s22.Text == "" || s23.Text == "" ||
                   s31.Text == "" || s32.Text == "" || s33.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int A11 = Convert.ToInt16(a11.Text);
                int S11 = Convert.ToInt16(s11.Text);
                int A12 = Convert.ToInt16(a12.Text);
                int S12 = Convert.ToInt16(s12.Text);
                int A13 = Convert.ToInt16(a13.Text);
                int S13 = Convert.ToInt16(s13.Text);
                int A21 = Convert.ToInt16(a21.Text);
                int S21 = Convert.ToInt16(s21.Text);
                int A22 = Convert.ToInt16(a22.Text);
                int S22 = Convert.ToInt16(s22.Text);
                int A23 = Convert.ToInt16(a23.Text);
                int S23 = Convert.ToInt16(s23.Text);
                int A31 = Convert.ToInt16(a31.Text);
                int S31 = Convert.ToInt16(s31.Text);
                int A32 = Convert.ToInt16(a32.Text);
                int S32 = Convert.ToInt16(s32.Text);
                int A33 = Convert.ToInt16(a33.Text);
                int S33 = Convert.ToInt16(s33.Text);

                int sonuc11 = A11 * S11 + A12 * S21 + A13 * S31;
                p11.Text = sonuc11.ToString();

                int sonuc12 = A11 * S12 + A12 * S22 + A13 * S32;
                p12.Text = sonuc12.ToString();

                int sonuc13 = A11 * S13 + A12 * S23 + A13 * S33;
                p13.Text = sonuc13.ToString();


                int sonuc21 = A21 * S11 + A22 * S21 + A23 * S31;
                p21.Text = sonuc21.ToString();

                int sonuc22 = A21 * S12 + A22 * S22 + A23 * S32;
                p22.Text = sonuc22.ToString();

                int sonuc23 = A21 * S13 + A22 * S23 + A23 * S33;
                p23.Text = sonuc23.ToString();


                int sonuc31 = A31 * S11 + A32 * S21 + A33 * S31;
                p31.Text = sonuc31.ToString();

                int sonuc32 = A31 * S12 + A32 * S22 + A33 * S32;
                p32.Text = sonuc32.ToString();

                int sonuc33 = A31 * S13 + A32 * S23 + A33 * S33;
                p33.Text = sonuc33.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a11.Text == "" || a12.Text == "" || a13.Text == "" ||
                a21.Text == "" || a22.Text == "" || a23.Text == "" ||
                a31.Text == "" || a32.Text == "" || a33.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int A11 = Convert.ToInt16(a11.Text);
                int A12 = Convert.ToInt16(a12.Text);
                int A13 = Convert.ToInt16(a13.Text);
                int A21 = Convert.ToInt16(a21.Text);
                int A22 = Convert.ToInt16(a22.Text);
                int A23 = Convert.ToInt16(a23.Text);
                int A31 = Convert.ToInt16(a31.Text);
                int A32 = Convert.ToInt16(a32.Text);
                int A33 = Convert.ToInt16(a33.Text);

                int sonuc1 = A11 * A12 * A33 + A21 * A32 * A13 + A31 * A12 * A23;
                int sonuc2 = A13 * A22 * A31 + A23 * A32 * A11 + A33 * A12 * A21;
                int det = sonuc1 - sonuc2;
                determinant.Text = "|A| = " + det.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s11.Text == "" || s12.Text == "" || s13.Text == "" ||
                  s21.Text == "" || s22.Text == "" || s23.Text == "" ||
                   s31.Text == "" || s32.Text == "" || s33.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int S11 = Convert.ToInt16(s11.Text);
                int S12 = Convert.ToInt16(s12.Text);
                int S13 = Convert.ToInt16(s13.Text);
                int S21 = Convert.ToInt16(s21.Text);
                int S22 = Convert.ToInt16(s22.Text);
                int S23 = Convert.ToInt16(s23.Text);
                int S31 = Convert.ToInt16(s31.Text);
                int S32 = Convert.ToInt16(s32.Text);
                int S33 = Convert.ToInt16(s33.Text);

                int sonuc1 = S11 * S12 * S33 + S21 * S32 * S13 + S31 * S12 * S23;
                int sonuc2 = S13 * S22 * S31 + S23 * S32 * S11 + S33 * S12 * S21;
                int det = sonuc1 - sonuc2;
                determinant.Text = "|B| = " + det.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (p11.Text == "" || p12.Text == "" || p13.Text == "" ||
                  p21.Text == "" || p22.Text == "" || p23.Text == "" ||
                   p31.Text == "" || p32.Text == "" || p33.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int P11 = Convert.ToInt16(p11.Text);
                int P12 = Convert.ToInt16(p12.Text);
                int P13 = Convert.ToInt16(p13.Text);
                int P21 = Convert.ToInt16(p21.Text);
                int P22 = Convert.ToInt16(p22.Text);
                int P23 = Convert.ToInt16(p23.Text);
                int P31 = Convert.ToInt16(p31.Text);
                int P32 = Convert.ToInt16(p32.Text);
                int P33 = Convert.ToInt16(p33.Text);

                int sonuc1 = P11 * P12 * P33 + P21 * P32 * P13 + P31 * P12 * P23;
                int sonuc2 = P13 * P22 * P31 + P23 * P32 * P11 + P33 * P12 * P21;
                int det = sonuc1 - sonuc2;
                determinant.Text = "|C| = " + det.ToString();
            }
        }

        private void yeniHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeni hesap açmak istediğinize emin misiniz? Yapmış olduğunuz işlemler silinecek.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
