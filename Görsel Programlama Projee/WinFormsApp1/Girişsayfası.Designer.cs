namespace WinFormsApp1
{
    partial class Girişsayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Girişsayfası));
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            kullanıcıadı = new TextBox();
            şifre = new TextBox();
            button1 = new Button();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(80, 164);
            label9.Name = "label9";
            label9.Size = new Size(126, 27);
            label9.TabIndex = 8;
            label9.Text = "Kullanıcı Adı";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(80, 43);
            label8.Name = "label8";
            label8.Size = new Size(290, 27);
            label8.TabIndex = 7;
            label8.Text = "Kişisel Finans Yönetim Sistemi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(80, 460);
            label1.Name = "label1";
            label1.Size = new Size(79, 27);
            label1.TabIndex = 10;
            label1.Text = "Kayıt ol";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(80, 301);
            label2.Name = "label2";
            label2.Size = new Size(53, 27);
            label2.TabIndex = 9;
            label2.Text = "Şifre";
            // 
            // kullanıcıadı
            // 
            kullanıcıadı.Location = new Point(81, 207);
            kullanıcıadı.Multiline = true;
            kullanıcıadı.Name = "kullanıcıadı";
            kullanıcıadı.Size = new Size(240, 40);
            kullanıcıadı.TabIndex = 11;
            // 
            // şifre
            // 
            şifre.Location = new Point(81, 343);
            şifre.Multiline = true;
            şifre.Name = "şifre";
            şifre.Size = new Size(240, 40);
            şifre.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(197, 444);
            button1.Name = "button1";
            button1.Size = new Size(124, 43);
            button1.TabIndex = 13;
            button1.Text = "Giriş yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(447, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(26, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // Girişsayfası
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(474, 688);
            Controls.Add(pictureBox8);
            Controls.Add(button1);
            Controls.Add(şifre);
            Controls.Add(kullanıcıadı);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Girişsayfası";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Girişsayfası";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label1;
        private Label label2;
        private TextBox kullanıcıadı;
        private TextBox şifre;
        private Button button1;
        private PictureBox pictureBox8;
    }
}