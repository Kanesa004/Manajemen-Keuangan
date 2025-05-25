using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using manajemen_keuangan.Controller;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace manajemen_keuangan
{

    public partial class Form1 : Form
    {
        KeuanganController controller = new KeuanganController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User.Focus(); // Kursor langsung berada di textbox nama
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = User.Text; // Inputan
            string password = Password.Text;

            bool loginSukses = controller.Login(username, password);

            if (loginSukses)
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 dashboard = new Form2();
                dashboard.Show();
                this.Hide(); // tutup form login
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}