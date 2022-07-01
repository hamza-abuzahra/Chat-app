namespace ClientGUI
{
    partial class MiniForm
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
            this.Nameslb = new System.Windows.Forms.ListBox();
            this.Selectbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nameslb
            // 
            this.Nameslb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.Nameslb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nameslb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nameslb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nameslb.FormattingEnabled = true;
            this.Nameslb.ItemHeight = 20;
            this.Nameslb.Items.AddRange(new object[] {
            "al.alshareef@bilgiedu.net",
            "hamza.abuzahra@bilgiedu.net",
            "abdul.hamed@bilgiedu.net",
            "sena.yilmaz03@bilgiedu.net",
            "ali.allouche@bilgiedu.net",
            "ghassan.nasseir@bilgiedu.net",
            "cevdet.arat@bilgiedu.net",
            "di.sa@bilgiedu.net",
            "abdullah.alward@bilgiedu.net",
            "murat.oguz@bilgi.edu.tr"});
            this.Nameslb.Location = new System.Drawing.Point(16, 15);
            this.Nameslb.Margin = new System.Windows.Forms.Padding(4);
            this.Nameslb.Name = "Nameslb";
            this.Nameslb.Size = new System.Drawing.Size(233, 302);
            this.Nameslb.TabIndex = 1;
            this.Nameslb.SelectedValueChanged += new System.EventHandler(this.Nameslb_SelectedValueChanged);
            // 
            // Selectbtn
            // 
            this.Selectbtn.Enabled = false;
            this.Selectbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Selectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selectbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Selectbtn.Location = new System.Drawing.Point(17, 343);
            this.Selectbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(107, 46);
            this.Selectbtn.TabIndex = 2;
            this.Selectbtn.Text = "Select";
            this.Selectbtn.UseVisualStyleBackColor = true;
            this.Selectbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancelbtn.Location = new System.Drawing.Point(143, 343);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(107, 46);
            this.Cancelbtn.TabIndex = 3;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // MiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(267, 404);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Selectbtn);
            this.Controls.Add(this.Nameslb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MiniForm";
            this.Text = "Send to...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Nameslb;
        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.Button Cancelbtn;
    }
}