using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_percobaan4_1204013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbChar_Leave(object sender, EventArgs e)
        {
            if (tbChar.Text != "")
            {
                epbenar.SetError(tbChar, "OK NAMA VALID");
            }
            else
            {
                epwarn.SetError(tbChar, "NAMA HARUS DIISI");
            }
        }

        private void tbNum_Leave(object sender, EventArgs e)
        {
            int tbNumval;
            if (int.TryParse(tbNum.Text, out tbNumval))
            {
                epbenar.SetError(tbNum, "OK");
            }

            else
            {
                epwarn.SetError(tbNum, "Silahkan Diisi");
            }
        }

        private void tbLenght_Leave(object sender, EventArgs e)
        {
            if (tbLeng.Text != "")
            {
                int length = tbLeng.Text.Length;
                if (length > 5)
                {
                    epbenar.SetError(tbLeng, "Password Valid");
                }
                else
                {
                    epwarn.SetError(tbLeng, "Password Erorr");
                }

            }
            else
            {
                epwarn.SetError(tbLeng, "Silahkan Diisi");
            }
        }

        private void tbCom1_Leave(object sender, EventArgs e)
        {
            if ((tbCom1.Text).All(Char.IsNumber))
            {
            }

            else if (tbCom1.Text == "")
            {
                epwarn.SetError(tbCom1, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epwarn.SetError(tbCom1, "inputan hanya boleh Angka!");
            }
        }

        private void tbCom2_Leave(object sender, EventArgs e)
        {
            if ((tbCom2.Text).All(Char.IsNumber))
            {
                int Angka1;
                int Angka2;
                int.TryParse(tbCom1.Text, out Angka1);
                int.TryParse(tbCom2.Text, out Angka2);
                if (Angka1 > Angka2)
                {
                    epbenar.SetError(tbCom1, "Angka 1 lebih besar dari angka 2 ");
                    epwarn.SetError(tbCom2, "Angka 2 lebih kecil dari angka 1 ");
                }

                else
                {
                    epbenar.SetError(tbCom2, "Angka 2 lebih besar dari angka 1 ");
                    epwarn.SetError(tbCom1, "Angka 1 lebih kecil dari angka 2 ");
                }
            }

            else if (tbCom2.Text == "")
            {
                epwarn.SetError(tbCom2, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epwarn.SetError(tbCom2, "inputan hanya boleh Angka!");
            }
        }

        private void tbregex_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbregex.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epbenar.SetError(tbregex, "Betul!");
            }
            else
            {
                epwarn.SetError(tbregex, "Format salah !\nContoh: a@b.c");
            }
        }

        private void tbUpper_Leave(object sender, EventArgs e)
        {
            if (tbUpper.Text.All(char.IsUpper))
            {
                epbenar.SetError(tbUpper, "OK");
            }
            else
            {
                epwarn.SetError(tbUpper, "Bukan UPPERCASE");
            }
        }

        private void tbLower_Leave(object sender, EventArgs e)
        {

            if (tbLower.Text.All(char.IsLower))
            {
                epbenar.SetError(tbLower, "OK");
            }
            else
            {
                epwarn.SetError(tbLower, "Bukan LOWERCASE");
            }
        }

        private void Tampilkan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nik : " + tbNum.Text + "\nNama : " + tbChar.Text + "\nEmail : " + tbregex.Text + "\nPerbandingan : " + tbCom1.Text + " " + tbCom2.Text + "\nKatasandi : " + tbLeng.Text + "\nKota dalam UPPERCASE : " + tbUpper.Text + "\nvisi dalam Lowercase : " + tbLower.Text);

        }
    }

}

















