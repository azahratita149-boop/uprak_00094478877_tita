using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tita
{
    public partial class FormRegister : Form
    {
        string connect = "server=localhost;port=3306;database;db_apotek_petugas;user=root;password";

        public FormRegister(string connect)
        {

            InitializeComponent();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            string nama = txtIdPetugas.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string konfirmasi_password = textBox1.Text.Trim();
            string Role = cmbRole.Text.Trim();

            if (nama == "" || username == "" || password == "" || konfirmasi_password == "" || Role == "")
            {
                MessageBox.Show("semua field wajib diisi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != konfirmasi_password)
            {
                MessageBox.Show("konfirmasi password tidak sesuai", "warning",, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    MySqlCommand cek = new MySqlCommand("Select count (*) from tb_apoteker WHERE username=@username", conn);
                    cek.Parameters.AddWithValue("@username", username);
                    if (Convert.ToInt32(cek.ExecuteScalar()) == 0) ;
                    {
                        MessageBox.Show("username sudah digunakan", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MySqlCommand simpan = new MySqlCommand("insert into tb_apoteker(username,password,nama_petugas,shift,role,status_aktif) values (@username,@nama,@shift,@role,1)", conn);
                    simpan.Parameters.AddWithValue("@username", username);
                    simpan.Parameters.AddWithValue("@password", password);
                    simpan.Parameters.AddWithValue("@nama", nama);
                    simpan.Parameters.AddWithValue("@konfirmasi_password", konfirmasi_password);
                    {
                        MessageBox.Show("Registrasi petugas apotek berhasil","sukses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                        {
                            
                        }
                    }
                }



            }

            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

