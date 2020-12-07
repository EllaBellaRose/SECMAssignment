namespace SECMAssignmentCode
{
    partial class CurrentMeetings
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentMeetingslbx = new System.Windows.Forms.ListBox();
            this.menubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelb
            // 
            this.titlelb.AutoSize = true;
            this.titlelb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelb.Location = new System.Drawing.Point(220, 9);
            this.titlelb.Name = "titlelb";
            this.titlelb.Size = new System.Drawing.Size(580, 78);
            this.titlelb.TabIndex = 10;
            this.titlelb.Text = "Meeting Scheduler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Meetings";
            // 
            // currentMeetingslbx
            // 
            this.currentMeetingslbx.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMeetingslbx.FormattingEnabled = true;
            this.currentMeetingslbx.ItemHeight = 26;
            this.currentMeetingslbx.Location = new System.Drawing.Point(306, 169);
            this.currentMeetingslbx.Name = "currentMeetingslbx";
            this.currentMeetingslbx.Size = new System.Drawing.Size(399, 342);
            this.currentMeetingslbx.TabIndex = 12;
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menubtn.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtn.Location = new System.Drawing.Point(12, 514);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(256, 68);
            this.menubtn.TabIndex = 64;
            this.menubtn.Text = "Return To Menu";
            this.menubtn.UseVisualStyleBackColor = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // CurrentMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.menubtn);
            this.Controls.Add(this.currentMeetingslbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titlelb);
            this.Name = "CurrentMeetings";
            this.Text = "CurrentMeetings";
            this.Load += new System.EventHandler(this.CurrentMeetings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox currentMeetingslbx;
        private System.Windows.Forms.Button menubtn;
    }
}