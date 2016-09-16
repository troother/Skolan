namespace GruppUppgift_15__Vecka_3_
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
            this.calendarSport = new System.Windows.Forms.MonthCalendar();
            this.comboSport = new System.Windows.Forms.ComboBox();
            this.comboStart = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboEnd = new System.Windows.Forms.ComboBox();
            this.listBookings = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calendarSport
            // 
            this.calendarSport.Location = new System.Drawing.Point(582, 115);
            this.calendarSport.MaxSelectionCount = 1;
            this.calendarSport.Name = "calendarSport";
            this.calendarSport.TabIndex = 0;
            // 
            // comboSport
            // 
            this.comboSport.FormattingEnabled = true;
            this.comboSport.Items.AddRange(new object[] {
            "Tennis",
            "Squash",
            "Badminton"});
            this.comboSport.Location = new System.Drawing.Point(582, 83);
            this.comboSport.Name = "comboSport";
            this.comboSport.Size = new System.Drawing.Size(329, 28);
            this.comboSport.TabIndex = 1;
            this.comboSport.Text = "Sport";
            // 
            // comboStart
            // 
            this.comboStart.FormattingEnabled = true;
            this.comboStart.Items.AddRange(new object[] {
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.comboStart.Location = new System.Drawing.Point(582, 379);
            this.comboStart.Name = "comboStart";
            this.comboStart.Size = new System.Drawing.Size(136, 28);
            this.comboStart.TabIndex = 2;
            this.comboStart.Text = "Start";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Change Booking";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboEnd
            // 
            this.comboEnd.FormattingEnabled = true;
            this.comboEnd.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.comboEnd.Location = new System.Drawing.Point(743, 379);
            this.comboEnd.Name = "comboEnd";
            this.comboEnd.Size = new System.Drawing.Size(136, 28);
            this.comboEnd.TabIndex = 5;
            this.comboEnd.Text = "End";
            // 
            // listBookings
            // 
            this.listBookings.FormattingEnabled = true;
            this.listBookings.ItemHeight = 20;
            this.listBookings.Location = new System.Drawing.Point(933, 83);
            this.listBookings.Name = "listBookings";
            this.listBookings.Size = new System.Drawing.Size(377, 284);
            this.listBookings.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(933, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(377, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get Bookings";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "First name:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(127, 80);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(313, 26);
            this.txtFirstname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(156, 153);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(284, 26);
            this.txtPhone.TabIndex = 11;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(127, 115);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(313, 26);
            this.txtLastname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Zip code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 26);
            this.txtEmail.TabIndex = 17;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(127, 223);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(313, 26);
            this.txtZip.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 258);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(313, 26);
            this.txtAddress.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 591);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBookings);
            this.Controls.Add(this.comboEnd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboStart);
            this.Controls.Add(this.comboSport);
            this.Controls.Add(this.calendarSport);
            this.Name = "Form1";
            this.Text = "Sporthall";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarSport;
        private System.Windows.Forms.ComboBox comboSport;
        private System.Windows.Forms.ComboBox comboStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboEnd;
        private System.Windows.Forms.ListBox listBookings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtAddress;
    }
}

