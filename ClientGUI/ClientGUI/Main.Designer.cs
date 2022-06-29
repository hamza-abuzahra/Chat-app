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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.activebtn = new System.Windows.Forms.Button();
            this.Directbtn = new System.Windows.Forms.Button();
            this.Generalbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentchatlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(182, 369);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 66);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(702, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // activebtn
            // 
            this.activebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.activebtn.Location = new System.Drawing.Point(11, 20);
            this.activebtn.Name = "activebtn";
            this.activebtn.Size = new System.Drawing.Size(145, 43);
            this.activebtn.TabIndex = 8;
            this.activebtn.Text = "Who is Active?";
            this.activebtn.UseVisualStyleBackColor = true;
            // 
            // Directbtn
            // 
            this.Directbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Directbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Directbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Directbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Directbtn.Location = new System.Drawing.Point(11, 144);
            this.Directbtn.Name = "Directbtn";
            this.Directbtn.Size = new System.Drawing.Size(145, 43);
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
            this.Generalbtn.Location = new System.Drawing.Point(11, 82);
            this.Generalbtn.Name = "Generalbtn";
            this.Generalbtn.Size = new System.Drawing.Size(145, 43);
            this.Generalbtn.TabIndex = 10;
            this.Generalbtn.Text = "General Message";
            this.Generalbtn.UseVisualStyleBackColor = true;
            this.Generalbtn.Click += new System.EventHandler(this.Generalbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(169, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 346);
            this.panel1.TabIndex = 2;
            // 
            // currentchatlbl
            // 
            this.currentchatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentchatlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentchatlbl.Location = new System.Drawing.Point(12, 357);
            this.currentchatlbl.Name = "currentchatlbl";
            this.currentchatlbl.Size = new System.Drawing.Size(144, 78);
            this.currentchatlbl.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.currentchatlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Generalbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Directbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button activebtn;
        private System.Windows.Forms.Button Directbtn;
        private System.Windows.Forms.Button Generalbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentchatlbl;
    }
}