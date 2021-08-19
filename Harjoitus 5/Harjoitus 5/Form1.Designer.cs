namespace Harjoitus_5
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
            this.AnnalukuLB = new System.Windows.Forms.Label();
            this.uusilukuTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnnalukuLB
            // 
            this.AnnalukuLB.AutoSize = true;
            this.AnnalukuLB.Location = new System.Drawing.Point(115, 42);
            this.AnnalukuLB.Name = "AnnalukuLB";
            this.AnnalukuLB.Size = new System.Drawing.Size(122, 13);
            this.AnnalukuLB.TabIndex = 0;
            this.AnnalukuLB.Text = "Anna luku (-999 lopetus)";
            // 
            // uusilukuTB
            // 
            this.uusilukuTB.Location = new System.Drawing.Point(243, 39);
            this.uusilukuTB.Name = "uusilukuTB";
            this.uusilukuTB.Size = new System.Drawing.Size(241, 20);
            this.uusilukuTB.TabIndex = 1;
            this.uusilukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusilukuTB_KeyPress);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(115, 102);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(35, 13);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "label2";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.uusilukuTB);
            this.Controls.Add(this.AnnalukuLB);
            this.Name = "Form1";
            this.Text = "Lukujen järjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnnalukuLB;
        private System.Windows.Forms.TextBox uusilukuTB;
        private System.Windows.Forms.Label VastausLB;
    }
}

