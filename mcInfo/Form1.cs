using System;
using System.Windows.Forms;

namespace mcInfo
{
    /// <summary>
    /// Form awal aplikasi
    /// </summary>
    /// <remarks>berisi dua pilihan untuk login ke aplikasi, sebagai admin atau user biasa</remarks>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// class button login admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <remarks>Class iniadalah class awal yang memiliki fungsi untuk melanjutkan ke halaman selanjutnya apakah
        /// akan login sebagai admin</remarks>
        //membuat fungsi untuk tombol login saat ditekan
        private void btlogin_Click(object sender, EventArgs e)
        {
            Login_Admin logdm = new Login_Admin(); //deklarasi instance class login admin
            this.Hide(); //menyembunyikan form yang sedang diakses
            logdm.Show(); //menampilkan form class login admin


        }


        /// <summary>
        /// class button lanjut 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>class ini memiliki fungsi untuk melanjutkan ke halaman Menu utama</remarks>

        //membuat fungsi untuk tombol lanjut saat ditekan
        private void lanjut_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();  //deklarasi instance class menu
            this.Hide(); //menyembunyikan form yang sedang diakses
            mn.Show(); //menampilkan form class menu
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
