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
    public partial class manajemen_buku : Form
    {
        public manajemen_buku()
        {
            InitializeComponent();
        }

        private string koneksi = "server=localhost;user=root;database=db_tokobuku;port=3306;";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MenampilkanData(); // Fungsi akan di jalankan
        }

        //Fungsi atau Function untuk menampilkan data buku

        private void MenampilkanData()
        {
            dataGridView1.Rows.Clear();

            using(MySqlConnection konek = new MySqlConnection( koneksi ))
            {
                konek.Open();
                string query = "SELECT * FROM books"; //Query mengambil data buku / menampilkan

                using(MySqlCommand cmd = new MySqlCommand(query,konek))
                {
                    // Jika ingin menggunakan CMD, harus di antara kurung kurawal

                    using(MySqlDataReader hasil = cmd.ExecuteReader())
                    {
                        while (hasil.Read())
                        {
                            string id_buku = hasil["id_buku"].ToString();
                            string kode_buku = hasil["kode_buku"].ToString();
                            string judul = hasil["judul"].ToString();
                            string pengarang = hasil["pengarang"].ToString();
                            string penerbit = hasil["penerbit"].ToString();
                            string harga = hasil["harga"].ToString();
                            string stok = hasil["stok"].ToString();
                            
                            dataGridView1.Rows.Add(id_buku, kode_buku, judul, pengarang, penerbit, harga, stok);
                        }
                    }

                }
            }
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            using(MySqlConnection connection = new MySqlConnection(koneksi))
            {
                connection.Open();
                string query = "insert into books(kode_buku,judul,pengarang,penerbit,harga,stok) VALUES\r\n(@kode_buku,@judul,@pengarang,@penerbit,@harga,@stok)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@kode_buku", tbkode.Text);
                    cmd.Parameters.AddWithValue("@judul", tbjudul.Text);
                    cmd.Parameters.AddWithValue("@pengarang", tbpengarang.Text);
                    cmd.Parameters.AddWithValue("@penerbit", tbpenerbit.Text);
                    cmd.Parameters.AddWithValue("@harga", tbharga.Text);
                    cmd.Parameters.AddWithValue("@stok", tbstok.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil disimpan", "sukses");

                    MenampilkanData();

                    tbIdBuku.Clear();
                    tbkode.Clear();
                    tbjudul.Clear();
                    tbpengarang.Clear();
                    tbpenerbit.Clear();
                    tbharga.Clear();
                    tbstok.Clear();
                }
            }
        }

        private void bPerbarui_Click(object sender, EventArgs e)
        {
            using(MySqlConnection connection = new MySqlConnection(koneksi))
            {
                connection.Open();
                string query = "update books set kode_buku = @kode_buku, judul = @judul, pengarang = @pengarang, penerbit = @penerbit, harga = @harga, stok = @stok where id_buku = @id_buku";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_buku", tbIdBuku.Text);
                    cmd.Parameters.AddWithValue("@kode_buku", tbkode.Text);
                    cmd.Parameters.AddWithValue("@judul", tbjudul.Text);
                    cmd.Parameters.AddWithValue("@pengarang", tbpengarang.Text);
                    cmd.Parameters.AddWithValue("@penerbit", tbpenerbit.Text);
                    cmd.Parameters.AddWithValue("@harga", tbharga.Text);
                    cmd.Parameters.AddWithValue("@stok", tbstok.Text);

                    int cekdata_buku = cmd.ExecuteNonQuery();

                    if (cekdata_buku > 0)
                    {
                        MessageBox.Show("data berhasil diperbarui");
                    }
                    else
                    {
                        MessageBox.Show("data tidak di temukan");
                    }

                    MenampilkanData();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdBuku.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbkode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbjudul.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbpengarang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbpenerbit.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbharga.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbstok.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void bHapus_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();

                string query = "delete from books where id_buku = @id_buku";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_buku", tbIdBuku.Text);

                    int cekid_buku = cmd.ExecuteNonQuery();

                    if (cekid_buku > 0)
                    {
                        MessageBox.Show("data berhasil dihapus");
                        MenampilkanData();
                    }
                    else
                    {
                        MessageBox.Show("data tidak di temukan");
                    }
                }
            }
        }

        private void bKosongkan_Click(object sender, EventArgs e)
        {
            tbIdBuku.Clear();
            tbkode.Clear();
            tbjudul.Clear();
            tbpengarang.Clear();
            tbpenerbit.Clear();
            tbharga.Clear();
            tbstok.Clear();
        }
    }
}
