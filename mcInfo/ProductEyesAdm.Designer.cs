﻿namespace mcInfo
{
    partial class ProductEyesAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEyesAdm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.cbktg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtberat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(21, 60);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(768, 196);
            this.dgv.TabIndex = 3;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Stok :";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(140, 367);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(170, 22);
            this.txtstok.TabIndex = 21;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(140, 328);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(170, 22);
            this.txtharga.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Harga :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama :";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(140, 289);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(170, 22);
            this.txtnama.TabIndex = 17;
            // 
            // cbktg
            // 
            this.cbktg.FormattingEnabled = true;
            this.cbktg.Items.AddRange(new object[] {
            "Mascara",
            "Eyeliner",
            "Eyeshadow",
            "Pensil Alis"});
            this.cbktg.Location = new System.Drawing.Point(498, 330);
            this.cbktg.Name = "cbktg";
            this.cbktg.Size = new System.Drawing.Size(170, 24);
            this.cbktg.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "gram";
            // 
            // txtberat
            // 
            this.txtberat.Location = new System.Drawing.Point(498, 287);
            this.txtberat.Name = "txtberat";
            this.txtberat.Size = new System.Drawing.Size(124, 22);
            this.txtberat.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Berat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kategori :";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Plum;
            this.btnupdate.Location = new System.Drawing.Point(850, 140);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(92, 36);
            this.btnupdate.TabIndex = 32;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Plum;
            this.btnrefresh.Location = new System.Drawing.Point(850, 75);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(92, 36);
            this.btnrefresh.TabIndex = 31;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Plum;
            this.btndelete.Location = new System.Drawing.Point(850, 205);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(92, 36);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Plum;
            this.btnsave.Location = new System.Drawing.Point(737, 328);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(205, 36);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Add New Item";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ProductEyesAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cbktg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtberat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.dgv);
            this.Name = "ProductEyesAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eyes Product (Admin)";
            this.Load += new System.EventHandler(this.EyesProductAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.ComboBox cbktg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtberat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}