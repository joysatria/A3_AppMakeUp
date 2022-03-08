using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace mcInfo
{
    /// <summary>
    /// form product mata (Admin)
    /// </summary>
    /// <remarks>memiliki fungsi untuk yang berbeda dari user yaitu dengan beberapa fitur CRUD</remarks>
    public partial class ProductEyesAdm : Form
    {
        public int idmata; //deklarasi integer untuk menyimpan nilai primary key tble produk_mata

        private string kstr = "data source=DESKTOP-JF6PA4C; database=mcinfo;" +
            "User ID=sa; Password= pass123"; //deklarasi string untuk menyimpan nilai koneksi

        private SqlConnection koneksi; //deklarasi variable untuk sqlconnection

        /// <summary>
        /// method koneksi dan memanggil method lain
        /// </summary>
        /// <remarks>meimiliki fungsi untuk memanggil method dgview() dan dgviewrvw serta untuk membuat koneksi ke database</remarks>
        public ProductEyesAdm()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr); //membuat koneksi pd sql
            dgview(); //memanggil method dgview()
            refreshform(); //memanggil method refreshform()
        }

        /// <summary>
        /// class data gridview product mata
        /// </summary>
        /// <remarks>class ini memiliki fungsi untuk memanggil datagridview yang berfungsi untuk menampilkan data yang ada pada database</remarks>
        public void dgview()
        {
            koneksi.Open(); //membuka koneksi
            string str = "select * from produk_mata"; //deklarasi variable 

            //deklarasi variable data adapter untuk memanggil  database yg digunakan untuk mengisi dataset
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi); 

            DataSet ds = new DataSet(); //deklarasi dataset
            da.Fill(ds); //var da mengisi dataset 
            dgv.DataSource = ds.Tables[0]; //menampilkan datagridview dengan isi table pd dataset
            this.dgv.Columns["id_mata"].Visible = false; //tampilan pada datagridview kolum idmata disembunyikan
            koneksi.Close(); //tutup koneksi
        }

        /// <summary>
        /// method refresh
        /// </summary>
        /// <remarks>class ini memiliki fungsi untuk memuat ulang halaman agar textbox yang terisi menjadi kosong dan beberapa tombol menjadi disabled </remarks>
        public void refreshform()
        {
            idmata = 0; //set var idmata dari awal
            txtstok.Text = ""; //set edit text jd null
            txtnama.Text = ""; //set edit text jd null
            txtharga.Text = ""; //set edit text jd null
            txtberat.Text = ""; //set edit text jd null
            cbktg.Text = ""; //set edit text jd null
            btnupdate.Enabled = false;//non aktifkan tombol update
            btnsave.Enabled = true;//tombol save aktif atau bs ditekan

        }

        /// <summary>
        /// method button refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>button ini memiliki fungsi untuk merefresh halaman dengan cara mamnggil method refreshform</remarks>
        //membuat fungsi untuk tombol refresh saat ditekan
        //fungsi klik pd tombol refresh
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshform(); //memanggil method refresh form
            
        }

        /// <summary>
        /// method button update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>berfungsi untuk update data yang sudah ada</remarks>
        //fungsi klik pd tombol update
        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            //menampilan dialog
            DialogResult dialogResult = MessageBox.Show("Apakah data selesai diubah?", "Update Barang", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) // kondisi jika pengguna tekan yes
                {
                    string txnm = txtnama.Text; //deklarasi variable dan menghubungkan dg edittext pd tampilan
                    string txharga = txtharga.Text; //deklarasi variable dan menghubungkan dg edittext pd tampilan
                    string txberat = txtberat.Text; //deklarasi variable dan menghubungkan dg edittext pd tampilan
                    string txstok = txtstok.Text; //deklarasi variable dan menghubungkan dg edittext pd tampilan
                    string cbktgo = cbktg.GetItemText(cbktg.SelectedItem); //deklarasi variable dan menghubungkan dg combobox pd tampilan


                    koneksi.Open(); //membuka koneksi

                    //deklarasi string 
                    string str = "update produk_mata set nama = @nm, harga = @harga, kategori = @kategori, berat = @berat, stok = @stok where id_mata=@id";

                    SqlCommand cmd = new SqlCommand(str, koneksi); //membuat sql query yg berisikan var str 
                    cmd.CommandType = CommandType.Text; //menetapkan nilai command
                    cmd.Parameters.Add(new SqlParameter("nm", txnm)); //menambahkan objek dan menetapkan nm dg var txnm
                    cmd.Parameters.Add(new SqlParameter("id", idmata));//menambahkan objek dan menetapkan id dg var idmata
                    cmd.Parameters.Add(new SqlParameter("harga", txharga));//menambahkan objek dan menetapkan harga dg var txharga
                    cmd.Parameters.Add(new SqlParameter("kategori", cbktgo));//menambahkan objek dan menetapkan kategori dg var cbktgo
                    cmd.Parameters.Add(new SqlParameter("berat", txberat));//menambahkan objek dan menetapkan berat dg var txberat
                    cmd.Parameters.Add(new SqlParameter("stok", txstok));//menambahkan objek dan menetapkan stok dg var txstok
                    cmd.ExecuteNonQuery(); //execute sql query

                    koneksi.Close(); //tutup koneksi

                    //menampilkan pesan
                    MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgview(); //memanggil method dgview()
                    refreshform(); //memanggil method refreshform()
                    
                }                            
                
        }

        /// <summary>
        /// method delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk menghapus data yang sudah kosong atau stok tidak tersedia</remarks>
        //fungsi klik pd tombol delete
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (idmata == 0)//apabila data blm dipilih
            {
                //menampilkan pesan
                MessageBox.Show("Pilih produk",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //apabila data sudah dipilih
            {
                koneksi.Open(); //buka koneksi
                string str = "DELETE FROM produk_mata WHERE id_mata = @id"; //deklarasi variable 

                SqlCommand cmd = new SqlCommand(str, koneksi);//membuat sql query yg berisikan var str 
                cmd.CommandType = CommandType.Text; //menetapkan nilai command
                cmd.Parameters.Add(new SqlParameter("id", idmata));//menambahkan objek dan menetapkan id dg var idmata
                cmd.ExecuteNonQuery(); //execute sql query

                koneksi.Close();  //tutup koneksi
                MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information); //menampilkan pesan
                dgview(); //memanggil method dgview()
                refreshform(); //memanggil method refreshform()

            }
        }

        /// <summary>
        /// method save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk menambahkan data baru dan disimpan pada database</remarks>
        //membuat fungsi klik tombol save
        private void btnsave_Click_1(object sender, EventArgs e)
        {
            string txnm = txtnama.Text;//deklarasi variable dan menghubungkan dg edittext pd tampilan
            string txharga = txtharga.Text;//deklarasi variable dan menghubungkan dg edittext pd tampilan
            string txberat = txtberat.Text;//deklarasi variable dan menghubungkan dg edittext pd tampilan
            string txstok = txtstok.Text;//deklarasi variable dan menghubungkan dg edittext pd tampilan
            string cbktgo = cbktg.GetItemText(cbktg.SelectedItem);//deklarasi variable dan menghubungkan dg combobox pd tampilan

            if (txnm == "" || txharga == "" || txberat == "" || txstok == "" || cbktgo == "") //kondisi apabila semua edittext kosong
            {
                //menampilkan pesan
                MessageBox.Show("Data harus lengkap",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //kondisi apabila semua sudah terisi
            {
                //deklarasi variable data adapter untuk memanggil  database yg digunakan untuk mengisi dataset
                SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from produk_mata where nama = '" + txnm + "'", koneksi);
                
                DataTable dataTable = new DataTable(); //deklarasi datatable
                sda.Fill(dataTable); //var sda mengisi dataset 
                if (int.Parse(dataTable.Rows[0][0].ToString()) >= 1) //kondisi apabila nama produk sama
                {
                    //menampilkan pesan
                    MessageBox.Show("barang tersebut sudah ada",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open(); //buka koneksi

                    //deklarasi var
                    string str = "insert into produk_mata (nama, harga, kategori, berat, stok) values(@nm, @harga, @kategori, @berat, @stok)";

                    SqlCommand cmd = new SqlCommand(str, koneksi); //membuat sql query yg berisikan var str 
                    cmd.CommandType = CommandType.Text; //menetapkan nilai command
                    cmd.Parameters.Add(new SqlParameter("nm", txnm));//menambahkan objek dan menetapkan nm dg var txnm
                    cmd.Parameters.Add(new SqlParameter("harga", txharga));//menambahkan objek dan menetapkan harga dg var txharga
                    cmd.Parameters.Add(new SqlParameter("kategori", cbktgo));//menambahkan objek dan menetapkan kategori dg var txkategori
                    cmd.Parameters.Add(new SqlParameter("berat", txberat));//menambahkan objek dan menetapkan berat dg var txberat
                    cmd.Parameters.Add(new SqlParameter("stok", txstok));//menambahkan objek dan menetapkan stok dg var txstok

                    cmd.ExecuteNonQuery();//execute sql query

                    koneksi.Close();//tutup koneksi
                    MessageBox.Show("Data berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);//menampilkan pesan
                    dgview();//memanggil method dgview()
                    refreshform();//memanggil method refreshform()
                }
            }
        }

        /// <summary>
        /// method awal form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk load data ketika form pertama kali muncul/diklik dan btn update disabled</remarks>
        private void EyesProductAdm_Load(object sender, EventArgs e)
        {
            dgview(); //memanggil method dgview()
            btnupdate.Enabled = false; //nonaktifkan tombol update agar tidk bisa diklik
        }

        /// <summary>
        /// method CellContentClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memliki fungsi ketika klik table row maka akan sesuai juga dengan datagridview</remarks>
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idmata = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString()); //set value ke table sesuai cell datagridview
            txtnama.Text = dgv.CurrentRow.Cells[1].Value.ToString(); //menampilkan edit text sesuai row table pd datagridview
            txtharga.Text = dgv.CurrentRow.Cells[2].Value.ToString(); //menampilkan edit text sesuai row table pd datagridview
            cbktg.Text = dgv.CurrentRow.Cells[3].Value.ToString(); //menampilkan edit text sesuai row table pd datagridview
            txtberat.Text = dgv.CurrentRow.Cells[4].Value.ToString(); //menampilkan edit text sesuai row table pd datagridview
            txtstok.Text = dgv.CurrentRow.Cells[5].Value.ToString(); //menampilkan edit text sesuai row table pd datagridview

            btnsave.Enabled = false; //non aktifkan btn save
            btnupdate.Enabled = true; //mengaktifkan tombol update

        }

        /// <summary>
        /// method kembali
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk kembali ke halaman sebelumnya yaitu halaman menu admin</remarks>
        //fungsi klik pada gambar kembali
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuAdm mnad = new MenuAdm(); //deklarasi instace class menu admin
            this.Hide(); // menyembunyikan fform yang sdg dibuka
            mnad.Show(); //menampilkan class mnadmin
        }
    }
}
