namespace ManajemenKeuanganApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LKU = new System.Windows.Forms.DataGridView();
            this.simpan = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.perbarui = new System.Windows.Forms.Button();
            this.pemasukan = new System.Windows.Forms.RadioButton();
            this.pengeluaran = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.LKU)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAJEMEN KEUANGAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategori";
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Location = new System.Drawing.Point(137, 159);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(179, 21);
            this.kategori.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jumlah Uang";
            // 
            // JU
            // 
            this.JU.Location = new System.Drawing.Point(137, 192);
            this.JU.Name = "JU";
            this.JU.Size = new System.Drawing.Size(179, 20);
            this.JU.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Deskripsi";
            // 
            // deskripsi
            // 
            this.deskripsi.Location = new System.Drawing.Point(385, 101);
            this.deskripsi.Multiline = true;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(382, 111);
            this.deskripsi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "LAPORAN KEUANGAN";
            // 
            // LKU
            // 
            this.LKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LKU.Location = new System.Drawing.Point(33, 274);
            this.LKU.Name = "LKU";
            this.LKU.Size = new System.Drawing.Size(734, 128);
            this.LKU.TabIndex = 12;
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(647, 229);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(120, 25);
            this.simpan.TabIndex = 13;
            this.simpan.Text = "SIMPAN";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(89, 416);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(103, 22);
            this.hapus.TabIndex = 14;
            this.hapus.Text = "HAPUS";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(327, 416);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(103, 22);
            this.edit.TabIndex = 15;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // perbarui
            // 
            this.perbarui.Location = new System.Drawing.Point(598, 416);
            this.perbarui.Name = "perbarui";
            this.perbarui.Size = new System.Drawing.Size(103, 22);
            this.perbarui.TabIndex = 16;
            this.perbarui.Text = "PERBARUI";
            this.perbarui.UseVisualStyleBackColor = true;
            this.perbarui.Click += new System.EventHandler(this.perbarui_Click);
            // 
            // pemasukan
            // 
            this.pemasukan.AutoSize = true;
            this.pemasukan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemasukan.Location = new System.Drawing.Point(54, 119);
            this.pemasukan.Name = "pemasukan";
            this.pemasukan.Size = new System.Drawing.Size(102, 21);
            this.pemasukan.TabIndex = 17;
            this.pemasukan.TabStop = true;
            this.pemasukan.Text = "PEMASUKAN";
            this.pemasukan.UseVisualStyleBackColor = true;
            this.pemasukan.CheckedChanged += new System.EventHandler(this.pemasukan_CheckedChanged);
            // 
            // pengeluaran
            // 
            this.pengeluaran.AutoSize = true;
            this.pengeluaran.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaran.Location = new System.Drawing.Point(192, 119);
            this.pengeluaran.Name = "pengeluaran";
            this.pengeluaran.Size = new System.Drawing.Size(115, 21);
            this.pengeluaran.TabIndex = 18;
            this.pengeluaran.TabStop = true;
            this.pengeluaran.Text = "PENGELUARAN";
            this.pengeluaran.UseVisualStyleBackColor = true;
            this.pengeluaran.CheckedChanged += new System.EventHandler(this.pengeluaran_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pengeluaran);
            this.Controls.Add(this.pemasukan);
            this.Controls.Add(this.perbarui);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.LKU);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LKU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox JU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deskripsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView LKU;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button perbarui;
        private System.Windows.Forms.RadioButton pemasukan;
        private System.Windows.Forms.RadioButton pengeluaran;
    }
}

