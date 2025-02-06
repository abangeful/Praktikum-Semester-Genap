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
    public partial class halaman_login : Form
    {
        private string koneksi = "server=localhost;user=root;database=db_tokobuku;port=3306;";


        public halaman_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            using(MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();

                string query = "SELECT role FROM users WHERE username = @username AND password = @password;";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    //Untuk mengisi nilai username dan password
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text);

                    using(MySqlDataReader hasil = cmd.ExecuteReader())
                    {
                        //Untuk Mencari Role dari User
                        if (hasil.Read())
                        {
                            string role = hasil["role"].ToString();

                            if (role == "admin")
                            {
                                dashboard_admin dashboard_Admin = new dashboard_admin();
                                dashboard_Admin.Show();

                                this.Hide();
                            } 
                            else if (role == "kasir")
                            {
                                dashboard_kasir dashboard_Kasir = new dashboard_kasir();
                                dashboard_Kasir.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password Salah");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password Salah");
                        }
                    }
                }
            }
        }
    }
}
