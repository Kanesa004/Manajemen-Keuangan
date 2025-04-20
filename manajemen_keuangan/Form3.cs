using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manajemen_keuangan
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e) // Digunakan untuk kembali ke form 2
        {
            Form2 form2 = new Form2(); // Membuat objek Form2
            form2.Show();
            this.Hide();
        }
    }
}
