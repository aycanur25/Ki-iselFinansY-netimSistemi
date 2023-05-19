namespace WinFormsApp1
{
    partial class Kayıtol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıtol));
            kayıtoll = new Button();
            şifre = new TextBox();
            kullanıcıadı = new TextBox();
            geri = new Label();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            telefonnumarası = new TextBox();
            label3 = new Label();
            adres = new TextBox();
            label4 = new Label();
            label5 = new Label();
            doğumtarihi = new DateTimePicker();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // kayıtoll
            // 
            kayıtoll.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            kayıtoll.Location = new Point(127, 626);
            kayıtoll.Name = "kayıtoll";
            kayıtoll.Size = new Size(124, 43);
            kayıtoll.TabIndex = 20;
            kayıtoll.Text = "Kayıt ol";
            kayıtoll.UseVisualStyleBackColor = true;
            kayıtoll.Click += kayıtoll_Click;
            // 
            // şifre
            // 
            şifre.Location = new Point(89, 536);
            şifre.Multiline = true;
            şifre.Name = "şifre";
            şifre.Size = new Size(240, 40);
            şifre.TabIndex = 19;
            // 
            // kullanıcıadı
            // 
            kullanıcıadı.Location = new Point(87, 122);
            kullanıcıadı.Multiline = true;
            kullanıcıadı.Name = "kullanıcıadı";
            kullanıcıadı.Size = new Size(240, 40);
            kullanıcıadı.TabIndex = 18;
            // 
            // geri
            // 
            geri.AutoSize = true;
            geri.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            geri.ForeColor = Color.FromArgb(0, 0, 64);
            geri.Location = new Point(150, 690);
            geri.Name = "geri";
            geri.Size = new Size(49, 27);
            geri.TabIndex = 17;
            geri.Text = "Geri";
            geri.Click += geri_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(89, 506);
            label2.Name = "label2";
            label2.Size = new Size(53, 27);
            label2.TabIndex = 16;
            label2.Text = "Şifre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(89, 92);
            label9.Name = "label9";
            label9.Size = new Size(126, 27);
            label9.TabIndex = 15;
            label9.Text = "Kullanıcı Adı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(172, 43);
            label8.Name = "label8";
            label8.Size = new Size(79, 27);
            label8.TabIndex = 14;
            label8.Text = "Kayıt ol";
            // 
            // telefonnumarası
            // 
            telefonnumarası.Location = new Point(89, 209);
            telefonnumarası.Multiline = true;
            telefonnumarası.Name = "telefonnumarası";
            telefonnumarası.Size = new Size(240, 40);
            telefonnumarası.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(89, 179);
            label3.Name = "label3";
            label3.Size = new Size(170, 27);
            label3.TabIndex = 21;
            label3.Text = "Telefon Numarası";
            label3.Click += label3_Click;
            // 
            // adres
            // 
            adres.Location = new Point(89, 293);
            adres.Multiline = true;
            adres.Name = "adres";
            adres.Size = new Size(240, 98);
            adres.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(89, 263);
            label4.Name = "label4";
            label4.Size = new Size(65, 27);
            label4.TabIndex = 23;
            label4.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(89, 413);
            label5.Name = "label5";
            label5.Size = new Size(136, 27);
            label5.TabIndex = 25;
            label5.Text = "Doğum Tarihi";
            // 
            // doğumtarihi
            // 
            doğumtarihi.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            doğumtarihi.Format = DateTimePickerFormat.Short;
            doğumtarihi.Location = new Point(89, 443);
            doğumtarihi.Name = "doğumtarihi";
            doğumtarihi.Size = new Size(240, 34);
            doğumtarihi.TabIndex = 26;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(468, 1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(26, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 56;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // Kayıtol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(495, 750);
            Controls.Add(pictureBox8);
            Controls.Add(doğumtarihi);
            Controls.Add(label5);
            Controls.Add(adres);
            Controls.Add(label4);
            Controls.Add(telefonnumarası);
            Controls.Add(label3);
            Controls.Add(kayıtoll);
            Controls.Add(şifre);
            Controls.Add(kullanıcıadı);
            Controls.Add(geri);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kayıtol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıtol";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kayıtoll;
        private TextBox şifre;
        private TextBox kullanıcıadı;
        private Label geri;
        private Label label2;
        private Label label9;
        private Label label8;
        private TextBox telefonnumarası;
        private Label label3;
        private TextBox adres;
        private Label label4;
        private Label label5;
        private DateTimePicker doğumtarihi;
        private PictureBox pictureBox8;
    }
}