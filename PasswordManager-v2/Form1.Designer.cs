namespace PasswordManager_v2
{
    partial class Form1
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
            this.ServerName = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.serverbx = new System.Windows.Forms.TextBox();
            this.userbx = new System.Windows.Forms.TextBox();
            this.passbx = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(35, 39);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(69, 13);
            this.ServerName.TabIndex = 2;
            this.ServerName.Text = "Server Name";
            this.ServerName.Click += new System.EventHandler(this.ServerName_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(35, 85);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(35, 131);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // serverbx
            // 
            this.serverbx.Location = new System.Drawing.Point(129, 36);
            this.serverbx.Name = "serverbx";
            this.serverbx.Size = new System.Drawing.Size(100, 20);
            this.serverbx.TabIndex = 5;
            this.serverbx.TextChanged += new System.EventHandler(this.serverbx_TextChanged);
            // 
            // userbx
            // 
            this.userbx.Location = new System.Drawing.Point(129, 82);
            this.userbx.Name = "userbx";
            this.userbx.Size = new System.Drawing.Size(100, 20);
            this.userbx.TabIndex = 6;
            this.userbx.TextChanged += new System.EventHandler(this.userbx_TextChanged);
            // 
            // passbx
            // 
            this.passbx.Location = new System.Drawing.Point(129, 128);
            this.passbx.Name = "passbx";
            this.passbx.Size = new System.Drawing.Size(100, 20);
            this.passbx.TabIndex = 7;
            this.passbx.TextChanged += new System.EventHandler(this.passbx_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(105, 189);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.passbx);
            this.Controls.Add(this.userbx);
            this.Controls.Add(this.serverbx);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ServerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox serverbx;
        private System.Windows.Forms.TextBox userbx;
        private System.Windows.Forms.TextBox passbx;
        private System.Windows.Forms.Button Submit;
    }
}

