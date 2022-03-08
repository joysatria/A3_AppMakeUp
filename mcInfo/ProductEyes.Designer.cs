namespace mcInfo
{
    partial class ProductEyes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEyes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvrvw = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtnm = new System.Windows.Forms.TextBox();
            this.edtreview = new System.Windows.Forms.RichTextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnreview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrvw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 237);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(862, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "REVIEW PRODUK";
            this.label3.UseWaitCursor = true;
            // 
            // dgvrvw
            // 
            this.dgvrvw.BackgroundColor = System.Drawing.Color.White;
            this.dgvrvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrvw.Location = new System.Drawing.Point(683, 91);
            this.dgvrvw.Name = "dgvrvw";
            this.dgvrvw.RowHeadersWidth = 51;
            this.dgvrvw.RowTemplate.Height = 24;
            this.dgvrvw.Size = new System.Drawing.Size(482, 167);
            this.dgvrvw.TabIndex = 13;
            this.dgvrvw.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "pilih produk";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "nama";
            this.label1.UseWaitCursor = true;
            // 
            // edtnm
            // 
            this.edtnm.Location = new System.Drawing.Point(683, 416);
            this.edtnm.Name = "edtnm";
            this.edtnm.Size = new System.Drawing.Size(231, 22);
            this.edtnm.TabIndex = 19;
            this.edtnm.UseWaitCursor = true;
            // 
            // edtreview
            // 
            this.edtreview.Location = new System.Drawing.Point(935, 351);
            this.edtreview.Name = "edtreview";
            this.edtreview.Size = new System.Drawing.Size(230, 87);
            this.edtreview.TabIndex = 18;
            this.edtreview.Text = "";
            this.edtreview.UseWaitCursor = true;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Plum;
            this.btnsave.Location = new System.Drawing.Point(1094, 444);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(71, 27);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Simpan";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.UseWaitCursor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(683, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.UseWaitCursor = true;
            // 
            // btnreview
            // 
            this.btnreview.BackColor = System.Drawing.Color.Plum;
            this.btnreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreview.BackgroundImage")));
            this.btnreview.Location = new System.Drawing.Point(794, 283);
            this.btnreview.Name = "btnreview";
            this.btnreview.Size = new System.Drawing.Size(120, 27);
            this.btnreview.TabIndex = 15;
            this.btnreview.Text = "Ulas produk";
            this.btnreview.UseVisualStyleBackColor = false;
            this.btnreview.UseWaitCursor = true;
            this.btnreview.Click += new System.EventHandler(this.btnreview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.BackColor = System.Drawing.Color.Plum;
            this.buttonrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonrefresh.BackgroundImage")));
            this.buttonrefresh.Location = new System.Drawing.Point(957, 283);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(120, 27);
            this.buttonrefresh.TabIndex = 26;
            this.buttonrefresh.Text = "Refresh";
            this.buttonrefresh.UseVisualStyleBackColor = false;
            this.buttonrefresh.UseWaitCursor = true;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // ProductEyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1230, 530);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtnm);
            this.Controls.Add(this.edtreview);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvrvw);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "ProductEyes";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eyes Product";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.ProductEyes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrvw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvrvw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtnm;
        private System.Windows.Forms.RichTextBox edtreview;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonrefresh;
    }
}