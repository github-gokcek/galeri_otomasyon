
namespace galeriv1.Forms
{
    partial class KontrolMüşteriListele
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolMüşteriListele));
            this.buttonSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelTcArama = new System.Windows.Forms.Label();
            this.txtTcArama = new System.Windows.Forms.TextBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Transparent;
            this.buttonSil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSil.FlatAppearance.BorderSize = 0;
            this.buttonSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.ImageIndex = 6;
            this.buttonSil.ImageList = this.ımageList1;
            this.buttonSil.Location = new System.Drawing.Point(865, 228);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(102, 58);
            this.buttonSil.TabIndex = 42;
            this.buttonSil.Text = "Sil";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "updateV1.png");
            this.ımageList1.Images.SetKeyName(1, "cancelV1.png");
            this.ımageList1.Images.SetKeyName(2, "backspace-icon-14.jpg");
            this.ımageList1.Images.SetKeyName(3, "1661.png");
            this.ımageList1.Images.SetKeyName(4, "refresh.png");
            this.ımageList1.Images.SetKeyName(5, "backspace.png");
            this.ımageList1.Images.SetKeyName(6, "close.png");
            // 
            // labelTcArama
            // 
            this.labelTcArama.AutoSize = true;
            this.labelTcArama.BackColor = System.Drawing.Color.Transparent;
            this.labelTcArama.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTcArama.ForeColor = System.Drawing.Color.Red;
            this.labelTcArama.Location = new System.Drawing.Point(221, 146);
            this.labelTcArama.Name = "labelTcArama";
            this.labelTcArama.Size = new System.Drawing.Size(109, 33);
            this.labelTcArama.TabIndex = 41;
            this.labelTcArama.Text = "TC ARA";
            // 
            // txtTcArama
            // 
            this.txtTcArama.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcArama.Location = new System.Drawing.Point(338, 146);
            this.txtTcArama.Name = "txtTcArama";
            this.txtTcArama.Size = new System.Drawing.Size(521, 31);
            this.txtTcArama.TabIndex = 40;
            this.txtTcArama.TextChanged += new System.EventHandler(this.txtTcArama_TextChanged);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Transparent;
            this.btnİptal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnİptal.FlatAppearance.BorderSize = 0;
            this.btnİptal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.ImageIndex = 5;
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(137, 533);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(138, 57);
            this.btnİptal.TabIndex = 39;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 4;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(137, 472);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 55);
            this.btnEkle.TabIndex = 38;
            this.btnEkle.Text = "Güncelle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelMail.Location = new System.Drawing.Point(25, 318);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(41, 13);
            this.labelMail.TabIndex = 37;
            this.labelMail.Text = "E-mail";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.BackColor = System.Drawing.Color.Transparent;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdres.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelAdres.Location = new System.Drawing.Point(25, 347);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(39, 13);
            this.labelAdres.TabIndex = 36;
            this.labelAdres.Text = "Adres";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelTelefon.Location = new System.Drawing.Point(25, 289);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(50, 13);
            this.labelTelefon.TabIndex = 35;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.labelAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyad.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelAdSoyad.Location = new System.Drawing.Point(25, 260);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(61, 13);
            this.labelAdSoyad.TabIndex = 34;
            this.labelAdSoyad.Text = "Ad Soyad";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.BackColor = System.Drawing.Color.Transparent;
            this.labelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTc.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelTc.Location = new System.Drawing.Point(25, 231);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(23, 13);
            this.labelTc.TabIndex = 33;
            this.labelTc.Text = "TC";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(85, 348);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(235, 118);
            this.txtAdres.TabIndex = 32;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(85, 318);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(235, 20);
            this.txtMail.TabIndex = 31;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(85, 288);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(235, 20);
            this.txtTelefon.TabIndex = 30;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(85, 258);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(235, 20);
            this.txtAdSoyad.TabIndex = 29;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(85, 228);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(235, 20);
            this.txtTc.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 324);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // KontrolMüşteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::galeriv1.Properties.Resources.MüşteriListelemeV4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.labelTcArama);
            this.Controls.Add(this.txtTcArama);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KontrolMüşteriListele";
            this.Size = new System.Drawing.Size(978, 655);
            this.Load += new System.EventHandler(this.KontrolMüşteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label labelTcArama;
        private System.Windows.Forms.TextBox txtTcArama;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}
