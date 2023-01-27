
namespace Zahlenformatrechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_content = new System.Windows.Forms.TextBox();
            this.gb_number = new System.Windows.Forms.GroupBox();
            this.gb_hex_number = new System.Windows.Forms.GroupBox();
            this.gb_cal = new System.Windows.Forms.GroupBox();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.gb_dec_number = new System.Windows.Forms.GroupBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.gb_bin_number = new System.Windows.Forms.GroupBox();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_F = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.gb_decoder = new System.Windows.Forms.GroupBox();
            this.btn_hex = new System.Windows.Forms.Button();
            this.btn_dec = new System.Windows.Forms.Button();
            this.btn_bin = new System.Windows.Forms.Button();
            this.lbl_diary = new System.Windows.Forms.Label();
            this.lbl_result_dec = new System.Windows.Forms.Label();
            this.lbl_result_hex = new System.Windows.Forms.Label();
            this.lbl_result_bin = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.gb_number.SuspendLayout();
            this.gb_hex_number.SuspendLayout();
            this.gb_cal.SuspendLayout();
            this.gb_dec_number.SuspendLayout();
            this.gb_bin_number.SuspendLayout();
            this.gb_decoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_content
            // 
            this.tb_content.BackColor = System.Drawing.SystemColors.Window;
            this.tb_content.Enabled = false;
            this.tb_content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_content.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_content.Location = new System.Drawing.Point(13, 13);
            this.tb_content.Margin = new System.Windows.Forms.Padding(4);
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(666, 29);
            this.tb_content.TabIndex = 0;
            this.tb_content.TextChanged += new System.EventHandler(this.tb_content_TextChanged);
            // 
            // gb_number
            // 
            this.gb_number.BackColor = System.Drawing.SystemColors.Window;
            this.gb_number.Controls.Add(this.gb_hex_number);
            this.gb_number.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_number.Location = new System.Drawing.Point(10, 81);
            this.gb_number.Margin = new System.Windows.Forms.Padding(4);
            this.gb_number.Name = "gb_number";
            this.gb_number.Padding = new System.Windows.Forms.Padding(4);
            this.gb_number.Size = new System.Drawing.Size(599, 368);
            this.gb_number.TabIndex = 2;
            this.gb_number.TabStop = false;
            this.gb_number.Text = "Ziffern";
            // 
            // gb_hex_number
            // 
            this.gb_hex_number.BackColor = System.Drawing.SystemColors.Window;
            this.gb_hex_number.Controls.Add(this.gb_cal);
            this.gb_hex_number.Controls.Add(this.btn_E);
            this.gb_hex_number.Controls.Add(this.btn_D);
            this.gb_hex_number.Controls.Add(this.btn_C);
            this.gb_hex_number.Controls.Add(this.btn_B);
            this.gb_hex_number.Controls.Add(this.gb_dec_number);
            this.gb_hex_number.Controls.Add(this.btn_A);
            this.gb_hex_number.Controls.Add(this.btn_F);
            this.gb_hex_number.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_hex_number.Location = new System.Drawing.Point(8, 24);
            this.gb_hex_number.Margin = new System.Windows.Forms.Padding(4);
            this.gb_hex_number.Name = "gb_hex_number";
            this.gb_hex_number.Padding = new System.Windows.Forms.Padding(4);
            this.gb_hex_number.Size = new System.Drawing.Size(591, 344);
            this.gb_hex_number.TabIndex = 3;
            this.gb_hex_number.TabStop = false;
            this.gb_hex_number.Text = "Hexadezimalzahlen";
            // 
            // gb_cal
            // 
            this.gb_cal.BackColor = System.Drawing.SystemColors.Window;
            this.gb_cal.Controls.Add(this.btn_sub);
            this.gb_cal.Controls.Add(this.btn_add);
            this.gb_cal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_cal.Location = new System.Drawing.Point(315, 240);
            this.gb_cal.Name = "gb_cal";
            this.gb_cal.Size = new System.Drawing.Size(484, 104);
            this.gb_cal.TabIndex = 14;
            this.gb_cal.TabStop = false;
            this.gb_cal.Text = "Rechenformat";
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.SystemColors.Window;
            this.btn_sub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_sub.Location = new System.Drawing.Point(137, 29);
            this.btn_sub.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(122, 63);
            this.btn_sub.TabIndex = 21;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Window;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add.Location = new System.Drawing.Point(7, 29);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 63);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_E
            // 
            this.btn_E.BackColor = System.Drawing.SystemColors.Window;
            this.btn_E.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_E.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_E.Location = new System.Drawing.Point(452, 140);
            this.btn_E.Margin = new System.Windows.Forms.Padding(4);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(129, 42);
            this.btn_E.TabIndex = 15;
            this.btn_E.Text = "E";
            this.btn_E.UseVisualStyleBackColor = false;
            this.btn_E.Click += new System.EventHandler(this.btn_E_Click);
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.SystemColors.Window;
            this.btn_D.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_D.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_D.Location = new System.Drawing.Point(452, 90);
            this.btn_D.Margin = new System.Windows.Forms.Padding(4);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(129, 42);
            this.btn_D.TabIndex = 16;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.SystemColors.Window;
            this.btn_C.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_C.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_C.Location = new System.Drawing.Point(315, 190);
            this.btn_C.Margin = new System.Windows.Forms.Padding(4);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(129, 42);
            this.btn_C.TabIndex = 17;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.SystemColors.Window;
            this.btn_B.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_B.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_B.Location = new System.Drawing.Point(315, 140);
            this.btn_B.Margin = new System.Windows.Forms.Padding(4);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(129, 42);
            this.btn_B.TabIndex = 18;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // gb_dec_number
            // 
            this.gb_dec_number.BackColor = System.Drawing.SystemColors.Window;
            this.gb_dec_number.Controls.Add(this.btn_2);
            this.gb_dec_number.Controls.Add(this.gb_bin_number);
            this.gb_dec_number.Controls.Add(this.btn_3);
            this.gb_dec_number.Controls.Add(this.btn_4);
            this.gb_dec_number.Controls.Add(this.btn_5);
            this.gb_dec_number.Controls.Add(this.btn_6);
            this.gb_dec_number.Controls.Add(this.btn_7);
            this.gb_dec_number.Controls.Add(this.btn_9);
            this.gb_dec_number.Controls.Add(this.btn_8);
            this.gb_dec_number.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_dec_number.Location = new System.Drawing.Point(8, 30);
            this.gb_dec_number.Margin = new System.Windows.Forms.Padding(4);
            this.gb_dec_number.Name = "gb_dec_number";
            this.gb_dec_number.Padding = new System.Windows.Forms.Padding(4);
            this.gb_dec_number.Size = new System.Drawing.Size(299, 314);
            this.gb_dec_number.TabIndex = 3;
            this.gb_dec_number.TabStop = false;
            this.gb_dec_number.Text = "Dezimalzahlen";
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.Window;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_2.Location = new System.Drawing.Point(16, 160);
            this.btn_2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(129, 42);
            this.btn_2.TabIndex = 7;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // gb_bin_number
            // 
            this.gb_bin_number.BackColor = System.Drawing.SystemColors.Window;
            this.gb_bin_number.Controls.Add(this.btn_0);
            this.gb_bin_number.Controls.Add(this.btn_1);
            this.gb_bin_number.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_bin_number.Location = new System.Drawing.Point(8, 30);
            this.gb_bin_number.Margin = new System.Windows.Forms.Padding(4);
            this.gb_bin_number.Name = "gb_bin_number";
            this.gb_bin_number.Padding = new System.Windows.Forms.Padding(4);
            this.gb_bin_number.Size = new System.Drawing.Size(145, 129);
            this.gb_bin_number.TabIndex = 2;
            this.gb_bin_number.TabStop = false;
            this.gb_bin_number.Text = "Binärzahlen";
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.Window;
            this.btn_0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_0.Location = new System.Drawing.Point(8, 30);
            this.btn_0.Margin = new System.Windows.Forms.Padding(4);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(129, 42);
            this.btn_0.TabIndex = 4;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.Window;
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_1.Location = new System.Drawing.Point(8, 80);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(129, 42);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.Window;
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_3.Location = new System.Drawing.Point(16, 210);
            this.btn_3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(129, 42);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.Window;
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_4.Location = new System.Drawing.Point(16, 260);
            this.btn_4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(129, 42);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.Window;
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_5.Location = new System.Drawing.Point(161, 60);
            this.btn_5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(129, 42);
            this.btn_5.TabIndex = 12;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.Window;
            this.btn_6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_6.Location = new System.Drawing.Point(161, 110);
            this.btn_6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(129, 42);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.Window;
            this.btn_7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_7.Location = new System.Drawing.Point(161, 160);
            this.btn_7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(129, 42);
            this.btn_7.TabIndex = 10;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.Window;
            this.btn_9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_9.Location = new System.Drawing.Point(161, 260);
            this.btn_9.Margin = new System.Windows.Forms.Padding(4);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(129, 42);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.Window;
            this.btn_8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_8.Location = new System.Drawing.Point(161, 210);
            this.btn_8.Margin = new System.Windows.Forms.Padding(4);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(129, 42);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.SystemColors.Window;
            this.btn_A.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_A.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_A.Location = new System.Drawing.Point(315, 90);
            this.btn_A.Margin = new System.Windows.Forms.Padding(4);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(129, 42);
            this.btn_A.TabIndex = 19;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_F
            // 
            this.btn_F.BackColor = System.Drawing.SystemColors.Window;
            this.btn_F.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_F.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_F.Location = new System.Drawing.Point(452, 190);
            this.btn_F.Margin = new System.Windows.Forms.Padding(4);
            this.btn_F.Name = "btn_F";
            this.btn_F.Size = new System.Drawing.Size(129, 42);
            this.btn_F.TabIndex = 14;
            this.btn_F.Text = "F";
            this.btn_F.UseVisualStyleBackColor = false;
            this.btn_F.Click += new System.EventHandler(this.btn_F_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_clear.Location = new System.Drawing.Point(616, 374);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 63);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "AC";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.Window;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_submit.Location = new System.Drawing.Point(687, 13);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(129, 29);
            this.btn_submit.TabIndex = 13;
            this.btn_submit.Text = "=";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // gb_decoder
            // 
            this.gb_decoder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_decoder.BackColor = System.Drawing.SystemColors.Window;
            this.gb_decoder.Controls.Add(this.btn_hex);
            this.gb_decoder.Controls.Add(this.btn_dec);
            this.gb_decoder.Controls.Add(this.btn_bin);
            this.gb_decoder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_decoder.Location = new System.Drawing.Point(617, 81);
            this.gb_decoder.Name = "gb_decoder";
            this.gb_decoder.Size = new System.Drawing.Size(200, 278);
            this.gb_decoder.TabIndex = 14;
            this.gb_decoder.TabStop = false;
            this.gb_decoder.Text = "decoder";
            this.gb_decoder.Enter += new System.EventHandler(this.gb_decoder_Enter);
            // 
            // btn_hex
            // 
            this.btn_hex.BackColor = System.Drawing.SystemColors.Window;
            this.btn_hex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_hex.Location = new System.Drawing.Point(7, 108);
            this.btn_hex.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hex.Name = "btn_hex";
            this.btn_hex.Size = new System.Drawing.Size(186, 63);
            this.btn_hex.TabIndex = 18;
            this.btn_hex.Text = "Hexadezimal";
            this.btn_hex.UseVisualStyleBackColor = false;
            this.btn_hex.Click += new System.EventHandler(this.btn_hex_Click);
            // 
            // btn_dec
            // 
            this.btn_dec.BackColor = System.Drawing.SystemColors.Window;
            this.btn_dec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dec.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_dec.Location = new System.Drawing.Point(7, 37);
            this.btn_dec.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(186, 63);
            this.btn_dec.TabIndex = 19;
            this.btn_dec.Text = "Dezimal";
            this.btn_dec.UseVisualStyleBackColor = false;
            this.btn_dec.Click += new System.EventHandler(this.btn_dec_Click);
            // 
            // btn_bin
            // 
            this.btn_bin.BackColor = System.Drawing.SystemColors.Window;
            this.btn_bin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_bin.Location = new System.Drawing.Point(7, 179);
            this.btn_bin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bin.Name = "btn_bin";
            this.btn_bin.Size = new System.Drawing.Size(186, 63);
            this.btn_bin.TabIndex = 17;
            this.btn_bin.Text = "Binär";
            this.btn_bin.UseVisualStyleBackColor = false;
            this.btn_bin.Click += new System.EventHandler(this.btn_bin_Click);
            // 
            // lbl_diary
            // 
            this.lbl_diary.AutoSize = true;
            this.lbl_diary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_diary.Location = new System.Drawing.Point(13, 50);
            this.lbl_diary.Name = "lbl_diary";
            this.lbl_diary.Size = new System.Drawing.Size(0, 21);
            this.lbl_diary.TabIndex = 16;
            // 
            // lbl_result_dec
            // 
            this.lbl_result_dec.AutoSize = true;
            this.lbl_result_dec.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_result_dec.Location = new System.Drawing.Point(333, 46);
            this.lbl_result_dec.Name = "lbl_result_dec";
            this.lbl_result_dec.Size = new System.Drawing.Size(43, 21);
            this.lbl_result_dec.TabIndex = 17;
            this.lbl_result_dec.Text = "Dec: ";
            // 
            // lbl_result_hex
            // 
            this.lbl_result_hex.AutoSize = true;
            this.lbl_result_hex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_result_hex.Location = new System.Drawing.Point(523, 46);
            this.lbl_result_hex.Name = "lbl_result_hex";
            this.lbl_result_hex.Size = new System.Drawing.Size(43, 21);
            this.lbl_result_hex.TabIndex = 18;
            this.lbl_result_hex.Text = "Hex: ";
            // 
            // lbl_result_bin
            // 
            this.lbl_result_bin.AutoSize = true;
            this.lbl_result_bin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_result_bin.Location = new System.Drawing.Point(333, 67);
            this.lbl_result_bin.Name = "lbl_result_bin";
            this.lbl_result_bin.Size = new System.Drawing.Size(39, 21);
            this.lbl_result_bin.TabIndex = 19;
            this.lbl_result_bin.Text = "Bin: ";
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_delete.Location = new System.Drawing.Point(720, 374);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 63);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "DEL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(829, 453);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_result_bin);
            this.Controls.Add(this.lbl_result_hex);
            this.Controls.Add(this.lbl_result_dec);
            this.Controls.Add(this.lbl_diary);
            this.Controls.Add(this.gb_decoder);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.gb_number);
            this.Controls.Add(this.tb_content);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahlenformatrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_number.ResumeLayout(false);
            this.gb_hex_number.ResumeLayout(false);
            this.gb_cal.ResumeLayout(false);
            this.gb_dec_number.ResumeLayout(false);
            this.gb_bin_number.ResumeLayout(false);
            this.gb_decoder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.GroupBox gb_number;
        private System.Windows.Forms.GroupBox gb_bin_number;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.GroupBox gb_hex_number;
        private System.Windows.Forms.GroupBox gb_dec_number;
        private System.Windows.Forms.GroupBox gb_cal;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox gb_decoder;
        private System.Windows.Forms.Button btn_bin;
        private System.Windows.Forms.Button btn_hex;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_diary;
        private System.Windows.Forms.Label lbl_result_dec;
        private System.Windows.Forms.Label lbl_result_hex;
        private System.Windows.Forms.Label lbl_result_bin;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_delete;
    }
}

