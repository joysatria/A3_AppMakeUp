using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace mcInfo
{
    /// <summary>
    /// form pruduct bibir
    /// </summary>
    /// <remarks>berisi data-data yang ada pada product bibir dan ulasan terhadap productnya</remarks>
    public partial class ProductLip : Form
    {
        private string kstr = "data source=DESKTOP-JF6PA4C; database=mcinfo;" +
            "User ID=sa; Password= pass123";//deklarasi string untuk menyimpan nilai koneksi

        private SqlConnection koneksi;//deklarasi variable untuk sqlconnection

        /// <summary>
        /// method koneksi dan memanggil method lain
        /// </summary>
        /// <remarks>meimiliki fungsi untuk memanggil method dgview() dan dgviewrvw serta untuk membuat koneksi ke data base</remarks>
        public ProductLip()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);//membuat koneksi pd sql
            dgview(); //memanggil method dgview()
            dgviewrvw(); //memanggil method dgviewrvw()
        }

        /// <summary>
        /// method awal form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>method ini memiliki fungsi untuk halaman awal ketika form dibuka dengan ada beberapa button, combobox dan edittext yang disabled </remarks>
        private void ProductLip_Load(object sender, EventArgs e)
        {
            btnsave.Enabled = false; //nonaktifkan tombol save
            comboBox1.Enabled = false; //nonaktifkan combobox
            edtnm.Enabled = false; //nonaktifkan editteks
            edtreview.Enabled = false; //nonaktifkan editteks
        }


        /// <summary>
        /// class data gridview product bibir
        /// </summary>
        /// <remarks>class ini memiliki fungsi untuk memanggil datagridview yang berfungsi untuk menampilkan data yang ada pada database</remarks>
        private void dgview()
        {
            koneksi.Open(); //membuka koneksi
            string str = "select * from produk_bibir"; //deklarasi variable 

            //deklarasi variable data adapter untuk memanggil  database yg digunakan untuk mengisi dataset
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);

            DataSet ds = new DataSet(); //deklarasi dataset
            da.Fill(ds); //var da mengisi dataset 
            dataGridView1.DataSource = ds.Tables[0]; //menampilkan datagridview dengan isi table pd dataset
            this.dataGridView1.Columns["id_bibir"].Visible = false; //tampilan pada datagridview kolum idbibir disembunyikan
            koneksi.Close(); //tutup koneksi
        }

        /// <summary>
        /// method datagridview bagian testimonial
        /// </summary>
        /// <remarks>method ini memiliki funsgi untuk memanggil data testimonial yang ada pada database untuk dimunculkan pada datagridview</remarks>
        private void dgviewrvw()
        {
            koneksi.Open(); //membuka koneksi
            string str = "select * from testimonial_bibir"; //deklarasi variable 

            //deklarasi variable data adapter untuk memanggil  database yg digunakan untuk mengisi dataset
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);

            DataSet ds = new DataSet(); //deklarasi dataset
            da.Fill(ds); //var da mengisi dataset 
            dgvrvw.DataSource = ds.Tables[0]; //menampilkan datagridview dengan isi table pd dataset
            this.dgvrvw.Columns["id_bibir"].Visible = false; //tampilan pada datagridview kolum idbibir disembunyikan
            this.dgvrvw.Columns["id_user"].Visible = false; //tampilan pada datagridview kolum iduser disembunyikan
            koneksi.Close();//tutup koneksi
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        /// <summary>
        /// method button review
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>method ini memliki fungsi untuk membukan edittext review dan membuka beberapa tombol lain</remarks>
        private void btnreview_Click(object sender, EventArgs e)
        {
            btnreview.Enabled = false; //nonaktifkan tombol review
            btnsave.Enabled = true; //aktifkan tombol save
            comboBox1.Enabled = true; //aktifkan combobox
            edtnm.Enabled = true; //aktifkan editteks
            edtreview.Enabled = true; //aktifkan editteks
            edtnm.Text = ""; //set editteks kosong
            edtreview.Text = ""; //set editteks kosong
            cbxProduk(); //memanggil method cbxproduk()

        }

        /// <summary>
        /// class combobox produk
        /// </summary>
        /// <remarks>class ini memliki fungsi untuk memilih produk bibir yang disediakan/tersedia pada database</remarks>
        private void cbxProduk()
        {
            koneksi.Open(); //buka koneksi
            string str = "select nama from produk_bibir"; //deklarasi variable 
            SqlCommand cmd = new SqlCommand(str, koneksi);//membuat sql query yg berisikan var str 

            //deklarasi variable data adapter untuk memanggil  database yg digunakan untuk mengisi dataset
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi); 

            DataSet ds = new DataSet(); //deklarasi dataset
            da.Fill(ds);//var da mengisi dataset 
            cmd.ExecuteReader();//execute sql query
            koneksi.Close();//tutup koneksi

            comboBox1.DisplayMember = "nama"; //combobox menampilkan nama dari table produkbibir
            comboBox1.ValueMember = "id_bibir"; //combobox set value berdasarkan id_bibir
            comboBox1.DataSource = ds.Tables[0]; //set datasource untuk combobox dari dataset
        }

        /// <summary>
        /// class refresh
        /// </summary>
        /// <remarks>class ini memiliki fungsi untuk memuat ulang halaman agar textbox yang terisi menjadi kosong dan beberapa tombol menjadi disabled </remarks>
        private void refreshform()
        {
            btnreview.Enabled = true;//nonaktifkan tombol review
            btnsave.Enabled = false; //nonaktifkan tombol save
            comboBox1.Enabled = false;  //nonaktifkan combobox
            edtnm.Enabled = false; //nonaktifkan editteks
            edtreview.Enabled = false; //nonaktifkan editteks
            edtnm.Text = ""; //set editteks kosong
            edtreview.Text = ""; //set editteks kosong
        }

        /// <summary>
        /// method button refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>button ini memiliki fungsi untuk merefresh halaman dengan cara mamnggil method refreshform</remarks>
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refreshform(); //memanggil method refreshform()
        }

        /// <summary>
        /// button save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks> memiliki fungsi untuk menyimpan data yang telah terisi ulasan dan produknya untuk disimpan pada database</remarks>
        private void btnsave_Click(object sender, EventArgs e)
        {
            string nama = edtnm.Text;//deklarasi variable dan menghubungkan dg edittext pd tampilan
            string rvw = edtreview.Text;//deklarasi variable dan menghubungkan dg edittext pd tampilan
            string produk = comboBox1.Text;//deklarasi variable dan menghubungkan dg combobox pd tampilan

            int x = 0; //deklarasi variable dg value sama dengan nol

            if (rvw == "" || nama == "" || produk == "")//kondisi apabila semua edittext kosong
            {
                //menampilkan pesan
                MessageBox.Show("Data harus lengkap",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();//buka koneksi

                string strs = "select id_bibir from produk_bibir where nama = @nm"; //deklarasi var
                SqlCommand cm = new SqlCommand(strs, koneksi);//membuat sql query yg berisikan var strs
                cm.CommandType = CommandType.Text;//menetapkan nilai command
                cm.Parameters.Add(new SqlParameter("@nm", produk));//menambahkan objek dan menetapkan nm dg var produk

                SqlDataReader dr = cm.ExecuteReader(); //deklarasi sql reader
                while (dr.Read()) //perulangan membaca data
                {
                    x = int.Parse(dr["id_bibir"].ToString()); //x berisikan nilai hasil dari query
                }
                dr.Close(); //tutup data reader

                //deklarasi var
                string str = "insert into testimonial_bibir (nama, nama_produk, ulasan, id_bibir)"
                    + " values(@nm,@nmpr, @ulasan, @idbr)";
                SqlCommand cmd = new SqlCommand(str, koneksi);//membuat sql query yg berisikan var str 
                cmd.CommandType = CommandType.Text;//menetapkan nilai command

                cmd.Parameters.Add(new SqlParameter("nm", nama));//menambahkan objek dan menetapkan nm dg var nama
                cmd.Parameters.Add(new SqlParameter("ulasan", rvw));//menambahkan objek dan menetapkan ulasan dg var rvw
                cmd.Parameters.Add(new SqlParameter("idbr", x));//menambahkan objek dan menetapkan idbr dg var x
                cmd.Parameters.Add(new SqlParameter("nmpr", produk));//menambahkan objek dan menetapkan nmpr dg var produk
                cmd.ExecuteNonQuery();//execute sql query

                koneksi.Close();//tutup koneksi

                MessageBox.Show("Data berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information); //menampilkan pesan
                dgviewrvw();//memanggil method dgviewrvw()
                refreshform();//memanggil method refreshform()
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void edtnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// button kembali
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>memiliki fungsi untuk kembali ke halaman menu</remarks>
        //fungsi klik pada gambar kembali
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu mnad = new Menu(); //deklarasi instace class menu 
            this.Hide(); // menyembunyikan fform yang sdg dibuka
            mnad.Show(); //menampilkan class mn
        }
    }
}
