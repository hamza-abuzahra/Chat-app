namespace ClientGUI
{
    partial class Form2
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
            this.passtxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.untxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.confirmpasstxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.signupbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signupbtn.Location = new System.Drawing.Point(83, 369);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(1);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(122, 37);
            this.signupbtn.TabIndex = 15;
            this.signupbtn.Text = "Sign up";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // passtxtbx
            // 
            this.passtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passtxtbx.Location = new System.Drawing.Point(83, 180);
            this.passtxtbx.Name = "passtxtbx";
            this.passtxtbx.PasswordChar = '*';
            this.passtxtbx.Size = new System.Drawing.Size(263, 30);
            this.passtxtbx.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(166, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // untxtbx
            // 
            this.untxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.untxtbx.Location = new System.Drawing.Point(83, 83);
            this.untxtbx.Name = "untxtbx";
            this.untxtbx.Size = new System.Drawing.Size(263, 30);
            this.untxtbx.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(164, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbtn.Location = new System.Drawing.Point(224, 369);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(1);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(122, 37);
            this.loginbtn.TabIndex = 10;
            this.loginbtn.Text = "Already have an account?";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // confirmpasstxtbx
            // 
            this.confirmpasstxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.confirmpasstxtbx.Location = new System.Drawing.Point(83, 281);
            this.confirmpasstxtbx.Name = "confirmpasstxtbx";
            this.confirmpasstxtbx.PasswordChar = '*';
            this.confirmpasstxtbx.Size = new System.Drawing.Size(263, 30);
            this.confirmpasstxtbx.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(130, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirm Password";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(413, 440);
            this.Controls.Add(this.confirmpasstxtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.passtxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.untxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.TextBox passtxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox untxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox confirmpasstxtbx;
        private System.Windows.Forms.Label label3;
    }
}