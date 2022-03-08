using System;
using System.Windows.Forms;

namespace mcInfo
{
    /// <summary>
    /// Form Login Admin
    /// </summary>
    /// <remarks>Berisi </remarks>
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method login admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk login sebagai admin dengan username dan password yang telah dibuat developer</remarks>
        //memberi fungsi saat tombol login ditekan
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //kondisi jika uname dan password blum diisi
            if (edtuname.Text != string.Empty || edtpass.Text != string.Empty)
            {
                //kondisi jika uname dan password bnr
                if (edtuname.Text == "admin" && edtpass.Text == "123")
                {
                    MenuAdm mn = new MenuAdm(); //deklarasi instance class menuadm
                    mn.Show(); //menampilkan form class menu
                    this.Hide(); //menyembunyikan form yang sedang diakses
                }
                else
                {
                    //kondisi jika uname atau password tidak sesuai
                    MessageBox.Show("Something wrong.");
                }
            }
            else
            {
                //kondisi uname dan pass kosong
                MessageBox.Show("Username and password cannot be empty");
            }
        }

        /// <summary>
        /// method button kembali
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk kembali ke halaman utama aplikasi ini</remarks>
        //memberi fungsi pada tombol kembali
        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); //deklarasi instance class form1
            this.Hide(); //menyembunyikan form yang sedang diakses
            f1.Show(); //menampilkan form class form1
        }
    }
}
