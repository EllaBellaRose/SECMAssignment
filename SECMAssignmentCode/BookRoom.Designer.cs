namespace SECMAssignmentCode
{
    partial class BookRoom
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
            this.availablelbx = new System.Windows.Forms.ListBox();
            this.selectbtn = new System.Windows.Forms.Button();
            this.roomlbx = new System.Windows.Forms.ListBox();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.availableRoomsGB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availableRoomsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlelb
            // 
            this.titlelb.AutoSize = true;
            this.titlelb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelb.Location = new System.Drawing.Point(267, 9);
            this.titlelb.Name = "titlelb";
            this.titlelb.Size = new System.Drawing.Size(580, 78);
            this.titlelb.TabIndex = 10;
            this.titlelb.Text = "Meeting Scheduler";
            // 
            // availablelbx
            // 
            this.availablelbx.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablelbx.FormattingEnabled = true;
            this.availablelbx.ItemHeight = 26;
            this.availablelbx.Location = new System.Drawing.Point(11, 12);
            this.availablelbx.Name = "availablelbx";
            this.availablelbx.Size = new System.Drawing.Size(250, 524);
            this.availablelbx.TabIndex = 21;
            this.availablelbx.SelectedIndexChanged += new System.EventHandler(this.availablelbx_SelectedIndexChanged);
            // 
            // selectbtn
            // 
            this.selectbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.selectbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectbtn.Location = new System.Drawing.Point(51, 542);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(171, 46);
            this.selectbtn.TabIndex = 22;
            this.selectbtn.Text = "Select";
            this.selectbtn.UseVisualStyleBackColor = false;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // roomlbx
            // 
            this.roomlbx.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomlbx.FormattingEnabled = true;
            this.roomlbx.ItemHeight = 35;
            this.roomlbx.Location = new System.Drawing.Point(33, 39);
            this.roomlbx.Name = "roomlbx";
            this.roomlbx.Size = new System.Drawing.Size(297, 389);
            this.roomlbx.TabIndex = 23;
            // 
            // confirmbtn
            // 
            this.confirmbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.confirmbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(351, 156);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(176, 109);
            this.confirmbtn.TabIndex = 24;
            this.confirmbtn.Text = "Confirm Meeting";
            this.confirmbtn.UseVisualStyleBackColor = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // availableRoomsGB
            // 
            this.availableRoomsGB.Controls.Add(this.label1);
            this.availableRoomsGB.Controls.Add(this.roomlbx);
            this.availableRoomsGB.Controls.Add(this.confirmbtn);
            this.availableRoomsGB.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableRoomsGB.Location = new System.Drawing.Point(348, 109);
            this.availableRoomsGB.Name = "availableRoomsGB";
            this.availableRoomsGB.Size = new System.Drawing.Size(543, 446);
            this.availableRoomsGB.TabIndex = 25;
            this.availableRoomsGB.TabStop = false;
            this.availableRoomsGB.Text = "Available Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "     Room 1 has\r\nSepcial Equiptment";
            // 
            // BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.availableRoomsGB);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.availablelbx);
            this.Controls.Add(this.titlelb);
            this.Name = "BookRoom";
            this.Text = "BookRoom";
            this.Load += new System.EventHandler(this.BookRoom_Load);
            this.availableRoomsGB.ResumeLayout(false);
            this.availableRoomsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelb;
        private System.Windows.Forms.ListBox availablelbx;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.ListBox roomlbx;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.GroupBox availableRoomsGB;
        private System.Windows.Forms.Label label1;
    }
}