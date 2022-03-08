
namespace mcInfo
{
    partial class Login_Admin
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
            this.uname = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.edtuname = new System.Windows.Forms.TextBox();
            this.edtpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Location = new System.Drawing.Point(288, 134);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(73, 17);
            this.uname.TabIndex = 0;
            this.uname.Text = "Username";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(288, 213);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(69, 17);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // edtuname
            // 
            this.edtuname.Location = new System.Drawing.Point(291, 171);
            this.edtuname.Name = "edtuname";
            this.edtuname.Size = new System.Drawing.Size(221, 22);
            this.edtuname.TabIndex = 2;
            // 
            // edtpass
            // 
            this.edtpass.Location = new System.Drawing.Point(291, 250);
            this.edtpass.Name = "edtpass";
            this.edtpass.PasswordChar = '*';
            this.edtpass.Size = new System.Drawing.Size(221, 22);
            this.edtpass.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Orange;
            this.btnlogin.Location = new System.Drawing.Point(404, 312);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(94, 33);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Orange;
            this.btnback.Location = new System.Drawing.Point(303, 312);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 33);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Kembali";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.edtpass);
            this.Controls.Add(this.edtuname);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uname);
            this.Name = "Login_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox edtuname;
        private System.Windows.Forms.TextBox edtpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnback;
    }
}