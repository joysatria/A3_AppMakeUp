using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcInfo
{
    /// <summary>
    /// form Menu (Admin)
    /// </summary>
    /// <remarks>berisi menu utama untuk admin yaitu untuk product mata dan bibirs</remarks>
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method next ke form selanjutnya
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk melanjutkan ke form bibir namun sebagai admin</remarks>
        //membuat fungsi klik saat gambar ditekan
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductLipAdm lipadm = new ProductLipAdm(); //deklarasi instance class producylipadmin
            this.Hide(); //menyembunyikan form yang sedang diakses
            lipadm.Show(); //menampilkan form class produklipadmin
        }

        /// <summary>
        /// method next ke form selanjutnya
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk melanjutkan ke form mata namun sebagai admin</remarks>
        //membuat fungsi klik saat gambar ditekan
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductEyesAdm eyy = new ProductEyesAdm(); //deklarasi instance class product eyes admin
            this.Hide(); //menyembunyikan form yang sedang diakses
            eyy.Show(); //menampilkan form class produkeyesadmin
        }

        /// <summary>
        /// button kembali
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk kembali/logout ke halaman sebelumnya yaitu halaman login sebgai admin</remarks>
        //membuat fungsi klik saat gambar ditekan
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login_Admin logad = new Login_Admin(); //deklarasi instance class login admin
            this.Hide(); //menyembunyikan form yang sedang diakses
            logad.Show(); //menampilkan form class loginadmin
        }
    }
}
