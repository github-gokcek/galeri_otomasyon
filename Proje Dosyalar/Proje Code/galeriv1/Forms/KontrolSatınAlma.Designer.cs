
namespace galeriv1.Forms
{
    partial class KontrolSatınAlma
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SAtxtPlaka = new System.Windows.Forms.TextBox();
            this.SAtxtSeri = new System.Windows.Forms.TextBox();
            this.SAtxtMarka = new System.Windows.Forms.TextBox();
            this.SAtxtModel = new System.Windows.Forms.TextBox();
            this.SAsat = new System.Windows.Forms.Button();
            this.SAplaka = new System.Windows.Forms.Label();
            this.SAmarka = new System.Windows.Forms.Label();
            this.SAmodel = new System.Windows.Forms.Label();
            this.SAseri = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SAtoplamGelirLabel = new System.Windows.Forms.Button();
            this.SAtoplamGelirText = new System.Windows.Forms.TextBox();
            this.SAtl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SAcomboSatış = new System.Windows.Forms.ComboBox();
            this.SAtxtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHatalı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(373, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATIŞ İŞLEMLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 463);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // SAtxtPlaka
            // 
            this.SAtxtPlaka.Location = new System.Drawing.Point(379, 156);
            this.SAtxtPlaka.Name = "SAtxtPlaka";
            this.SAtxtPlaka.Size = new System.Drawing.Size(149, 20);
            this.SAtxtPlaka.TabIndex = 2;
            // 
            // SAtxtSeri
            // 
            this.SAtxtSeri.Location = new System.Drawing.Point(379, 227);
            this.SAtxtSeri.Name = "SAtxtSeri";
            this.SAtxtSeri.Size = new System.Drawing.Size(146, 20);
            this.SAtxtSeri.TabIndex = 3;
            // 
            // SAtxtMarka
            // 
            this.SAtxtMarka.Location = new System.Drawing.Point(577, 156);
            this.SAtxtMarka.Name = "SAtxtMarka";
            this.SAtxtMarka.Size = new System.Drawing.Size(149, 20);
            this.SAtxtMarka.TabIndex = 4;
            // 
            // SAtxtModel
            // 
            this.SAtxtModel.Location = new System.Drawing.Point(577, 226);
            this.SAtxtModel.Name = "SAtxtModel";
            this.SAtxtModel.Size = new System.Drawing.Size(149, 20);
            this.SAtxtModel.TabIndex = 5;
            // 
            // SAsat
            // 
            this.SAsat.BackColor = System.Drawing.Color.Transparent;
            this.SAsat.FlatAppearance.BorderSize = 0;
            this.SAsat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SAsat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAsat.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAsat.ForeColor = System.Drawing.Color.White;
            this.SAsat.Location = new System.Drawing.Point(379, 279);
            this.SAsat.Name = "SAsat";
            this.SAsat.Size = new System.Drawing.Size(540, 43);
            this.SAsat.TabIndex = 6;
            this.SAsat.Text = "SAT";
            this.SAsat.UseVisualStyleBackColor = false;
            this.SAsat.Click += new System.EventHandler(this.SAsat_Click);
            // 
            // SAplaka
            // 
            this.SAplaka.AutoSize = true;
            this.SAplaka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAplaka.ForeColor = System.Drawing.SystemColors.Control;
            this.SAplaka.Location = new System.Drawing.Point(375, 125);
            this.SAplaka.Name = "SAplaka";
            this.SAplaka.Size = new System.Drawing.Size(52, 21);
            this.SAplaka.TabIndex = 7;
            this.SAplaka.Text = "Plaka";
            // 
            // SAmarka
            // 
            this.SAmarka.AutoSize = true;
            this.SAmarka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAmarka.ForeColor = System.Drawing.SystemColors.Control;
            this.SAmarka.Location = new System.Drawing.Point(573, 125);
            this.SAmarka.Name = "SAmarka";
            this.SAmarka.Size = new System.Drawing.Size(60, 21);
            this.SAmarka.TabIndex = 7;
            this.SAmarka.Text = "Marka";
            // 
            // SAmodel
            // 
            this.SAmodel.AutoSize = true;
            this.SAmodel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAmodel.ForeColor = System.Drawing.SystemColors.Control;
            this.SAmodel.Location = new System.Drawing.Point(375, 202);
            this.SAmodel.Name = "SAmodel";
            this.SAmodel.Size = new System.Drawing.Size(36, 21);
            this.SAmodel.TabIndex = 7;
            this.SAmodel.Text = "Seri";
            // 
            // SAseri
            // 
            this.SAseri.AutoSize = true;
            this.SAseri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAseri.ForeColor = System.Drawing.SystemColors.Control;
            this.SAseri.Location = new System.Drawing.Point(573, 202);
            this.SAseri.Name = "SAseri";
            this.SAseri.Size = new System.Drawing.Size(59, 21);
            this.SAseri.TabIndex = 7;
            this.SAseri.Text = "Model";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(379, 344);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(338, 173);
            this.dataGridView2.TabIndex = 8;
            // 
            // SAtoplamGelirLabel
            // 
            this.SAtoplamGelirLabel.BackColor = System.Drawing.Color.Transparent;
            this.SAtoplamGelirLabel.FlatAppearance.BorderSize = 0;
            this.SAtoplamGelirLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SAtoplamGelirLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAtoplamGelirLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAtoplamGelirLabel.ForeColor = System.Drawing.Color.White;
            this.SAtoplamGelirLabel.Location = new System.Drawing.Point(760, 364);
            this.SAtoplamGelirLabel.Name = "SAtoplamGelirLabel";
            this.SAtoplamGelirLabel.Size = new System.Drawing.Size(159, 123);
            this.SAtoplamGelirLabel.TabIndex = 9;
            this.SAtoplamGelirLabel.Text = "Toplam\r\nGelir\r\nHesapla";
            this.SAtoplamGelirLabel.UseVisualStyleBackColor = false;
            this.SAtoplamGelirLabel.Click += new System.EventHandler(this.SAtoplamGelirLabel_Click);
            // 
            // SAtoplamGelirText
            // 
            this.SAtoplamGelirText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAtoplamGelirText.Location = new System.Drawing.Point(379, 548);
            this.SAtoplamGelirText.Name = "SAtoplamGelirText";
            this.SAtoplamGelirText.Size = new System.Drawing.Size(434, 40);
            this.SAtoplamGelirText.TabIndex = 10;
            // 
            // SAtl
            // 
            this.SAtl.AutoSize = true;
            this.SAtl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAtl.ForeColor = System.Drawing.Color.White;
            this.SAtl.Location = new System.Drawing.Point(847, 548);
            this.SAtl.Name = "SAtl";
            this.SAtl.Size = new System.Drawing.Size(41, 36);
            this.SAtl.TabIndex = 11;
            this.SAtl.Text = "TL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(46, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 13);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(603, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 13);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(766, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Satış Durumu";
            // 
            // SAcomboSatış
            // 
            this.SAcomboSatış.FormattingEnabled = true;
            this.SAcomboSatış.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.SAcomboSatış.Location = new System.Drawing.Point(770, 156);
            this.SAcomboSatış.Name = "SAcomboSatış";
            this.SAcomboSatış.Size = new System.Drawing.Size(149, 21);
            this.SAcomboSatış.TabIndex = 13;
            // 
            // SAtxtFiyat
            // 
            this.SAtxtFiyat.Location = new System.Drawing.Point(770, 227);
            this.SAtxtFiyat.Name = "SAtxtFiyat";
            this.SAtxtFiyat.Size = new System.Drawing.Size(149, 20);
            this.SAtxtFiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(766, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat";
            // 
            // labelHatalı
            // 
            this.labelHatalı.AutoSize = true;
            this.labelHatalı.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHatalı.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHatalı.Location = new System.Drawing.Point(788, 341);
            this.labelHatalı.Name = "labelHatalı";
            this.labelHatalı.Size = new System.Drawing.Size(99, 20);
            this.labelHatalı.TabIndex = 14;
            this.labelHatalı.Text = "------------------";
            // 
            // KontrolSatınAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.labelHatalı);
            this.Controls.Add(this.SAcomboSatış);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SAtl);
            this.Controls.Add(this.SAtoplamGelirText);
            this.Controls.Add(this.SAtoplamGelirLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SAseri);
            this.Controls.Add(this.SAmodel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SAmarka);
            this.Controls.Add(this.SAplaka);
            this.Controls.Add(this.SAsat);
            this.Controls.Add(this.SAtxtFiyat);
            this.Controls.Add(this.SAtxtModel);
            this.Controls.Add(this.SAtxtMarka);
            this.Controls.Add(this.SAtxtSeri);
            this.Controls.Add(this.SAtxtPlaka);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "KontrolSatınAlma";
            this.Size = new System.Drawing.Size(978, 655);
            this.Load += new System.EventHandler(this.KontrolSatınAlma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SAtxtPlaka;
        private System.Windows.Forms.TextBox SAtxtSeri;
        private System.Windows.Forms.TextBox SAtxtMarka;
        private System.Windows.Forms.TextBox SAtxtModel;
        private System.Windows.Forms.Button SAsat;
        private System.Windows.Forms.Label SAplaka;
        private System.Windows.Forms.Label SAmarka;
        private System.Windows.Forms.Label SAmodel;
        private System.Windows.Forms.Label SAseri;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button SAtoplamGelirLabel;
        private System.Windows.Forms.TextBox SAtoplamGelirText;
        private System.Windows.Forms.Label SAtl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SAcomboSatış;
        private System.Windows.Forms.TextBox SAtxtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHatalı;
    }
}
