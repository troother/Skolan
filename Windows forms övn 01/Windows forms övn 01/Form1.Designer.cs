namespace Windows_forms_övn_01
{
    partial class frmVisaTextMeddelande
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
            this.txtTextruta1 = new System.Windows.Forms.TextBox();
            this.txtTextruta2 = new System.Windows.Forms.TextBox();
            this.cmdVisaMeddelande = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextruta1
            // 
            this.txtTextruta1.Location = new System.Drawing.Point(38, 51);
            this.txtTextruta1.Name = "txtTextruta1";
            this.txtTextruta1.Size = new System.Drawing.Size(100, 22);
            this.txtTextruta1.TabIndex = 0;
            this.txtTextruta1.Text = "First name";
            this.txtTextruta1.Click += new System.EventHandler(this.txtTextruta1_Click);
            this.txtTextruta1.TextChanged += new System.EventHandler(this.txtTextruta1_TextChanged);
            // 
            // txtTextruta2
            // 
            this.txtTextruta2.Location = new System.Drawing.Point(38, 96);
            this.txtTextruta2.Name = "txtTextruta2";
            this.txtTextruta2.Size = new System.Drawing.Size(100, 22);
            this.txtTextruta2.TabIndex = 1;
            // 
            // cmdVisaMeddelande
            // 
            this.cmdVisaMeddelande.Location = new System.Drawing.Point(38, 140);
            this.cmdVisaMeddelande.Name = "cmdVisaMeddelande";
            this.cmdVisaMeddelande.Size = new System.Drawing.Size(75, 23);
            this.cmdVisaMeddelande.TabIndex = 2;
            this.cmdVisaMeddelande.Text = "Visa";
            this.cmdVisaMeddelande.UseVisualStyleBackColor = true;
            this.cmdVisaMeddelande.Click += new System.EventHandler(this.cmdVisaMeddelande_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmVisaTextMeddelande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdVisaMeddelande);
            this.Controls.Add(this.txtTextruta2);
            this.Controls.Add(this.txtTextruta1);
            this.Name = "frmVisaTextMeddelande";
            this.Text = "Full Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextruta1;
        private System.Windows.Forms.TextBox txtTextruta2;
        private System.Windows.Forms.Button cmdVisaMeddelande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

