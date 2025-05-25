namespace manajemen_keuangan
{
    partial class Form2
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
            this.laporan = new System.Windows.Forms.Button();
            this.pengeluaran = new System.Windows.Forms.RadioButton();
            this.pemasukan = new System.Windows.Forms.RadioButton();
            this.perbarui = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.simpan = new System.Windows.Forms.Button();
            this.DGVtransaksi = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.JU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.seacrh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAJEMEN KEUANGAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laporan
            // 
            this.laporan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.laporan.Location = new System.Drawing.Point(80, 414);
            this.laporan.Name = "laporan";
            this.laporan.Size = new System.Drawing.Size(102, 24);
            this.laporan.TabIndex = 37;
            this.laporan.Text = "LAPORAN";
            this.laporan.UseVisualStyleBackColor = false;
            this.laporan.Click += new System.EventHandler(this.laporan_Click);
            // 
            // pengeluaran
            // 
            this.pengeluaran.AutoSize = true;
            this.pengeluaran.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaran.Location = new System.Drawing.Point(186, 119);
            this.pengeluaran.Name = "pengeluaran";
            this.pengeluaran.Size = new System.Drawing.Size(115, 21);
            this.pengeluaran.TabIndex = 36;
            this.pengeluaran.TabStop = true;
            this.pengeluaran.Text = "PENGELUARAN";
            this.pengeluaran.UseVisualStyleBackColor = true;
            this.pengeluaran.CheckedChanged += new System.EventHandler(this.pengeluaran_CheckedChanged);
            // 
            // pemasukan
            // 
            this.pemasukan.AutoSize = true;
            this.pemasukan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemasukan.Location = new System.Drawing.Point(53, 119);
            this.pemasukan.Name = "pemasukan";
            this.pemasukan.Size = new System.Drawing.Size(102, 21);
            this.pemasukan.TabIndex = 35;
            this.pemasukan.TabStop = true;
            this.pemasukan.Text = "PEMASUKAN";
            this.pemasukan.UseVisualStyleBackColor = true;
            this.pemasukan.CheckedChanged += new System.EventHandler(this.pemasukan_CheckedChanged);
            // 
            // perbarui
            // 
            this.perbarui.BackColor = System.Drawing.SystemColors.ControlLight;
            this.perbarui.Location = new System.Drawing.Point(328, 414);
            this.perbarui.Name = "perbarui";
            this.perbarui.Size = new System.Drawing.Size(91, 24);
            this.perbarui.TabIndex = 34;
            this.perbarui.Text = "PERBARUI";
            this.perbarui.UseVisualStyleBackColor = false;
            this.perbarui.Click += new System.EventHandler(this.perbarui_Click);
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hapus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.hapus.Location = new System.Drawing.Point(601, 414);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(91, 24);
            this.hapus.TabIndex = 32;
            this.hapus.Text = "HAPUS";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // simpan
            // 
            this.simpan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.simpan.Location = new System.Drawing.Point(646, 188);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(120, 25);
            this.simpan.TabIndex = 31;
            this.simpan.Text = "SIMPAN";
            this.simpan.UseVisualStyleBackColor = false;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // DGVtransaksi
            // 
            this.DGVtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtransaksi.Location = new System.Drawing.Point(32, 276);
            this.DGVtransaksi.Name = "DGVtransaksi";
            this.DGVtransaksi.Size = new System.Drawing.Size(734, 126);
            this.DGVtransaksi.TabIndex = 30;
            this.DGVtransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVtransaksi_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "KEUANGAN";
            // 
            // deskripsi
            // 
            this.deskripsi.Location = new System.Drawing.Point(384, 107);
            this.deskripsi.Multiline = true;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(382, 68);
            this.deskripsi.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Deskripsi";
            // 
            // JU
            // 
            this.JU.Location = new System.Drawing.Point(136, 187);
            this.JU.Name = "JU";
            this.JU.Size = new System.Drawing.Size(179, 20);
            this.JU.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Jumlah Uang";
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Location = new System.Drawing.Point(136, 154);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(179, 21);
            this.kategori.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tanggal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(646, 247);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 23);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // seacrh
            // 
            this.seacrh.Location = new System.Drawing.Point(461, 249);
            this.seacrh.Name = "seacrh";
            this.seacrh.Size = new System.Drawing.Size(179, 20);
            this.seacrh.TabIndex = 39;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seacrh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.laporan);
            this.Controls.Add(this.pengeluaran);
            this.Controls.Add(this.pemasukan);
            this.Controls.Add(this.perbarui);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.DGVtransaksi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.JU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVtransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button laporan;
        private System.Windows.Forms.RadioButton pengeluaran;
        private System.Windows.Forms.RadioButton pemasukan;
        private System.Windows.Forms.Button perbarui;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.DataGridView DGVtransaksi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deskripsi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox seacrh;
    }
}