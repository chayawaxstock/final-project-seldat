namespace manageTask
{
    partial class Login
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(95, 57);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "user name:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(95, 91);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(55, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "password:";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(174, 57);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 20);
            this.txt_userName.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(174, 91);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 3;
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(145, 135);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(163, 38);
            this.btn_signIn.TabIndex = 4;
            this.btn_signIn.Text = "sign-in";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 545);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Name = "Login";
            this.Text = "Sign-in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_signIn;
    }
}

