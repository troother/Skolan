namespace WF_Filhatering
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
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(125, 590);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(599, 26);
            this.textBox0.TabIndex = 0;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(125, 676);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(102, 40);
            this.button0.TabIndex = 1;
            this.button0.Text = "Visa";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 821);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.textBox0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Button button0;
    }
}

