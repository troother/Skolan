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
            this.SuspendLayout();
            // 
            // calendarSport
            // 
            this.calendarSport.Location = new System.Drawing.Point(122, 123);
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
            this.comboSport.Location = new System.Drawing.Point(122, 83);
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
            this.comboStart.Location = new System.Drawing.Point(122, 387);
            this.comboStart.Name = "comboStart";
            this.comboStart.Size = new System.Drawing.Size(136, 28);
            this.comboStart.TabIndex = 2;
            this.comboStart.Text = "Start";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 503);
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
            this.comboEnd.Location = new System.Drawing.Point(315, 387);
            this.comboEnd.Name = "comboEnd";
            this.comboEnd.Size = new System.Drawing.Size(136, 28);
            this.comboEnd.TabIndex = 5;
            this.comboEnd.Text = "End";
            // 
            // listBookings
            // 
            this.listBookings.FormattingEnabled = true;
            this.listBookings.ItemHeight = 20;
            this.listBookings.Location = new System.Drawing.Point(486, 83);
            this.listBookings.Name = "listBookings";
            this.listBookings.Size = new System.Drawing.Size(377, 284);
            this.listBookings.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(377, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get Bookings";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 622);
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
    }
}

