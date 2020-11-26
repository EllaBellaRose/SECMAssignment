namespace SECMAssignmentCode
{
    partial class EditAccount
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
            this.addlb = new System.Windows.Forms.Label();
            this.dellb = new System.Windows.Forms.Label();
            this.backToMenubtn = new System.Windows.Forms.Button();
            this.usernamelb = new System.Windows.Forms.Label();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordlb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yesModcb = new System.Windows.Forms.CheckBox();
            this.noModcb = new System.Windows.Forms.CheckBox();
            this.donedeladdbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addlb
            // 
            this.addlb.AutoSize = true;
            this.addlb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlb.Location = new System.Drawing.Point(328, 9);
            this.addlb.Name = "addlb";
            this.addlb.Size = new System.Drawing.Size(423, 78);
            this.addlb.TabIndex = 10;
            this.addlb.Text = "Add Account";
            // 
            // dellb
            // 
            this.dellb.AutoSize = true;
            this.dellb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dellb.Location = new System.Drawing.Point(297, 9);
            this.dellb.Name = "dellb";
            this.dellb.Size = new System.Drawing.Size(490, 78);
            this.dellb.TabIndex = 11;
            this.dellb.Text = "Delete Account";
            this.dellb.Visible = false;
            // 
            // backToMenubtn
            // 
            this.backToMenubtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backToMenubtn.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenubtn.Location = new System.Drawing.Point(22, 482);
            this.backToMenubtn.Name = "backToMenubtn";
            this.backToMenubtn.Size = new System.Drawing.Size(128, 100);
            this.backToMenubtn.TabIndex = 12;
            this.backToMenubtn.Text = "Back to Menu";
            this.backToMenubtn.UseVisualStyleBackColor = false;
            this.backToMenubtn.Click += new System.EventHandler(this.backToMenubtn_Click);
            // 
            // usernamelb
            // 
            this.usernamelb.AutoSize = true;
            this.usernamelb.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelb.Location = new System.Drawing.Point(158, 159);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(0, 35);
            this.usernamelb.TabIndex = 13;
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.Location = new System.Drawing.Point(470, 272);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(327, 51);
            this.passwordtb.TabIndex = 17;
            this.passwordtb.Visible = false;
            // 
            // usernametb
            // 
            this.usernametb.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametb.Location = new System.Drawing.Point(470, 183);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(327, 51);
            this.usernametb.TabIndex = 16;
            // 
            // passwordlb
            // 
            this.passwordlb.AutoSize = true;
            this.passwordlb.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlb.Location = new System.Drawing.Point(250, 275);
            this.passwordlb.Name = "passwordlb";
            this.passwordlb.Size = new System.Drawing.Size(183, 44);
            this.passwordlb.TabIndex = 15;
            this.passwordlb.Text = "Password:";
            this.passwordlb.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username:";
            // 
            // yesModcb
            // 
            this.yesModcb.AutoSize = true;
            this.yesModcb.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesModcb.Location = new System.Drawing.Point(349, 361);
            this.yesModcb.Name = "yesModcb";
            this.yesModcb.Size = new System.Drawing.Size(192, 27);
            this.yesModcb.TabIndex = 18;
            this.yesModcb.Text = "Modification Access";
            this.yesModcb.UseVisualStyleBackColor = true;
            this.yesModcb.Visible = false;
            this.yesModcb.CheckedChanged += new System.EventHandler(this.yesModcb_CheckedChanged);
            // 
            // noModcb
            // 
            this.noModcb.AutoSize = true;
            this.noModcb.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noModcb.Location = new System.Drawing.Point(566, 361);
            this.noModcb.Name = "noModcb";
            this.noModcb.Size = new System.Drawing.Size(221, 27);
            this.noModcb.TabIndex = 19;
            this.noModcb.Text = "No Modification Access";
            this.noModcb.UseVisualStyleBackColor = true;
            this.noModcb.Visible = false;
            this.noModcb.CheckedChanged += new System.EventHandler(this.noModcb_CheckedChanged);
            // 
            // donedeladdbtn
            // 
            this.donedeladdbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.donedeladdbtn.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donedeladdbtn.Location = new System.Drawing.Point(452, 448);
            this.donedeladdbtn.Name = "donedeladdbtn";
            this.donedeladdbtn.Size = new System.Drawing.Size(166, 73);
            this.donedeladdbtn.TabIndex = 20;
            this.donedeladdbtn.Text = "Done";
            this.donedeladdbtn.UseVisualStyleBackColor = false;
            this.donedeladdbtn.Click += new System.EventHandler(this.donedeladdbtn_Click);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.donedeladdbtn);
            this.Controls.Add(this.noModcb);
            this.Controls.Add(this.yesModcb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.passwordlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernamelb);
            this.Controls.Add(this.backToMenubtn);
            this.Controls.Add(this.dellb);
            this.Controls.Add(this.addlb);
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addlb;
        private System.Windows.Forms.Label dellb;
        private System.Windows.Forms.Button backToMenubtn;
        private System.Windows.Forms.Label usernamelb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Label passwordlb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox yesModcb;
        private System.Windows.Forms.CheckBox noModcb;
        private System.Windows.Forms.Button donedeladdbtn;
    }
}