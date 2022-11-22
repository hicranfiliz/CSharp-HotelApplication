namespace HOTEL
{
    partial class Kayitmusteri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pickercikis = new System.Windows.Forms.DateTimePicker();
            this.pickergiris = new System.Windows.Forms.DateTimePicker();
            this.txtgunsayisi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnrezervasyonyap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // txtadı
            // 
            this.txtadı.Location = new System.Drawing.Point(147, 91);
            this.txtadı.Name = "txtadı";
            this.txtadı.Size = new System.Drawing.Size(232, 30);
            this.txtadı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC :";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(147, 151);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(232, 30);
            this.txttc.TabIndex = 3;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(147, 202);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(232, 30);
            this.txttelefon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(147, 258);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(232, 30);
            this.txtadres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres:";
            // 
            // pickercikis
            // 
            this.pickercikis.Location = new System.Drawing.Point(561, 135);
            this.pickercikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickercikis.Name = "pickercikis";
            this.pickercikis.Size = new System.Drawing.Size(346, 30);
            this.pickercikis.TabIndex = 48;
            this.pickercikis.ValueChanged += new System.EventHandler(this.pickercikis_ValueChanged);
            this.pickercikis.EnabledChanged += new System.EventHandler(this.pickercikis_EnabledChanged);
            this.pickercikis.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.pickercikis_ChangeUICues);
            // 
            // pickergiris
            // 
            this.pickergiris.Location = new System.Drawing.Point(561, 86);
            this.pickergiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickergiris.Name = "pickergiris";
            this.pickergiris.Size = new System.Drawing.Size(346, 30);
            this.pickergiris.TabIndex = 47;
            // 
            // txtgunsayisi
            // 
            this.txtgunsayisi.Enabled = false;
            this.txtgunsayisi.Location = new System.Drawing.Point(561, 186);
            this.txtgunsayisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgunsayisi.Name = "txtgunsayisi";
            this.txtgunsayisi.Size = new System.Drawing.Size(346, 30);
            this.txtgunsayisi.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Gün Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // btnrezervasyonyap
            // 
            this.btnrezervasyonyap.BackColor = System.Drawing.Color.IndianRed;
            this.btnrezervasyonyap.Location = new System.Drawing.Point(561, 241);
            this.btnrezervasyonyap.Name = "btnrezervasyonyap";
            this.btnrezervasyonyap.Size = new System.Drawing.Size(346, 42);
            this.btnrezervasyonyap.TabIndex = 53;
            this.btnrezervasyonyap.Text = "Rezervasyon Yap";
            this.btnrezervasyonyap.UseVisualStyleBackColor = false;
            this.btnrezervasyonyap.Click += new System.EventHandler(this.btnrezervasyonyap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(975, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 50);
            this.button1.TabIndex = 54;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kayitmusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnrezervasyonyap);
            this.Controls.Add(this.pickercikis);
            this.Controls.Add(this.pickergiris);
            this.Controls.Add(this.txtgunsayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadı);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kayitmusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayitmusteri";
            this.Load += new System.EventHandler(this.Kayitmusteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker pickercikis;
        private System.Windows.Forms.DateTimePicker pickergiris;
        private System.Windows.Forms.TextBox txtgunsayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnrezervasyonyap;
        private System.Windows.Forms.Button button1;
    }
}