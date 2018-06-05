namespace WindowsFormsApplication1
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
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.lbl_Fool = new System.Windows.Forms.Label();
            this.lbl_CopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Yes
            // 
            this.btn_Yes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Yes.Location = new System.Drawing.Point(47, 138);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(147, 54);
            this.btn_Yes.TabIndex = 0;
            this.btn_Yes.Text = "YES";
            this.btn_Yes.UseVisualStyleBackColor = false;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.DarkRed;
            this.btn_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_No.Location = new System.Drawing.Point(262, 138);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(147, 54);
            this.btn_No.TabIndex = 1;
            this.btn_No.Text = "NO";
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            this.btn_No.MouseHover += new System.EventHandler(this.btn_No_MouseHover);
            // 
            // lbl_Fool
            // 
            this.lbl_Fool.AutoSize = true;
            this.lbl_Fool.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fool.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Fool.Location = new System.Drawing.Point(56, 23);
            this.lbl_Fool.Name = "lbl_Fool";
            this.lbl_Fool.Size = new System.Drawing.Size(342, 29);
            this.lbl_Fool.TabIndex = 2;
            this.lbl_Fool.Text = "Greetings !!! Are you a fool ?";
            // 
            // lbl_CopyRight
            // 
            this.lbl_CopyRight.AutoSize = true;
            this.lbl_CopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CopyRight.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CopyRight.Location = new System.Drawing.Point(219, 520);
            this.lbl_CopyRight.Name = "lbl_CopyRight";
            this.lbl_CopyRight.Size = new System.Drawing.Size(226, 32);
            this.lbl_CopyRight.TabIndex = 4;
            this.lbl_CopyRight.Text = "© 2018 Ehtesham Ahmad Nadim\r\n              All Right Reserved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 561);
            this.Controls.Add(this.lbl_CopyRight);
            this.Controls.Add(this.lbl_Fool);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Label lbl_Fool;
        private System.Windows.Forms.Label lbl_CopyRight;
    }
}

