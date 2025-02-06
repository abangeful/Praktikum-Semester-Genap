namespace toko_buku
{
    partial class manajemen_buku
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbstok = new System.Windows.Forms.TextBox();
            this.tbpenerbit = new System.Windows.Forms.TextBox();
            this.tbpengarang = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.tbjudul = new System.Windows.Forms.TextBox();
            this.tbkode = new System.Windows.Forms.TextBox();
            this.tbIdBuku = new System.Windows.Forms.TextBox();
            this.bSimpan = new System.Windows.Forms.Button();
            this.bHapus = new System.Windows.Forms.Button();
            this.bKosongkan = new System.Windows.Forms.Button();
            this.bPerbarui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(116, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 342);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id buku";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "kode buku";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "judul";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "pengarang";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // column5
            // 
            this.column5.HeaderText = "penerbit";
            this.column5.MinimumWidth = 8;
            this.column5.Name = "column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "harga";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "stok";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbstok);
            this.panel2.Controls.Add(this.tbpenerbit);
            this.panel2.Controls.Add(this.tbpengarang);
            this.panel2.Controls.Add(this.tbharga);
            this.panel2.Controls.Add(this.tbjudul);
            this.panel2.Controls.Add(this.tbkode);
            this.panel2.Controls.Add(this.tbIdBuku);
            this.panel2.Location = new System.Drawing.Point(116, 375);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 211);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Penerbit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pengarang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Judul Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kode Buku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Buku";
            // 
            // tbstok
            // 
            this.tbstok.Location = new System.Drawing.Point(744, 57);
            this.tbstok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbstok.Name = "tbstok";
            this.tbstok.Size = new System.Drawing.Size(148, 26);
            this.tbstok.TabIndex = 6;
            // 
            // tbpenerbit
            // 
            this.tbpenerbit.Location = new System.Drawing.Point(537, 57);
            this.tbpenerbit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpenerbit.Name = "tbpenerbit";
            this.tbpenerbit.Size = new System.Drawing.Size(148, 26);
            this.tbpenerbit.TabIndex = 5;
            // 
            // tbpengarang
            // 
            this.tbpengarang.Location = new System.Drawing.Point(324, 131);
            this.tbpengarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpengarang.Name = "tbpengarang";
            this.tbpengarang.Size = new System.Drawing.Size(148, 26);
            this.tbpengarang.TabIndex = 4;
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(537, 131);
            this.tbharga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(148, 26);
            this.tbharga.TabIndex = 3;
            // 
            // tbjudul
            // 
            this.tbjudul.Location = new System.Drawing.Point(324, 57);
            this.tbjudul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbjudul.Name = "tbjudul";
            this.tbjudul.Size = new System.Drawing.Size(148, 26);
            this.tbjudul.TabIndex = 2;
            // 
            // tbkode
            // 
            this.tbkode.Location = new System.Drawing.Point(123, 131);
            this.tbkode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbkode.Name = "tbkode";
            this.tbkode.Size = new System.Drawing.Size(148, 26);
            this.tbkode.TabIndex = 1;
            // 
            // tbIdBuku
            // 
            this.tbIdBuku.Location = new System.Drawing.Point(123, 57);
            this.tbIdBuku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdBuku.Name = "tbIdBuku";
            this.tbIdBuku.Size = new System.Drawing.Size(148, 26);
            this.tbIdBuku.TabIndex = 0;
            // 
            // bSimpan
            // 
            this.bSimpan.Location = new System.Drawing.Point(287, 614);
            this.bSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(112, 35);
            this.bSimpan.TabIndex = 3;
            this.bSimpan.Text = "simpan";
            this.bSimpan.UseVisualStyleBackColor = true;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // bHapus
            // 
            this.bHapus.Location = new System.Drawing.Point(452, 614);
            this.bHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(112, 35);
            this.bHapus.TabIndex = 4;
            this.bHapus.Text = "hapus";
            this.bHapus.UseVisualStyleBackColor = true;
            this.bHapus.Click += new System.EventHandler(this.bHapus_Click);
            // 
            // bKosongkan
            // 
            this.bKosongkan.Location = new System.Drawing.Point(618, 614);
            this.bKosongkan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bKosongkan.Name = "bKosongkan";
            this.bKosongkan.Size = new System.Drawing.Size(112, 35);
            this.bKosongkan.TabIndex = 5;
            this.bKosongkan.Text = "kosongkan";
            this.bKosongkan.UseVisualStyleBackColor = true;
            this.bKosongkan.Click += new System.EventHandler(this.bKosongkan_Click);
            // 
            // bPerbarui
            // 
            this.bPerbarui.Location = new System.Drawing.Point(782, 614);
            this.bPerbarui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPerbarui.Name = "bPerbarui";
            this.bPerbarui.Size = new System.Drawing.Size(112, 35);
            this.bPerbarui.TabIndex = 6;
            this.bPerbarui.Text = "perbarui";
            this.bPerbarui.UseVisualStyleBackColor = true;
            this.bPerbarui.Click += new System.EventHandler(this.bPerbarui_Click);
            // 
            // manajemen_buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 692);
            this.Controls.Add(this.bPerbarui);
            this.Controls.Add(this.bKosongkan);
            this.Controls.Add(this.bHapus);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "manajemen_buku";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbstok;
        private System.Windows.Forms.TextBox tbpenerbit;
        private System.Windows.Forms.TextBox tbpengarang;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.TextBox tbjudul;
        private System.Windows.Forms.TextBox tbkode;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button bKosongkan;
        private System.Windows.Forms.Button bPerbarui;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdBuku;
    }
}