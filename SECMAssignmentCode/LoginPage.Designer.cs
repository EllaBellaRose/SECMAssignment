namespace SECMAssignmentCode
{
    partial class LoginPage
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
            this.loginlb = new System.Windows.Forms.Label();
            this.usernamelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.donebtn = new System.Windows.Forms.Button();
            this.titlelb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginlb
            // 
            this.loginlb.AutoSize = true;
            this.loginlb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlb.Location = new System.Drawing.Point(434, 116);
            this.loginlb.Name = "loginlb";
            this.loginlb.Size = new System.Drawing.Size(197, 78);
            this.loginlb.TabIndex = 1;
            this.loginlb.Text = "Login";
            // 
            // usernamelb
            // 
            this.usernamelb.AutoSize = true;
            this.usernamelb.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelb.Location = new System.Drawing.Point(203, 258);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(194, 44);
            this.usernamelb.TabIndex = 2;
            this.usernamelb.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // usernametb
            // 
            this.usernametb.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametb.Location = new System.Drawing.Point(423, 258);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(327, 51);
            this.usernametb.TabIndex = 4;
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.Location = new System.Drawing.Point(423, 347);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(327, 51);
            this.passwordtb.TabIndex = 5;
            // 
            // donebtn
            // 
            this.donebtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.donebtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.Location = new System.Drawing.Point(798, 298);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(116, 49);
            this.donebtn.TabIndex = 6;
            this.donebtn.Text = "Done";
            this.donebtn.UseVisualStyleBackColor = false;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // titlelb
            // 
            this.titlelb.AutoSize = true;
            this.titlelb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelb.Location = new System.Drawing.Point(248, 31);
            this.titlelb.Name = "titlelb";
            this.titlelb.Size = new System.Drawing.Size(580, 78);
            this.titlelb.TabIndex = 8;
            this.titlelb.Text = "Meeting Scheduler";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.titlelb);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernamelb);
            this.Controls.Add(this.loginlb);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlb;
        private System.Windows.Forms.Label usernamelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Label titlelb;
    }
}