namespace Sinema
{
    partial class Bilet
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
            this.Adsoyad = new System.Windows.Forms.Label();
            this.biletfiyat = new System.Windows.Forms.Label();
            this.tamsecim = new System.Windows.Forms.CheckBox();
            this.ogrencisecim = new System.Windows.Forms.CheckBox();
            this.ads = new System.Windows.Forms.TextBox();
            this.sayi = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.Label();
            this.btngetir = new System.Windows.Forms.Button();
            this.fyt = new System.Windows.Forms.Label();
            this.ttr = new System.Windows.Forms.Label();
            this.Hesapla = new System.Windows.Forms.Button();
            this.labelfilm = new System.Windows.Forms.Label();
            this.kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adsoyad
            // 
            this.Adsoyad.AutoSize = true;
            this.Adsoyad.Location = new System.Drawing.Point(32, 38);
            this.Adsoyad.Name = "Adsoyad";
            this.Adsoyad.Size = new System.Drawing.Size(63, 13);
            this.Adsoyad.TabIndex = 0;
            this.Adsoyad.Text = "Adı Soyadı :";
            // 
            // biletfiyat
            // 
            this.biletfiyat.AutoSize = true;
            this.biletfiyat.Location = new System.Drawing.Point(57, 119);
            this.biletfiyat.Name = "biletfiyat";
            this.biletfiyat.Size = new System.Drawing.Size(51, 13);
            this.biletfiyat.TabIndex = 1;
            this.biletfiyat.Text = "Bilet fiyatı";
            // 
            // tamsecim
            // 
            this.tamsecim.AutoSize = true;
            this.tamsecim.Location = new System.Drawing.Point(102, 74);
            this.tamsecim.Name = "tamsecim";
            this.tamsecim.Size = new System.Drawing.Size(47, 17);
            this.tamsecim.TabIndex = 2;
            this.tamsecim.Text = "Tam";
            this.tamsecim.UseVisualStyleBackColor = true;
            this.tamsecim.CheckedChanged += new System.EventHandler(this.tamsecim_CheckedChanged);
            // 
            // ogrencisecim
            // 
            this.ogrencisecim.AutoSize = true;
            this.ogrencisecim.Location = new System.Drawing.Point(164, 74);
            this.ogrencisecim.Name = "ogrencisecim";
            this.ogrencisecim.Size = new System.Drawing.Size(63, 17);
            this.ogrencisecim.TabIndex = 3;
            this.ogrencisecim.Text = "Öğrenci";
            this.ogrencisecim.UseVisualStyleBackColor = true;
            this.ogrencisecim.CheckedChanged += new System.EventHandler(this.ogrencisecim_CheckedChanged);
            // 
            // ads
            // 
            this.ads.Location = new System.Drawing.Point(117, 38);
            this.ads.Name = "ads";
            this.ads.Size = new System.Drawing.Size(100, 20);
            this.ads.TabIndex = 4;
            // 
            // sayi
            // 
            this.sayi.AutoSize = true;
            this.sayi.Location = new System.Drawing.Point(243, 118);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(10, 13);
            this.sayi.TabIndex = 6;
            this.sayi.Text = ".";
            // 
            // tutar
            // 
            this.tutar.AutoSize = true;
            this.tutar.Location = new System.Drawing.Point(23, 168);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(85, 13);
            this.tutar.TabIndex = 7;
            this.tutar.Text = "Ödenecek Tutar";
            // 
            // btngetir
            // 
            this.btngetir.Location = new System.Drawing.Point(26, 229);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(82, 27);
            this.btngetir.TabIndex = 9;
            this.btngetir.Text = "Bilgileri getir";
            this.btngetir.UseVisualStyleBackColor = true;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // fyt
            // 
            this.fyt.AutoSize = true;
            this.fyt.Location = new System.Drawing.Point(130, 119);
            this.fyt.Name = "fyt";
            this.fyt.Size = new System.Drawing.Size(10, 13);
            this.fyt.TabIndex = 10;
            this.fyt.Text = "-";
            // 
            // ttr
            // 
            this.ttr.AutoSize = true;
            this.ttr.Location = new System.Drawing.Point(130, 168);
            this.ttr.Name = "ttr";
            this.ttr.Size = new System.Drawing.Size(10, 13);
            this.ttr.TabIndex = 11;
            this.ttr.Text = "-";
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(117, 229);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(100, 41);
            this.Hesapla.TabIndex = 12;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.kayit_Click);
            // 
            // labelfilm
            // 
            this.labelfilm.AutoSize = true;
            this.labelfilm.Location = new System.Drawing.Point(130, 9);
            this.labelfilm.Name = "labelfilm";
            this.labelfilm.Size = new System.Drawing.Size(10, 13);
            this.labelfilm.TabIndex = 13;
            this.labelfilm.Text = ".";
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(264, 268);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(88, 38);
            this.kayit.TabIndex = 14;
            this.kayit.Text = "Kaydet ve çık";
            this.kayit.UseVisualStyleBackColor = true;
            // 
            // Bilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 318);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.labelfilm);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.ttr);
            this.Controls.Add(this.fyt);
            this.Controls.Add(this.btngetir);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.ads);
            this.Controls.Add(this.ogrencisecim);
            this.Controls.Add(this.tamsecim);
            this.Controls.Add(this.biletfiyat);
            this.Controls.Add(this.Adsoyad);
            this.Name = "Bilet";
            this.Text = "Bilet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adsoyad;
        private System.Windows.Forms.Label biletfiyat;
        private System.Windows.Forms.CheckBox tamsecim;
        private System.Windows.Forms.CheckBox ogrencisecim;
        private System.Windows.Forms.TextBox ads;
        private System.Windows.Forms.Label sayi;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.Label fyt;
        private System.Windows.Forms.Label ttr;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Label labelfilm;
        private System.Windows.Forms.Button kayit;
    }
}