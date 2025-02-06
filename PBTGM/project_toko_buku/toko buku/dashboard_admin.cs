using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace toko_buku
{
    public partial class dashboard_admin : Form
    {
        public dashboard_admin()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDatapelanggan();
        }
        private void LoadDatapelanggan()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manajemen_buku buku = new manajemen_buku();
            buku.MdiParent = this;
            buku.Dock = DockStyle.Fill;
            buku.Show();

            dashboard_admin dashboard_Admin = new dashboard_admin();
            dashboard_Admin.FormClosed += Dashboard_Admin_FormClosed;
        }

        private void Dashboard_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            manajemen_buku buku = new manajemen_buku();
            buku.Close();   

            halaman_login login = new halaman_login();
            login.Close();
        }
    }
}
