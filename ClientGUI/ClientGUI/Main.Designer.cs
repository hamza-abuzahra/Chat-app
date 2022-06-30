namespace ClientGUI
{
    partial class Main
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
            this.msgtxtbx = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.activebtn = new System.Windows.Forms.Button();
            this.Directbtn = new System.Windows.Forms.Button();
            this.Generalbtn = new System.Windows.Forms.Button();
            this.currentchatlbl = new System.Windows.Forms.Label();
            this.chattxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // msgtxtbx
            // 
            this.msgtxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgtxtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.msgtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.msgtxtbx.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msgtxtbx.Location = new System.Drawing.Point(243, 454);
            this.msgtxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.msgtxtbx.Multiline = true;
            this.msgtxtbx.Name = "msgtxtbx";
            this.msgtxtbx.Size = new System.Drawing.Size(712, 81);
            this.msgtxtbx.TabIndex = 0;
            // 
            // sendbtn
            // 
            this.sendbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sendbtn.Location = new System.Drawing.Point(972, 454);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(4);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(100, 81);
            this.sendbtn.TabIndex = 1;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // activebtn
            // 
            this.activebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.activebtn.Location = new System.Drawing.Point(15, 25);
            this.activebtn.Margin = new System.Windows.Forms.Padding(4);
            this.activebtn.Name = "activebtn";
            this.activebtn.Size = new System.Drawing.Size(193, 53);
            this.activebtn.TabIndex = 8;
            this.activebtn.Text = "Who is Active?";
            this.activebtn.UseVisualStyleBackColor = true;
            this.activebtn.Click += new System.EventHandler(this.activebtn_Click);
            // 
            // Directbtn
            // 
            this.Directbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Directbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Directbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Directbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Directbtn.Location = new System.Drawing.Point(15, 177);
            this.Directbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Directbtn.Name = "Directbtn";
            this.Directbtn.Size = new System.Drawing.Size(193, 53);
            this.Directbtn.TabIndex = 9;
            this.Directbtn.Text = "Direct Message";
            this.Directbtn.UseVisualStyleBackColor = true;
            this.Directbtn.Click += new System.EventHandler(this.Directbtn_Click);
            // 
            // Generalbtn
            // 
            this.Generalbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Generalbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Generalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generalbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Generalbtn.Location = new System.Drawing.Point(15, 101);
            this.Generalbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Generalbtn.Name = "Generalbtn";
            this.Generalbtn.Size = new System.Drawing.Size(193, 53);
            this.Generalbtn.TabIndex = 10;
            this.Generalbtn.Text = "General Message";
            this.Generalbtn.UseVisualStyleBackColor = true;
            this.Generalbtn.Click += new System.EventHandler(this.Generalbtn_Click);
            // 
            // currentchatlbl
            // 
            this.currentchatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentchatlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentchatlbl.Location = new System.Drawing.Point(16, 439);
            this.currentchatlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentchatlbl.Name = "currentchatlbl";
            this.currentchatlbl.Size = new System.Drawing.Size(192, 96);
            this.currentchatlbl.TabIndex = 11;
            // 
            // chattxtbx
            // 
            this.chattxtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.chattxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chattxtbx.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chattxtbx.Location = new System.Drawing.Point(243, 12);
            this.chattxtbx.Multiline = true;
            this.chattxtbx.Name = "chattxtbx";
            this.chattxtbx.ReadOnly = true;
            this.chattxtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chattxtbx.Size = new System.Drawing.Size(829, 422);
            this.chattxtbx.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1084, 554);
            this.Controls.Add(this.chattxtbx);
            this.Controls.Add(this.currentchatlbl);
            this.Controls.Add(this.Generalbtn);
            this.Controls.Add(this.msgtxtbx);
            this.Controls.Add(this.Directbtn);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.activebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgtxtbx;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Button activebtn;
        private System.Windows.Forms.Button Directbtn;
        private System.Windows.Forms.Button Generalbtn;
        private System.Windows.Forms.Label currentchatlbl;
        private System.Windows.Forms.TextBox chattxtbx;
    }
}