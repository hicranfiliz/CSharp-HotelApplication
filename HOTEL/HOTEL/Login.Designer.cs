namespace HOTEL
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelcalisan = new System.Windows.Forms.Panel();
            this.btncalisangiris = new System.Windows.Forms.Button();
            this.txtcalisansifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTTC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelyonetici = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyoneticisifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.panelcalisan.SuspendLayout();
            this.panelyonetici.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcalisan
            // 
            this.panelcalisan.Controls.Add(this.btncalisangiris);
            this.panelcalisan.Controls.Add(this.txtcalisansifre);
            this.panelcalisan.Controls.Add(this.label8);
            this.panelcalisan.Controls.Add(this.label9);
            this.panelcalisan.Controls.Add(this.TXTTC);
            this.panelcalisan.Controls.Add(this.label7);
            this.panelcalisan.Location = new System.Drawing.Point(313, 251);
            this.panelcalisan.Name = "panelcalisan";
            this.panelcalisan.Size = new System.Drawing.Size(380, 447);
            this.panelcalisan.TabIndex = 25;
            // 
            // btncalisangiris
            // 
            this.btncalisangiris.BackColor = System.Drawing.Color.IndianRed;
            this.btncalisangiris.Location = new System.Drawing.Point(70, 263);
            this.btncalisangiris.Name = "btncalisangiris";
            this.btncalisangiris.Size = new System.Drawing.Size(246, 42);
            this.btncalisangiris.TabIndex = 22;
            this.btncalisangiris.Text = "Giriş Yap";
            this.btncalisangiris.UseVisualStyleBackColor = false;
            this.btncalisangiris.Click += new System.EventHandler(this.btncalisangiris_Click);
            // 
            // txtcalisansifre
            // 
            this.txtcalisansifre.Location = new System.Drawing.Point(24, 214);
            this.txtcalisansifre.Name = "txtcalisansifre";
            this.txtcalisansifre.PasswordChar = '*';
            this.txtcalisansifre.Size = new System.Drawing.Size(340, 30);
            this.txtcalisansifre.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "TC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Şifre:";
            // 
            // TXTTC
            // 
            this.TXTTC.Location = new System.Drawing.Point(24, 141);
            this.TXTTC.Name = "TXTTC";
            this.TXTTC.Size = new System.Drawing.Size(340, 30);
            this.TXTTC.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(124, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Çalışan Girişi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(326, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kullanıcı türü seçiniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(222, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(540, 49);
            this.label4.TabIndex = 22;
            this.label4.Text = "Otel Rezervasyon Sistemi";
            // 
            // panelyonetici
            // 
            this.panelyonetici.Controls.Add(this.button1);
            this.panelyonetici.Controls.Add(this.label5);
            this.panelyonetici.Controls.Add(this.txtyoneticisifre);
            this.panelyonetici.Controls.Add(this.label3);
            this.panelyonetici.Location = new System.Drawing.Point(313, 251);
            this.panelyonetici.Name = "panelyonetici";
            this.panelyonetici.Size = new System.Drawing.Size(385, 447);
            this.panelyonetici.TabIndex = 21;
            this.panelyonetici.Paint += new System.Windows.Forms.PaintEventHandler(this.panelyonetici_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(83, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(101, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Yönetici Girişi";
            // 
            // txtyoneticisifre
            // 
            this.txtyoneticisifre.Location = new System.Drawing.Point(28, 162);
            this.txtyoneticisifre.Name = "txtyoneticisifre";
            this.txtyoneticisifre.PasswordChar = '*';
            this.txtyoneticisifre.Size = new System.Drawing.Size(340, 30);
            this.txtyoneticisifre.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Şifre:";
            // 
            // cmbtur
            // 
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Items.AddRange(new object[] {
            "Yönetici",
            "Çalışan"});
            this.cmbtur.Location = new System.Drawing.Point(341, 205);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(336, 33);
            this.cmbtur.TabIndex = 26;
            this.cmbtur.SelectedIndexChanged += new System.EventHandler(this.cmbtur_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 774);
            this.Controls.Add(this.cmbtur);
            this.Controls.Add(this.panelcalisan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelyonetici);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelcalisan.ResumeLayout(false);
            this.panelcalisan.PerformLayout();
            this.panelyonetici.ResumeLayout(false);
            this.panelyonetici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelcalisan;
        private System.Windows.Forms.Button btncalisangiris;
        private System.Windows.Forms.TextBox txtcalisansifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelyonetici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtyoneticisifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbtur;
    }
}

