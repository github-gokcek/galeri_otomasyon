
namespace galeriv1
{
    partial class MusteriKayitForm
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
            this.labelTc = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.BackColor = System.Drawing.Color.Transparent;
            this.labelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTc.ForeColor = System.Drawing.Color.Red;
            this.labelTc.Location = new System.Drawing.Point(46, 31);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(23, 13);
            this.labelTc.TabIndex = 0;
            this.labelTc.Text = "TC";
            this.labelTc.Click += new System.EventHandler(this.labelTc_Click);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(120, 28);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(160, 20);
            this.txtTc.TabIndex = 1;
            this.txtTc.Text = "+";
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(120, 64);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(160, 20);
            this.txtAdSoyad.TabIndex = 3;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.labelAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyad.ForeColor = System.Drawing.Color.Red;
            this.labelAdSoyad.Location = new System.Drawing.Point(46, 67);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(70, 13);
            this.labelAdSoyad.TabIndex = 2;
            this.labelAdSoyad.Text = "AD SOYAD";
            this.labelAdSoyad.Click += new System.EventHandler(this.labelAdSoyad_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 100);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(160, 20);
            this.txtTelefon.TabIndex = 5;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.ForeColor = System.Drawing.Color.Red;
            this.labelTelefon.Location = new System.Drawing.Point(46, 103);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(63, 13);
            this.labelTelefon.TabIndex = 4;
            this.labelTelefon.Text = "TELEFON";
            this.labelTelefon.Click += new System.EventHandler(this.labelTelefon_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(120, 136);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 20);
            this.txtMail.TabIndex = 7;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.ForeColor = System.Drawing.Color.Red;
            this.labelMail.Location = new System.Drawing.Point(46, 139);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(48, 13);
            this.labelMail.TabIndex = 6;
            this.labelMail.Text = "E-MAİL";
            this.labelMail.Click += new System.EventHandler(this.labelMail_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(120, 172);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(160, 55);
            this.txtAdres.TabIndex = 9;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.BackColor = System.Drawing.Color.Transparent;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdres.ForeColor = System.Drawing.Color.Red;
            this.labelAdres.Location = new System.Drawing.Point(46, 175);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(49, 13);
            this.labelAdres.TabIndex = 8;
            this.labelAdres.Text = "ADRES";
            this.labelAdres.Click += new System.EventHandler(this.labelAdres_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::galeriv1.Properties.Resources.customerAddBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.labelTc);
            this.Name = "MusteriKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMüşteriKayıt";
            this.Load += new System.EventHandler(this.formMüşteriKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}