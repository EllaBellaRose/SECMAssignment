namespace SECMAssignmentCode
{
    partial class ArrangeMeeting
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
            this.nameslbx = new System.Windows.Forms.ListBox();
            this.namestb = new System.Windows.Forms.TextBox();
            this.donebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.exlbx = new System.Windows.Forms.ListBox();
            this.preflbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.availablelbx = new System.Windows.Forms.ListBox();
            this.selectbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlelb
            // 
            this.titlelb.AutoSize = true;
            this.titlelb.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelb.Location = new System.Drawing.Point(246, 9);
            this.titlelb.Name = "titlelb";
            this.titlelb.Size = new System.Drawing.Size(580, 78);
            this.titlelb.TabIndex = 9;
            this.titlelb.Text = "Meeting Scheduler";
            // 
            // nameslbx
            // 
            this.nameslbx.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameslbx.FormattingEnabled = true;
            this.nameslbx.ItemHeight = 31;
            this.nameslbx.Location = new System.Drawing.Point(12, 237);
            this.nameslbx.Name = "nameslbx";
            this.nameslbx.Size = new System.Drawing.Size(229, 345);
            this.nameslbx.TabIndex = 10;
            // 
            // namestb
            // 
            this.namestb.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namestb.Location = new System.Drawing.Point(18, 49);
            this.namestb.Name = "namestb";
            this.namestb.Size = new System.Drawing.Size(153, 43);
            this.namestb.TabIndex = 11;
            // 
            // donebtn
            // 
            this.donebtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.donebtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.Location = new System.Drawing.Point(188, 43);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(112, 49);
            this.donebtn.TabIndex = 12;
            this.donebtn.Text = "Done";
            this.donebtn.UseVisualStyleBackColor = false;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.namestb);
            this.groupBox1.Controls.Add(this.donebtn);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Participent";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.savebtn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(247, 383);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(94, 57);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Visible = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // exlbx
            // 
            this.exlbx.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exlbx.FormattingEnabled = true;
            this.exlbx.ItemHeight = 26;
            this.exlbx.Location = new System.Drawing.Point(263, 72);
            this.exlbx.Name = "exlbx";
            this.exlbx.Size = new System.Drawing.Size(201, 290);
            this.exlbx.TabIndex = 15;
            // 
            // preflbx
            // 
            this.preflbx.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preflbx.FormattingEnabled = true;
            this.preflbx.ItemHeight = 26;
            this.preflbx.Location = new System.Drawing.Point(21, 72);
            this.preflbx.Name = "preflbx";
            this.preflbx.Size = new System.Drawing.Size(201, 290);
            this.preflbx.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prefer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Exclude";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.preflbx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.exlbx);
            this.groupBox2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(347, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 392);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availability of Users";
            this.groupBox2.Visible = false;
            // 
            // availablelbx
            // 
            this.availablelbx.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablelbx.FormattingEnabled = true;
            this.availablelbx.ItemHeight = 26;
            this.availablelbx.Location = new System.Drawing.Point(843, 32);
            this.availablelbx.Name = "availablelbx";
            this.availablelbx.Size = new System.Drawing.Size(250, 524);
            this.availablelbx.TabIndex = 20;
            this.availablelbx.Visible = false;
            // 
            // selectbtn
            // 
            this.selectbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.selectbtn.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectbtn.Location = new System.Drawing.Point(1099, 257);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(86, 52);
            this.selectbtn.TabIndex = 21;
            this.selectbtn.Text = "Select";
            this.selectbtn.UseVisualStyleBackColor = false;
            this.selectbtn.Visible = false;
            // 
            // ArrangeMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1191, 594);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.availablelbx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameslbx);
            this.Controls.Add(this.titlelb);
            this.Name = "ArrangeMeeting";
            this.Text = "ArrangeMeeting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelb;
        private System.Windows.Forms.ListBox nameslbx;
        private System.Windows.Forms.TextBox namestb;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ListBox exlbx;
        private System.Windows.Forms.ListBox preflbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox availablelbx;
        private System.Windows.Forms.Button selectbtn;
    }
}