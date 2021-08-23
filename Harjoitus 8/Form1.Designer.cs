namespace Harjoitus_8
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
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.KgRB = new System.Windows.Forms.RadioButton();
            this.LbRB = new System.Windows.Forms.RadioButton();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.PoistuBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pituus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vastaus";
            // 
            // PainoTB
            // 
            this.PainoTB.Location = new System.Drawing.Point(120, 63);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(204, 20);
            this.PainoTB.TabIndex = 3;
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(120, 119);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(204, 20);
            this.PituusTB.TabIndex = 4;
            // 
            // KgRB
            // 
            this.KgRB.AutoSize = true;
            this.KgRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgRB.Location = new System.Drawing.Point(110, 178);
            this.KgRB.Name = "KgRB";
            this.KgRB.Size = new System.Drawing.Size(88, 24);
            this.KgRB.TabIndex = 6;
            this.KgRB.TabStop = true;
            this.KgRB.Text = "Kilogram";
            this.KgRB.UseVisualStyleBackColor = true;
            // 
            // LbRB
            // 
            this.LbRB.AutoSize = true;
            this.LbRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRB.Location = new System.Drawing.Point(228, 178);
            this.LbRB.Name = "LbRB";
            this.LbRB.Size = new System.Drawing.Size(73, 24);
            this.LbRB.TabIndex = 7;
            this.LbRB.TabStop = true;
            this.LbRB.Text = "Pound";
            this.LbRB.UseVisualStyleBackColor = true;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(48, 345);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(276, 32);
            this.LaskeBT.TabIndex = 8;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(48, 391);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(92, 40);
            this.ResetBT.TabIndex = 9;
            this.ResetBT.Text = "Reset";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // PoistuBT
            // 
            this.PoistuBT.Location = new System.Drawing.Point(228, 391);
            this.PoistuBT.Name = "PoistuBT";
            this.PoistuBT.Size = new System.Drawing.Size(96, 40);
            this.PoistuBT.TabIndex = 10;
            this.PoistuBT.Text = "Poistu";
            this.PoistuBT.UseVisualStyleBackColor = true;
            this.PoistuBT.Click += new System.EventHandler(this.PoistuBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(106, 261);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(68, 20);
            this.VastausLB.TabIndex = 11;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KuvausLB.Location = new System.Drawing.Point(110, 296);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(61, 20);
            this.KuvausLB.TabIndex = 12;
            this.KuvausLB.Text = "Kuvaus";
            this.KuvausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 629);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.PoistuBT);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.LbRB);
            this.Controls.Add(this.KgRB);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.PainoTB);
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
        private System.Windows.Forms.TextBox PainoTB;
        private System.Windows.Forms.TextBox PituusTB;
        private System.Windows.Forms.RadioButton KgRB;
        private System.Windows.Forms.RadioButton LbRB;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Button ResetBT;
        private System.Windows.Forms.Button PoistuBT;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Label KuvausLB;
    }
}

