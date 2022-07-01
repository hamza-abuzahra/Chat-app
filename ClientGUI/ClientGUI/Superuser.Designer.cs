namespace ClientGUI
{
    partial class Superuser
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
            this.activebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // activebtn
            // 
            this.activebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.activebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.activebtn.Location = new System.Drawing.Point(71, 106);
            this.activebtn.Margin = new System.Windows.Forms.Padding(4);
            this.activebtn.Name = "activebtn";
            this.activebtn.Size = new System.Drawing.Size(193, 53);
            this.activebtn.TabIndex = 9;
            this.activebtn.Text = "Who is Active?";
            this.activebtn.UseVisualStyleBackColor = true;
            this.activebtn.Click += new System.EventHandler(this.activebtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(71, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Check Activities";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(71, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 53);
            this.button2.TabIndex = 11;
            this.button2.Text = "See the Logs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "al.alshareef@bilgiedu.net",
            "hamza.abuzahra@bilgiedu.net",
            "abdul.hamed@bilgiedu.net",
            "sena.yilmaz03@bilgiedu.net",
            "ali.allouche@bilgiedu.net",
            "ghassan.nasseir@bilgiedu.net",
            "cevdet.arat@bilgiedu.net",
            "di.sa@bilgiedu.net",
            "abdullah.alward@bilgiedu.net",
            "murat.oguz@bilgi.edu.tr",
            "Everyone"});
            this.comboBox1.Location = new System.Drawing.Point(316, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 37);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "al.alshareef@bilgiedu.net",
            "hamza.abuzahra@bilgiedu.net",
            "abdul.hamed@bilgiedu.net",
            "sena.yilmaz03@bilgiedu.net",
            "ali.allouche@bilgiedu.net",
            "ghassan.nasseir@bilgiedu.net",
            "cevdet.arat@bilgiedu.net",
            "di.sa@bilgiedu.net",
            "abdullah.alward@bilgiedu.net",
            "murat.oguz@bilgi.edu.tr",
            "Everyone"});
            this.comboBox2.Location = new System.Drawing.Point(316, 230);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 37);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Superuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(572, 457);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activebtn);
            this.Name = "Superuser";
            this.Text = "Superuser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button activebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}