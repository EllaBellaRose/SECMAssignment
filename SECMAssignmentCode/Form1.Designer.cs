namespace SECMAssignmentCode
{
    partial class StartPage
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
            this.titlelb = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.createAccbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelb
            // 
            this.titlelb.AutoSize = true;
            this.titlelb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelb.Location = new System.Drawing.Point(246, 32);
            this.titlelb.Name = "titlelb";
            this.titlelb.Size = new System.Drawing.Size(580, 78);
            this.titlelb.TabIndex = 0;
            this.titlelb.Text = "Meeting Scheduler";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loginbtn.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(226, 231);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(263, 103);
            this.loginbtn.TabIndex = 1;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // createAccbtn
            // 
            this.createAccbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.createAccbtn.Font = new System.Drawing.Font("Berlin Sans FB", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccbtn.Location = new System.Drawing.Point(563, 231);
            this.createAccbtn.Name = "createAccbtn";
            this.createAccbtn.Size = new System.Drawing.Size(263, 103);
            this.createAccbtn.TabIndex = 2;
            this.createAccbtn.Text = "Create Account";
            this.createAccbtn.UseVisualStyleBackColor = false;
            this.createAccbtn.Click += new System.EventHandler(this.createAccbtn_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.createAccbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.titlelb);
            this.Name = "StartPage";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelb;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button createAccbtn;
    }
}

