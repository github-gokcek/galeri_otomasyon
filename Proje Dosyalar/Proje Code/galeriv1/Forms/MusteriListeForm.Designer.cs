
namespace galeriv1
{
    partial class MusteriListeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListeForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnİptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.txtTcArama = new System.Windows.Forms.TextBox();
            this.labelTcArama = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Transparent;
            this.btnİptal.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnİptal.FlatAppearance.BorderSize = 2;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.ImageIndex = 0;
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(163, 283);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(96, 51);
            this.btnİptal.TabIndex = 23;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "close.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "update.png");
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnEkle.FlatAppearance.BorderSize = 2;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 2;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(45, 283);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 51);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Güncelle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button_guncelle);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelMail.Location = new System.Drawing.Point(42, 184);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(41, 13);
            this.labelMail.TabIndex = 21;
            this.labelMail.Text = "E-mail";
            this.labelMail.Click += new System.EventHandler(this.labelMail_Click);
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.BackColor = System.Drawing.Color.Transparent;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdres.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelAdres.Location = new System.Drawing.Point(42, 213);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(39, 13);
            this.labelAdres.TabIndex = 20;
            this.labelAdres.Text = "Adres";
            this.labelAdres.Click += new System.EventHandler(this.labelAdres_Click);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelTelefon.Location = new System.Drawing.Point(42, 155);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(50, 13);
            this.labelTelefon.TabIndex = 19;
            this.labelTelefon.Text = "Telefon";
            this.labelTelefon.Click += new System.EventHandler(this.labelTelefon_Click);
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.labelAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyad.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelAdSoyad.Location = new System.Drawing.Point(42, 126);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(61, 13);
            this.labelAdSoyad.TabIndex = 18;
            this.labelAdSoyad.Text = "Ad Soyad";
            this.labelAdSoyad.Click += new System.EventHandler(this.labelAdSoyad_Click);
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.BackColor = System.Drawing.Color.Transparent;
            this.labelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTc.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelTc.Location = new System.Drawing.Point(42, 97);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(23, 13);
            this.labelTc.TabIndex = 17;
            this.labelTc.Text = "TC";
            this.labelTc.Click += new System.EventHandler(this.labelTc_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(102, 214);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(157, 50);
            this.txtAdres.TabIndex = 16;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(102, 184);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(157, 20);
            this.txtMail.TabIndex = 15;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(102, 154);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(157, 20);
            this.txtTelefon.TabIndex = 14;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(102, 124);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(157, 20);
            this.txtAdSoyad.TabIndex = 13;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(102, 94);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(157, 20);
            this.txtTc.TabIndex = 12;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // txtTcArama
            // 
            this.txtTcArama.Location = new System.Drawing.Point(617, 54);
            this.txtTcArama.Name = "txtTcArama";
            this.txtTcArama.Size = new System.Drawing.Size(144, 20);
            this.txtTcArama.TabIndex = 24;
            this.txtTcArama.TextChanged += new System.EventHandler(this.txtTcArama_TextChanged);
            // 
            // labelTcArama
            // 
            this.labelTcArama.AutoSize = true;
            this.labelTcArama.BackColor = System.Drawing.Color.Transparent;
            this.labelTcArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTcArama.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTcArama.Location = new System.Drawing.Point(559, 57);
            this.labelTcArama.Name = "labelTcArama";
            this.labelTcArama.Size = new System.Drawing.Size(52, 13);
            this.labelTcArama.TabIndex = 25;
            this.labelTcArama.Text = "TC ARA";
            this.labelTcArama.Click += new System.EventHandler(this.labelTcArama_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Transparent;
            this.buttonSil.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.buttonSil.FlatAppearance.BorderSize = 2;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.ImageIndex = 1;
            this.buttonSil.ImageList = this.ımageList1;
            this.buttonSil.Location = new System.Drawing.Point(767, 85);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 54);
            this.buttonSil.TabIndex = 26;
            this.buttonSil.Text = "Sil";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::galeriv1.Properties.Resources.neonFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 450);
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
            this.Name = "MusteriListeForm";
            this.Text = "formMüşteriListeleme";
            this.Load += new System.EventHandler(this.formMüşteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox txtTcArama;
        private System.Windows.Forms.Label labelTcArama;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.ImageList ımageList1;
    }
}