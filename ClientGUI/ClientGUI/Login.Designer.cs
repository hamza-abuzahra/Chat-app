namespace ClientGUI
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
            this.signupbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ustxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passtxtbx = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signupbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(28)))), ((int)(((byte)(13)))));
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupbtn.Location = new System.Drawing.Point(281, 471);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(1);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(163, 46);
            this.signupbtn.TabIndex = 3;
            this.signupbtn.Text = "Don\'t have an account?";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(193, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // ustxtbx
            // 
            this.ustxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ustxtbx.Location = new System.Drawing.Point(93, 164);
            this.ustxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.ustxtbx.Name = "ustxtbx";
            this.ustxtbx.Size = new System.Drawing.Size(349, 36);
            this.ustxtbx.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(199, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // passtxtbx
            // 
            this.passtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passtxtbx.Location = new System.Drawing.Point(93, 314);
            this.passtxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.passtxtbx.Name = "passtxtbx";
            this.passtxtbx.PasswordChar = '*';
            this.passtxtbx.Size = new System.Drawing.Size(349, 36);
            this.passtxtbx.TabIndex = 7;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbtn.Location = new System.Drawing.Point(93, 471);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(1);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(163, 46);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "Sign in";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(551, 542);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passtxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ustxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ustxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passtxtbx;
        private System.Windows.Forms.Button loginbtn;
    }
}