namespace Kalkylator_Calle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ett = new System.Windows.Forms.Button();
            this.två = new System.Windows.Forms.Button();
            this.summera = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 113);
            this.textBox1.TabIndex = 0;
            // 
            // ett
            // 
            this.ett.Location = new System.Drawing.Point(116, 247);
            this.ett.Name = "ett";
            this.ett.Size = new System.Drawing.Size(75, 58);
            this.ett.TabIndex = 1;
            this.ett.Text = "1";
            this.ett.UseVisualStyleBackColor = true;
            this.ett.Click += new System.EventHandler(this.ett_Click);
            // 
            // två
            // 
            this.två.Location = new System.Drawing.Point(213, 247);
            this.två.Name = "två";
            this.två.Size = new System.Drawing.Size(75, 57);
            this.två.TabIndex = 2;
            this.två.Text = "2";
            this.två.UseVisualStyleBackColor = true;
            this.två.Click += new System.EventHandler(this.två_Click);
            // 
            // summera
            // 
            this.summera.Location = new System.Drawing.Point(318, 247);
            this.summera.Name = "summera";
            this.summera.Size = new System.Drawing.Size(75, 56);
            this.summera.TabIndex = 3;
            this.summera.Text = "=";
            this.summera.UseVisualStyleBackColor = true;
            this.summera.Click += new System.EventHandler(this.summera_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(166, 331);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 55);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 541);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.summera);
            this.Controls.Add(this.två);
            this.Controls.Add(this.ett);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Kalkylator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ett;
        private System.Windows.Forms.Button två;
        private System.Windows.Forms.Button summera;
        private System.Windows.Forms.Button plus;
    }
}

