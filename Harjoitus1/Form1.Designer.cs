
namespace Harjoitus1
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.VahidaLB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.Location = new System.Drawing.Point(23, 36);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(62, 20);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Otsikko";
            // 
            // VahidaLB
            // 
            this.VahidaLB.Location = new System.Drawing.Point(16, 69);
            this.VahidaLB.Name = "VahidaLB";
            this.VahidaLB.Size = new System.Drawing.Size(75, 51);
            this.VahidaLB.TabIndex = 1;
            this.VahidaLB.Text = "Vaihda teksti";
            this.VahidaLB.UseVisualStyleBackColor = true;
            this.VahidaLB.Click += new System.EventHandler(this.VahidaLB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 504);
            this.Controls.Add(this.VahidaLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "Form1";
            this.Text = "Harjoitus1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button VahidaLB;
    }
}

