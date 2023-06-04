namespace WinFormsApp1
{
    partial class Gidersayfası
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gidersayfası));
            panel1 = new Panel();
            label14 = new Label();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            kaydet1 = new Button();
            kategoriler1 = new ComboBox();
            tarih1 = new DateTimePicker();
            miktar1 = new TextBox();
            açıklama1 = new TextBox();
            giderkaynağı = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            toplamgider = new Label();
            label22 = new Label();
            pictureBox8 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 796);
            panel1.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 0, 192);
            label14.Location = new Point(53, 375);
            label14.Name = "label14";
            label14.Size = new Size(61, 27);
            label14.TabIndex = 51;
            label14.Text = "Gider";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(53, 753);
            label7.Name = "label7";
            label7.Size = new Size(56, 27);
            label7.TabIndex = 42;
            label7.Text = "Çıkış";
            label7.Click += label7_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(13, 732);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 48);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 41;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(53, 525);
            label6.Name = "label6";
            label6.Size = new Size(185, 27);
            label6.TabIndex = 40;
            label6.Text = "Gider Görüntüleme";
            label6.Click += label6_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(13, 504);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(53, 453);
            label5.Name = "label5";
            label5.Size = new Size(178, 27);
            label5.TabIndex = 38;
            label5.Text = "Gelir Görüntüleme";
            label5.Click += label5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(13, 432);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 37;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 43;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(13, 354);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(53, 296);
            label3.Name = "label3";
            label3.Size = new Size(54, 27);
            label3.TabIndex = 34;
            label3.Text = "Gelir";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(13, 275);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(53, 199);
            label2.Name = "label2";
            label2.Size = new Size(111, 27);
            label2.TabIndex = 32;
            label2.Text = "Dashboard";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(67, 38);
            label1.Name = "label1";
            label1.Size = new Size(91, 27);
            label1.TabIndex = 30;
            label1.Text = "KiFiYöSi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 48);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 0, 64);
            label13.Location = new Point(785, 39);
            label13.Name = "label13";
            label13.Size = new Size(179, 35);
            label13.TabIndex = 49;
            label13.Text = "Gider Bilgileri";
            // 
            // kaydet1
            // 
            kaydet1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            kaydet1.Location = new Point(834, 649);
            kaydet1.Name = "kaydet1";
            kaydet1.Size = new Size(113, 44);
            kaydet1.TabIndex = 48;
            kaydet1.Text = "Kaydet";
            kaydet1.UseVisualStyleBackColor = true;
            kaydet1.Click += kaydet1_Click;
            // 
            // kategoriler1
            // 
            kategoriler1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kategoriler1.FormattingEnabled = true;
            kategoriler1.Items.AddRange(new object[] { "Yemek", "Alış-veriş", "Sağlık", "Ev", "Araba", "Gezi", "Diğer" });
            kategoriler1.Location = new Point(952, 172);
            kategoriler1.Name = "kategoriler1";
            kategoriler1.Size = new Size(224, 31);
            kategoriler1.TabIndex = 47;
            // 
            // tarih1
            // 
            tarih1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tarih1.Format = DateTimePickerFormat.Short;
            tarih1.Location = new Point(952, 317);
            tarih1.Name = "tarih1";
            tarih1.Size = new Size(224, 34);
            tarih1.TabIndex = 46;
            // 
            // miktar1
            // 
            miktar1.Location = new Point(592, 317);
            miktar1.Multiline = true;
            miktar1.Name = "miktar1";
            miktar1.Size = new Size(184, 40);
            miktar1.TabIndex = 45;
            // 
            // açıklama1
            // 
            açıklama1.Location = new Point(776, 467);
            açıklama1.Multiline = true;
            açıklama1.Name = "açıklama1";
            açıklama1.Size = new Size(227, 146);
            açıklama1.TabIndex = 44;
            // 
            // giderkaynağı
            // 
            giderkaynağı.Location = new Point(592, 172);
            giderkaynağı.Multiline = true;
            giderkaynağı.Name = "giderkaynağı";
            giderkaynağı.Size = new Size(184, 43);
            giderkaynağı.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 0, 64);
            label12.Location = new Point(592, 287);
            label12.Name = "label12";
            label12.Size = new Size(66, 27);
            label12.TabIndex = 42;
            label12.Text = "Miktar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 0, 64);
            label11.Location = new Point(592, 142);
            label11.Name = "label11";
            label11.Size = new Size(139, 27);
            label11.TabIndex = 41;
            label11.Text = "Gider Kaynağı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 0, 64);
            label10.Location = new Point(952, 142);
            label10.Name = "label10";
            label10.Size = new Size(110, 27);
            label10.TabIndex = 40;
            label10.Text = "Kategoriler";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(952, 287);
            label9.Name = "label9";
            label9.Size = new Size(58, 27);
            label9.TabIndex = 39;
            label9.Text = "Tarih";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(776, 437);
            label8.Name = "label8";
            label8.Size = new Size(94, 27);
            label8.TabIndex = 38;
            label8.Text = "Açıklama";
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Controls.Add(toplamgider);
            panel4.Controls.Add(label22);
            panel4.Location = new Point(282, 525);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 88);
            panel4.TabIndex = 37;
            // 
            // toplamgider
            // 
            toplamgider.AutoSize = true;
            toplamgider.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            toplamgider.ForeColor = Color.FromArgb(0, 0, 64);
            toplamgider.Location = new Point(13, 49);
            toplamgider.Name = "toplamgider";
            toplamgider.Size = new Size(36, 27);
            toplamgider.TabIndex = 6;
            toplamgider.Text = "TL";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(0, 0, 64);
            label22.Location = new Point(23, 12);
            label22.Name = "label22";
            label22.Size = new Size(135, 27);
            label22.TabIndex = 5;
            label22.Text = "Toplam Gider";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1382, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(26, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 50;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // Gidersayfası
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1409, 796);
            Controls.Add(pictureBox8);
            Controls.Add(label13);
            Controls.Add(kaydet1);
            Controls.Add(kategoriler1);
            Controls.Add(tarih1);
            Controls.Add(miktar1);
            Controls.Add(açıklama1);
            Controls.Add(giderkaynağı);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gidersayfası";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gidersayfası";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label13;
        private Button kaydet1;
        private ComboBox kategoriler1;
        private DateTimePicker tarih1;
        private TextBox miktar1;
        private TextBox açıklama1;
        private TextBox giderkaynağı;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel panel4;
        private Label toplamgider;
        private Label label22;
        private Label label7;
        private PictureBox pictureBox7;
        private Label label6;
        private PictureBox pictureBox6;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox8;
        private Label label14;
    }
}