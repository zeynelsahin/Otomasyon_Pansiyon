namespace UI
{
    partial class Konaklamalar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxOda = new System.Windows.Forms.ComboBox();
            this.cbxMusteri = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxAktifMi = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxToplamFiyat = new System.Windows.Forms.TextBox();
            this.dgwKonaklamalar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.tbxFiltre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKonaklamalar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpkCikisTarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpkGirisTarihi);
            this.groupBox1.Controls.Add(this.cbxOda);
            this.groupBox1.Controls.Add(this.cbxMusteri);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbxAktifMi);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxToplamFiyat);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(205, 640);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpkCikisTarihi
            // 
            this.dtpkCikisTarihi.Location = new System.Drawing.Point(21, 249);
            this.dtpkCikisTarihi.Name = "dtpkCikisTarihi";
            this.dtpkCikisTarihi.Size = new System.Drawing.Size(129, 20);
            this.dtpkCikisTarihi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // dtpkGirisTarihi
            // 
            this.dtpkGirisTarihi.Location = new System.Drawing.Point(21, 188);
            this.dtpkGirisTarihi.Name = "dtpkGirisTarihi";
            this.dtpkGirisTarihi.Size = new System.Drawing.Size(129, 20);
            this.dtpkGirisTarihi.TabIndex = 8;
            // 
            // cbxOda
            // 
            this.cbxOda.FormattingEnabled = true;
            this.cbxOda.Items.AddRange(new object[] {
            "Tümü.."});
            this.cbxOda.Location = new System.Drawing.Point(18, 123);
            this.cbxOda.Name = "cbxOda";
            this.cbxOda.Size = new System.Drawing.Size(132, 21);
            this.cbxOda.TabIndex = 7;
            this.cbxOda.SelectedIndexChanged += new System.EventHandler(this.cbxOda_SelectedIndexChanged);
            // 
            // cbxMusteri
            // 
            this.cbxMusteri.FormattingEnabled = true;
            this.cbxMusteri.Items.AddRange(new object[] {
            "Tümü.."});
            this.cbxMusteri.Location = new System.Drawing.Point(18, 61);
            this.cbxMusteri.Name = "cbxMusteri";
            this.cbxMusteri.Size = new System.Drawing.Size(132, 21);
            this.cbxMusteri.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(18, 466);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 38);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Müşteri Seçiniz";
            // 
            // cbxAktifMi
            // 
            this.cbxAktifMi.FormattingEnabled = true;
            this.cbxAktifMi.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbxAktifMi.Location = new System.Drawing.Point(18, 375);
            this.cbxAktifMi.Name = "cbxAktifMi";
            this.cbxAktifMi.Size = new System.Drawing.Size(132, 21);
            this.cbxAktifMi.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(18, 420);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 38);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Aktif Mi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giriş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda Seçiniz";
            // 
            // tbxToplamFiyat
            // 
            this.tbxToplamFiyat.Location = new System.Drawing.Point(18, 310);
            this.tbxToplamFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.tbxToplamFiyat.Name = "tbxToplamFiyat";
            this.tbxToplamFiyat.Size = new System.Drawing.Size(132, 20);
            this.tbxToplamFiyat.TabIndex = 0;
            // 
            // dgwKonaklamalar
            // 
            this.dgwKonaklamalar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwKonaklamalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKonaklamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKonaklamalar.Location = new System.Drawing.Point(251, 182);
            this.dgwKonaklamalar.Margin = new System.Windows.Forms.Padding(4);
            this.dgwKonaklamalar.Name = "dgwKonaklamalar";
            this.dgwKonaklamalar.Size = new System.Drawing.Size(632, 335);
            this.dgwKonaklamalar.TabIndex = 4;
            this.dgwKonaklamalar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKonaklamalar_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxFiltre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(251, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 98);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrele";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Müşteriye Göre";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(251, 136);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 38);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tbxFiltre
            // 
            this.tbxFiltre.Location = new System.Drawing.Point(16, 61);
            this.tbxFiltre.Name = "tbxFiltre";
            this.tbxFiltre.Size = new System.Drawing.Size(100, 20);
            this.tbxFiltre.TabIndex = 4;
            this.tbxFiltre.TextChanged += new System.EventHandler(this.tbxFiltre_TextChanged);
            // 
            // Konaklamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 704);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwKonaklamalar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Konaklamalar";
            this.Text = "Konaklamalar";
            this.Load += new System.EventHandler(this.Konaklamalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKonaklamalar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxAktifMi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxToplamFiyat;
        private System.Windows.Forms.DataGridView dgwKonaklamalar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpkCikisTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkGirisTarihi;
        private System.Windows.Forms.ComboBox cbxOda;
        private System.Windows.Forms.ComboBox cbxMusteri;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox tbxFiltre;
    }
}