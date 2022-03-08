using System;
using System.Windows.Forms;

namespace mcInfo
{
    /// <summary>
    /// form Menu
    /// </summary>
    /// <remarks>berisi menu utama yang ditampilkan yaitu product mata dan bibir</remarks>
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// class product lip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>class ini memiliki fungsi untuk melanjutkan ke form class product bibir</remarks>
        //membuat fungsi klik saat gambar ditekan
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductLip bbr = new ProductLip(); //deklarasi instance class productlip
            this.Hide(); //menyembunyikan form yang sedang diakses
            bbr.Show(); //menampilkan form class product lip
        }


        /// <summary>
        /// class product eyes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>class ini memiliki fungsi untuk melankutkan ke form product mata</remarks>
        //membuat fungsi klik saat gambar ditekan
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductEyes eyy = new ProductEyes(); //deklarasi instance class producteyes
            this.Hide(); //menyembunyikan form yang sedang diakses
            eyy.Show(); //menampilkan form class producteyes
        }

        /// <summary>
        /// class button home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>class ini memiliki fungsi untuk kembali ke halaman awal aplikasi</remarks>
        //membuat fungsi klik saat gambar ditekan
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); //deklarasi instance class form1
            this.Hide(); //menyembunyikan form yang sedang diakses
            f1.Show(); //menampilkan form class form1
        }
    }
}
