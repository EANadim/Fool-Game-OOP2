namespace WindowsFormsApplication1
{
    partial class NoClass
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
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_CopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_PlayAgain.Location = new System.Drawing.Point(54, 236);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(147, 54);
            this.btn_PlayAgain.TabIndex = 2;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Exit.Location = new System.Drawing.Point(259, 236);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(147, 54);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No.Location = new System.Drawing.Point(72, 82);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(317, 29);
            this.lbl_No.TabIndex = 4;
            this.lbl_No.Text = "Oops !!! You are not a fool";
            // 
            // lbl_CopyRight
            // 
            this.lbl_CopyRight.AutoSize = true;
            this.lbl_CopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CopyRight.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CopyRight.Location = new System.Drawing.Point(219, 520);
            this.lbl_CopyRight.Name = "lbl_CopyRight";
            this.lbl_CopyRight.Size = new System.Drawing.Size(226, 32);
            this.lbl_CopyRight.TabIndex = 5;
            this.lbl_CopyRight.Text = "© 2018 Ehtesham Ahmad Nadim\r\n              All Right Reserved";
            // 
            // NoClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 561);
            this.Controls.Add(this.lbl_CopyRight);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_PlayAgain);
            this.Name = "NoClass";
            this.Text = "NoClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_CopyRight;
    }
}