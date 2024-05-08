
namespace galeriv1
{
    partial class anaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelKırmızı = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.kontrolSözleşme1 = new galeriv1.Forms.KontrolSözleşme();
            this.kontrolSatınAlma1 = new galeriv1.Forms.KontrolSatınAlma();
            this.kontrolAraçListele1 = new galeriv1.Forms.KontrolAraçListele();
            this.araçKayıtKontrol1 = new galeriv1.Forms.araçKayıtKontrol();
            this.kontrolMüşteriListele1 = new galeriv1.Forms.KontrolMüşteriListele();
            this.kontrol11 = new galeriv1.Forms.Kontrol1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelKırmızı);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 655);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::galeriv1.Properties.Resources.autoLogo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(84, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 100);
            this.panel3.TabIndex = 8;
            // 
            // panelKırmızı
            // 
            this.panelKırmızı.BackColor = System.Drawing.Color.Red;
            this.panelKırmızı.Location = new System.Drawing.Point(25, 124);
            this.panelKırmızı.Name = "panelKırmızı";
            this.panelKırmızı.Size = new System.Drawing.Size(17, 56);
            this.panelKırmızı.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 5;
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(57, 586);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(224, 56);
            this.button7.TabIndex = 6;
            this.button7.Text = "Çıkış";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "certificate.png");
            this.ımageList1.Images.SetKeyName(1, "full-service.png");
            this.ımageList1.Images.SetKeyName(2, "add-package.png");
            this.ımageList1.Images.SetKeyName(3, "customer.png");
            this.ımageList1.Images.SetKeyName(4, "add-contact.png");
            this.ımageList1.Images.SetKeyName(5, "backspace.png");
            this.ımageList1.Images.SetKeyName(6, "best-price.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(57, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(57, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteri Listeleme";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 6;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(57, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 56);
            this.button5.TabIndex = 4;
            this.button5.Text = "Satış";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 0;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(57, 509);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 56);
            this.button6.TabIndex = 5;
            this.button6.Text = "Sözleşme";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(57, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Araç Kayıt";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 1;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(57, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Araç Listeleme";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kontrolSözleşme1
            // 
            this.kontrolSözleşme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.kontrolSözleşme1.Location = new System.Drawing.Point(285, 1);
            this.kontrolSözleşme1.Name = "kontrolSözleşme1";
            this.kontrolSözleşme1.Size = new System.Drawing.Size(978, 655);
            this.kontrolSözleşme1.TabIndex = 7;
            this.kontrolSözleşme1.Visible = false;
            // 
            // kontrolSatınAlma1
            // 
            this.kontrolSatınAlma1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.kontrolSatınAlma1.Location = new System.Drawing.Point(285, 1);
            this.kontrolSatınAlma1.Name = "kontrolSatınAlma1";
            this.kontrolSatınAlma1.Size = new System.Drawing.Size(978, 655);
            this.kontrolSatınAlma1.TabIndex = 6;
            this.kontrolSatınAlma1.Visible = false;
            // 
            // kontrolAraçListele1
            // 
            this.kontrolAraçListele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.kontrolAraçListele1.Location = new System.Drawing.Point(285, 1);
            this.kontrolAraçListele1.Name = "kontrolAraçListele1";
            this.kontrolAraçListele1.Size = new System.Drawing.Size(978, 655);
            this.kontrolAraçListele1.TabIndex = 5;
            this.kontrolAraçListele1.Visible = false;
            this.kontrolAraçListele1.Load += new System.EventHandler(this.kontrolAraçListele1_Load);
            // 
            // araçKayıtKontrol1
            // 
            this.araçKayıtKontrol1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("araçKayıtKontrol1.BackgroundImage")));
            this.araçKayıtKontrol1.Location = new System.Drawing.Point(285, 1);
            this.araçKayıtKontrol1.Name = "araçKayıtKontrol1";
            this.araçKayıtKontrol1.Size = new System.Drawing.Size(978, 655);
            this.araçKayıtKontrol1.TabIndex = 4;
            this.araçKayıtKontrol1.Visible = false;
            this.araçKayıtKontrol1.Load += new System.EventHandler(this.araçKayıtKontrol1_Load);
            // 
            // kontrolMüşteriListele1
            // 
            this.kontrolMüşteriListele1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kontrolMüşteriListele1.BackgroundImage")));
            this.kontrolMüşteriListele1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kontrolMüşteriListele1.Location = new System.Drawing.Point(285, 1);
            this.kontrolMüşteriListele1.Name = "kontrolMüşteriListele1";
            this.kontrolMüşteriListele1.Size = new System.Drawing.Size(978, 655);
            this.kontrolMüşteriListele1.TabIndex = 3;
            this.kontrolMüşteriListele1.Visible = false;
            this.kontrolMüşteriListele1.Load += new System.EventHandler(this.kontrolMüşteriListele1_Load);
            // 
            // kontrol11
            // 
            this.kontrol11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kontrol11.BackgroundImage")));
            this.kontrol11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kontrol11.Location = new System.Drawing.Point(285, 1);
            this.kontrol11.Name = "kontrol11";
            this.kontrol11.Size = new System.Drawing.Size(978, 655);
            this.kontrol11.TabIndex = 2;
            this.kontrol11.Visible = false;
            this.kontrol11.Load += new System.EventHandler(this.kontrol11_Load);
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::galeriv1.Properties.Resources.anasayfaV3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 652);
            this.Controls.Add(this.kontrolSözleşme1);
            this.Controls.Add(this.kontrolSatınAlma1);
            this.Controls.Add(this.kontrolAraçListele1);
            this.Controls.Add(this.araçKayıtKontrol1);
            this.Controls.Add(this.kontrolMüşteriListele1);
            this.Controls.Add(this.kontrol11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.anaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panelKırmızı;
        private Forms.Kontrol1 kontrol11;
        private System.Windows.Forms.Panel panel3;
        private Forms.KontrolMüşteriListele kontrolMüşteriListele1;
        private Forms.araçKayıtKontrol araçKayıtKontrol1;
        private Forms.KontrolAraçListele kontrolAraçListele1;
        private Forms.KontrolSatınAlma kontrolSatınAlma1;
        private Forms.KontrolSözleşme kontrolSözleşme1;
    }
}

