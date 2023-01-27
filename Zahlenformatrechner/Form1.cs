using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlenformatrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string arithmetic = "";

        string type = "";
        int type_code = 0;

        string hex_value = "0";
        int bin_value = 0;
        int value1 = 0;
        int value2 = 0;



        // not needed
        private void tb_content_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gb_decoder_Enter(object sender, EventArgs e)
        {

        }


        // Zahlenformaat
        private void btn_dec_Click(object sender, EventArgs e)
        {
            if(type == "hex" || type == "bin")
            {
                tb_content.Clear();
            }
            type = "dec";
            type_code = 1;

            btn_dec.ForeColor = Color.DarkKhaki;
            btn_hex.ForeColor = Color.Gray;
            btn_bin.ForeColor = Color.Gray;

            btn_0.ForeColor = Color.DarkKhaki;
            btn_1.ForeColor = Color.DarkKhaki;
            btn_2.ForeColor = Color.DarkKhaki;
            btn_3.ForeColor = Color.DarkKhaki;
            btn_4.ForeColor = Color.DarkKhaki;
            btn_5.ForeColor = Color.DarkKhaki;
            btn_6.ForeColor = Color.DarkKhaki;
            btn_7.ForeColor = Color.DarkKhaki;
            btn_8.ForeColor = Color.DarkKhaki;
            btn_9.ForeColor = Color.DarkKhaki;
            btn_A.ForeColor = Color.Gray;
            btn_B.ForeColor = Color.Gray;
            btn_C.ForeColor = Color.Gray;
            btn_D.ForeColor = Color.Gray;
            btn_E.ForeColor = Color.Gray;
            btn_F.ForeColor = Color.Gray;
        }

        private void btn_hex_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "bin")
            {
                tb_content.Clear();
            }
            type = "hex";
            type_code = 2;

            btn_dec.ForeColor = Color.Gray;
            btn_hex.ForeColor = Color.DarkKhaki;
            btn_bin.ForeColor = Color.Gray;

            btn_0.ForeColor = Color.DarkKhaki;
            btn_1.ForeColor = Color.DarkKhaki;
            btn_2.ForeColor = Color.DarkKhaki;
            btn_3.ForeColor = Color.DarkKhaki;
            btn_4.ForeColor = Color.DarkKhaki;
            btn_5.ForeColor = Color.DarkKhaki;
            btn_6.ForeColor = Color.DarkKhaki;
            btn_7.ForeColor = Color.DarkKhaki;
            btn_8.ForeColor = Color.DarkKhaki;
            btn_9.ForeColor = Color.DarkKhaki;
            btn_A.ForeColor = Color.DarkKhaki;
            btn_B.ForeColor = Color.DarkKhaki;
            btn_C.ForeColor = Color.DarkKhaki;
            btn_D.ForeColor = Color.DarkKhaki;
            btn_E.ForeColor = Color.DarkKhaki;
            btn_F.ForeColor = Color.DarkKhaki;
        }

        private void btn_bin_Click(object sender, EventArgs e)
        {
            if (type == "hex" || type == "dec")
            {
                tb_content.Clear();
            }
            type = "bin";
            type_code = 3;

            btn_dec.ForeColor = Color.Gray;
            btn_hex.ForeColor = Color.Gray;
            btn_bin.ForeColor = Color.DarkKhaki;

            btn_0.ForeColor = Color.DarkKhaki;
            btn_1.ForeColor = Color.DarkKhaki;
            btn_2.ForeColor = Color.Gray;
            btn_3.ForeColor = Color.Gray;
            btn_4.ForeColor = Color.Gray;
            btn_5.ForeColor = Color.Gray;
            btn_6.ForeColor = Color.Gray;
            btn_7.ForeColor = Color.Gray;
            btn_8.ForeColor = Color.Gray;
            btn_9.ForeColor = Color.Gray;
            btn_A.ForeColor = Color.Gray;
            btn_B.ForeColor = Color.Gray;
            btn_C.ForeColor = Color.Gray;
            btn_D.ForeColor = Color.Gray;
            btn_E.ForeColor = Color.Gray;
            btn_F.ForeColor = Color.Gray;
        }


        // Zahleneingabe
        private void btn_0_Click(object sender, EventArgs e)
        {
            if(type == "dec" || type == "hex" || type == "bin")
            {
                tb_content.SelectedText += "0";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex" || type == "bin")
            {
                tb_content.SelectedText += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex")
            {
                tb_content.SelectedText += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex")
            {
                tb_content.SelectedText += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex")
            {
                tb_content.SelectedText += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex")
            {
                tb_content.SelectedText += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex")
            {
                tb_content.SelectedText += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex")
            {
                tb_content.SelectedText += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex")
            {
                tb_content.SelectedText += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (type == "dec" || type == "hex")
            {
                tb_content.SelectedText += "9";
            }
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            if (type == "hex")
            {
                tb_content.SelectedText += "A";
            }
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            if (type == "hex")
            {
                tb_content.SelectedText += "B";
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            if (type == "hex")
            {
                tb_content.SelectedText += "C";
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            if (type == "hex")
            {
                tb_content.SelectedText += "D";
            }
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            if (type == "hex")
            {
                tb_content.SelectedText += "E";
            }
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            if (type == "hex")
            {
                tb_content.SelectedText += "F";
            }
        }


        // Rechenart
        private void btn_add_Click(object sender, EventArgs e)
        {
            arithmetic = "+";
            switch (type_code)
            {
                case 0:
                    break;

                case 1:
                    value1 = Convert.ToInt32(tb_content.Text);
                    lbl_diary.Text = value1 + " (" + type + ") " + "+ ";
                    break;
                case 2:
                    hex_value = Convert.ToString(tb_content.Text);
                    value1 = Convert.ToInt32(hex_value, 16);
                    lbl_diary.Text = hex_value + " (" + type + ") " + "+ ";
                    break;
                case 3:
                    bin_value = Convert.ToInt32(tb_content.Text);
                    value1 = Bin_to_dec(bin_value);
                    lbl_diary.Text = bin_value + " (" + type + ") " + "+ ";
                    break;

            }
            tb_content.Clear();
        }
        
        private void btn_sub_Click(object sender, EventArgs e)
        {
            arithmetic = "-";
            switch (type_code)
            {
                case 0:
                    break;

                case 1:
                    value1 = Convert.ToInt32(tb_content.Text);
                    lbl_diary.Text = value1 + " (" + type + ") " + "- ";
                    break;
                case 2:
                    hex_value = Convert.ToString(tb_content.Text);
                    value1 = Convert.ToInt32(hex_value, 16);
                    lbl_diary.Text = hex_value + " (" + type + ") " + "- ";
                    break;
                case 3:
                    bin_value = Convert.ToInt32(tb_content.Text);
                    value1 = Bin_to_dec(bin_value);
                    lbl_diary.Text = bin_value + " (" + type + ") " + "- ";
                    break;

            }
            tb_content.Clear();
        }

        // Clear-all-Button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_content.Clear();
            lbl_diary.Text = "";
            type = "";
            value1 = 0;


            lbl_result_dec.Text = "Dec: ";
            lbl_result_hex.Text = "Hex: ";
            lbl_result_bin.Text = "Bin: ";

            btn_dec.ForeColor = Color.Gray;
            btn_hex.ForeColor = Color.Gray;
            btn_bin.ForeColor = Color.Gray;


            btn_0.ForeColor = Color.Gray;
            btn_1.ForeColor = Color.Gray;
            btn_2.ForeColor = Color.Gray;
            btn_3.ForeColor = Color.Gray;
            btn_4.ForeColor = Color.Gray;
            btn_5.ForeColor = Color.Gray;
            btn_6.ForeColor = Color.Gray;
            btn_7.ForeColor = Color.Gray;
            btn_8.ForeColor = Color.Gray;
            btn_9.ForeColor = Color.Gray;
            btn_A.ForeColor = Color.Gray;
            btn_B.ForeColor = Color.Gray;
            btn_C.ForeColor = Color.Gray;
            btn_D.ForeColor = Color.Gray;
            btn_E.ForeColor = Color.Gray;
            btn_F.ForeColor = Color.Gray;
        }

        // Clear only one
        private void btn_delete_Click(object sender, EventArgs e)
        {
            tb_content.Text = tb_content.Text.Substring(0, tb_content.Text.Length - 1);
        }

        // Ergebnis-Button
        private void btn_submit_Click(object sender, EventArgs e)
        {
            switch (type_code)
            {
                case 0:
                    break;

                case 1:
                    value2 = Convert.ToInt32(tb_content.Text);
                    lbl_diary.Text = lbl_diary.Text + value2 + " (" + type + ") ";
                    break;
                case 2:
                    hex_value = Convert.ToString(tb_content.Text);
                    value2 = Convert.ToInt32(hex_value, 16);
                    lbl_diary.Text = lbl_diary.Text + hex_value + " (" + type + ") ";
                    break;
                case 3:
                    bin_value = Convert.ToInt32(tb_content.Text);
                    value2 = Bin_to_dec(bin_value);
                    lbl_diary.Text = lbl_diary.Text + bin_value + " (" + type + ") ";
                    break;
            }
            tb_content.Clear();

            Ergebnis(value1, value2);
        }


        // Binär -> Dezimal Rechner
        private int Bin_to_dec(int binNumber)
        {
            int decNumber = 0;
            int i = 0;
            int rem = 0;

            while (binNumber > 0)
            {
                rem = binNumber % 10;
                decNumber = decNumber + rem * (int)Math.Pow(2, i);
                binNumber = binNumber / 10;
                i++;
            }

            return decNumber;
        }

        // Ergebnisausgabe + rchnung
        private void Ergebnis(int v1, int v2)
        {
            string hex = "";
            int dec = 0;
            string bin = "";

            if (arithmetic == "+")
            {
                dec = v1 + v2;
            }
            else if (arithmetic == "-")
            {
                dec = v1 - v2;
            }
            hex = dec.ToString("X");
            bin = Convert.ToString(dec, 2);

            lbl_result_dec.Text = lbl_result_dec.Text + dec;
            lbl_result_bin.Text = lbl_result_bin.Text + bin;
            lbl_result_hex.Text = lbl_result_hex.Text + hex;
        }
    }
}
