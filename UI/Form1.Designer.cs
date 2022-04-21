namespace UI
{
    partial class Form1
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
            this.tbxİsim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbxTCNo = new System.Windows.Forms.MaskedTextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.mtbxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMusteriId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSoyisim = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKonaklamalar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxİsim
            // 
            this.tbxİsim.Location = new System.Drawing.Point(18, 108);
            this.tbxİsim.Margin = new System.Windows.Forms.Padding(4);
            this.tbxİsim.Name = "tbxİsim";
            this.tbxİsim.Size = new System.Drawing.Size(132, 22);
            this.tbxİsim.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbxTCNo);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbxCinsiyet);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.mtbxTelefon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxMusteriId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.tbxSoyisim);
            this.groupBox1.Controls.Add(this.tbxİsim);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(205, 640);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle";
            // 
            // mtbxTCNo
            // 
            this.mtbxTCNo.Location = new System.Drawing.Point(18, 451);
            this.mtbxTCNo.Margin = new System.Windows.Forms.Padding(4);
            this.mtbxTCNo.Mask = "00000000000";
            this.mtbxTCNo.Name = "mtbxTCNo";
            this.mtbxTCNo.Size = new System.Drawing.Size(132, 22);
            this.mtbxTCNo.TabIndex = 5;
            this.mtbxTCNo.ValidatingType = typeof(int);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(21, 539);
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
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Müşteri Id";
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(18, 390);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(132, 24);
            this.cbxCinsiyet.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(21, 493);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 38);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // mtbxTelefon
            // 
            this.mtbxTelefon.Location = new System.Drawing.Point(22, 240);
            this.mtbxTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.mtbxTelefon.Mask = "(999) 000-0000";
            this.mtbxTelefon.Name = "mtbxTelefon";
            this.mtbxTelefon.Size = new System.Drawing.Size(132, 22);
            this.mtbxTelefon.TabIndex = 2;
            this.mtbxTelefon.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "TC No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cinsiyet";
            // 
            // tbxMusteriId
            // 
            this.tbxMusteriId.Enabled = false;
            this.tbxMusteriId.Location = new System.Drawing.Point(18, 56);
            this.tbxMusteriId.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMusteriId.Name = "tbxMusteriId";
            this.tbxMusteriId.Size = new System.Drawing.Size(132, 22);
            this.tbxMusteriId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(18, 310);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(132, 22);
            this.tbxEmail.TabIndex = 0;
            // 
            // tbxSoyisim
            // 
            this.tbxSoyisim.Location = new System.Drawing.Point(18, 169);
            this.tbxSoyisim.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSoyisim.Name = "tbxSoyisim";
            this.tbxSoyisim.Size = new System.Drawing.Size(132, 22);
            this.tbxSoyisim.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(240, 14);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 56);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.Location = new System.Drawing.Point(240, 97);
            this.dgwMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.Size = new System.Drawing.Size(923, 448);
            this.dgwMusteriler.TabIndex = 3;
            this.dgwMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellContentClick);
            this.dgwMusteriler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriler_CellEnter);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Location = new System.Drawing.Point(376, 14);
            this.btnOdalar.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(128, 56);
            this.btnOdalar.TabIndex = 5;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Odalar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnKonaklamalar
            // 
            this.btnKonaklamalar.Location = new System.Drawing.Point(522, 13);
            this.btnKonaklamalar.Margin = new System.Windows.Forms.Padding(4);
            this.btnKonaklamalar.Name = "btnKonaklamalar";
            this.btnKonaklamalar.Size = new System.Drawing.Size(128, 56);
            this.btnKonaklamalar.TabIndex = 5;
            this.btnKonaklamalar.Text = "Konaklamalar";
            this.btnKonaklamalar.UseVisualStyleBackColor = true;
            this.btnKonaklamalar.Click += new System.EventHandler(this.btnKonaklamalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 682);
            this.Controls.Add(this.btnKonaklamalar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgwMusteriler);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxİsim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbxTelefon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxMusteriId;
        private System.Windows.Forms.DataGridView dgwMusteriler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MaskedTextBox mtbxTCNo;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKonaklamalar;
    }
}

