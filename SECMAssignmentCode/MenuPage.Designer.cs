namespace SECMAssignmentCode
{
    partial class MenuPage
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
            this.Menulb = new System.Windows.Forms.Label();
            this.prefbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.addAccbtn = new System.Windows.Forms.Button();
            this.backToLoginbtn = new System.Windows.Forms.Button();
            this.delAccbtn = new System.Windows.Forms.Button();
            this.arrangebtn = new System.Windows.Forms.Button();
            this.viewMeetingbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelb
            // 
            this.titlelb.AutoSize = true;
            this.titlelb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelb.Location = new System.Drawing.Point(237, 9);
            this.titlelb.Name = "titlelb";
            this.titlelb.Size = new System.Drawing.Size(580, 78);
            this.titlelb.TabIndex = 9;
            this.titlelb.Text = "Meeting Scheduler";
            // 
            // Menulb
            // 
            this.Menulb.AutoSize = true;
            this.Menulb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulb.Location = new System.Drawing.Point(424, 87);
            this.Menulb.Name = "Menulb";
            this.Menulb.Size = new System.Drawing.Size(201, 78);
            this.Menulb.TabIndex = 10;
            this.Menulb.Text = "Menu";
            // 
            // prefbtn
            // 
            this.prefbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.prefbtn.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefbtn.Location = new System.Drawing.Point(162, 196);
            this.prefbtn.Name = "prefbtn";
            this.prefbtn.Size = new System.Drawing.Size(225, 102);
            this.prefbtn.TabIndex = 11;
            this.prefbtn.Text = "Edit pref/ex slots";
            this.prefbtn.UseVisualStyleBackColor = false;
            this.prefbtn.Click += new System.EventHandler(this.prefbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(534, 497);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(153, 85);
            this.exitbtn.TabIndex = 12;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // addAccbtn
            // 
            this.addAccbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addAccbtn.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccbtn.Location = new System.Drawing.Point(638, 196);
            this.addAccbtn.Name = "addAccbtn";
            this.addAccbtn.Size = new System.Drawing.Size(224, 102);
            this.addAccbtn.TabIndex = 13;
            this.addAccbtn.Text = "Add Account";
            this.addAccbtn.UseVisualStyleBackColor = false;
            this.addAccbtn.Visible = false;
            this.addAccbtn.Click += new System.EventHandler(this.addAccbtn_Click);
            // 
            // backToLoginbtn
            // 
            this.backToLoginbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backToLoginbtn.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLoginbtn.Location = new System.Drawing.Point(354, 497);
            this.backToLoginbtn.Name = "backToLoginbtn";
            this.backToLoginbtn.Size = new System.Drawing.Size(153, 85);
            this.backToLoginbtn.TabIndex = 14;
            this.backToLoginbtn.Text = "Back to Login";
            this.backToLoginbtn.UseVisualStyleBackColor = false;
            this.backToLoginbtn.Click += new System.EventHandler(this.backToLoginbtn_Click);
            // 
            // delAccbtn
            // 
            this.delAccbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.delAccbtn.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAccbtn.Location = new System.Drawing.Point(638, 316);
            this.delAccbtn.Name = "delAccbtn";
            this.delAccbtn.Size = new System.Drawing.Size(224, 102);
            this.delAccbtn.TabIndex = 15;
            this.delAccbtn.Text = "Delete Account";
            this.delAccbtn.UseVisualStyleBackColor = false;
            this.delAccbtn.Visible = false;
            this.delAccbtn.Click += new System.EventHandler(this.delAccbtn_Click);
            // 
            // arrangebtn
            // 
            this.arrangebtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.arrangebtn.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrangebtn.Location = new System.Drawing.Point(162, 316);
            this.arrangebtn.Name = "arrangebtn";
            this.arrangebtn.Size = new System.Drawing.Size(225, 102);
            this.arrangebtn.TabIndex = 16;
            this.arrangebtn.Text = "Arrange Meeting";
            this.arrangebtn.UseVisualStyleBackColor = false;
            this.arrangebtn.Visible = false;
            this.arrangebtn.Click += new System.EventHandler(this.arrangebtn_Click);
            // 
            // viewMeetingbtn
            // 
            this.viewMeetingbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewMeetingbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMeetingbtn.Location = new System.Drawing.Point(401, 258);
            this.viewMeetingbtn.Name = "viewMeetingbtn";
            this.viewMeetingbtn.Size = new System.Drawing.Size(224, 102);
            this.viewMeetingbtn.TabIndex = 17;
            this.viewMeetingbtn.Text = "View meetings I\'m attending";
            this.viewMeetingbtn.UseVisualStyleBackColor = false;
            this.viewMeetingbtn.Click += new System.EventHandler(this.viewMeetingbtn_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.viewMeetingbtn);
            this.Controls.Add(this.arrangebtn);
            this.Controls.Add(this.delAccbtn);
            this.Controls.Add(this.backToLoginbtn);
            this.Controls.Add(this.addAccbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.prefbtn);
            this.Controls.Add(this.Menulb);
            this.Controls.Add(this.titlelb);
            this.Name = "MenuPage";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelb;
        private System.Windows.Forms.Label Menulb;
        private System.Windows.Forms.Button prefbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button addAccbtn;
        private System.Windows.Forms.Button backToLoginbtn;
        private System.Windows.Forms.Button delAccbtn;
        private System.Windows.Forms.Button arrangebtn;
        private System.Windows.Forms.Button viewMeetingbtn;
    }
}