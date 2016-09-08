namespace Addressbok_Calle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.PersonalNumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.MaritalBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefonnummer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Civilstånd";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(91, 50);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(340, 26);
            this.FirstNameBox.TabIndex = 6;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(102, 82);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(329, 26);
            this.LastNameBox.TabIndex = 7;
            // 
            // PersonalNumberBox
            // 
            this.PersonalNumberBox.Location = new System.Drawing.Point(135, 118);
            this.PersonalNumberBox.Name = "PersonalNumberBox";
            this.PersonalNumberBox.Size = new System.Drawing.Size(295, 26);
            this.PersonalNumberBox.TabIndex = 8;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(66, 156);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(364, 26);
            this.EmailBox.TabIndex = 9;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(136, 207);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(295, 26);
            this.PhoneNumberBox.TabIndex = 10;
            // 
            // MaritalBox
            // 
            this.MaritalBox.FormattingEnabled = true;
            this.MaritalBox.Items.AddRange(new object[] {
            "Singel",
            "Civil"});
            this.MaritalBox.Location = new System.Drawing.Point(91, 243);
            this.MaritalBox.Name = "MaritalBox";
            this.MaritalBox.Size = new System.Drawing.Size(339, 28);
            this.MaritalBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 96);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaritalBox);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PersonalNumberBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox PersonalNumberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.ComboBox MaritalBox;
        private System.Windows.Forms.Button button1;
    }
}

