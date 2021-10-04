namespace Harjoitus_7
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
            this.FahrenheitToRB = new System.Windows.Forms.RadioButton();
            this.CelsiusToRB = new System.Windows.Forms.RadioButton();
            this.MaaraTB = new System.Windows.Forms.TextBox();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FahrenheitToRB
            // 
            this.FahrenheitToRB.AutoSize = true;
            this.FahrenheitToRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitToRB.Location = new System.Drawing.Point(12, 52);
            this.FahrenheitToRB.Name = "FahrenheitToRB";
            this.FahrenheitToRB.Size = new System.Drawing.Size(192, 24);
            this.FahrenheitToRB.TabIndex = 0;
            this.FahrenheitToRB.TabStop = true;
            this.FahrenheitToRB.Text = "Fahrenheit celsiukseksi";
            this.FahrenheitToRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusToRB
            // 
            this.CelsiusToRB.AutoSize = true;
            this.CelsiusToRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusToRB.Location = new System.Drawing.Point(12, 12);
            this.CelsiusToRB.Name = "CelsiusToRB";
            this.CelsiusToRB.Size = new System.Drawing.Size(181, 24);
            this.CelsiusToRB.TabIndex = 1;
            this.CelsiusToRB.TabStop = true;
            this.CelsiusToRB.Text = "Celsius Fahrenheitiksi";
            this.CelsiusToRB.UseVisualStyleBackColor = true;
            // 
            // MaaraTB
            // 
            this.MaaraTB.Location = new System.Drawing.Point(12, 97);
            this.MaaraTB.Name = "MaaraTB";
            this.MaaraTB.Size = new System.Drawing.Size(181, 20);
            this.MaaraTB.TabIndex = 4;
            // 
            // MuutaBT
            // 
            this.MuutaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuutaBT.Location = new System.Drawing.Point(33, 146);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(148, 35);
            this.MuutaBT.TabIndex = 5;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(30, 204);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(45, 13);
            this.VastausLB.TabIndex = 6;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 289);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.MaaraTB);
            this.Controls.Add(this.CelsiusToRB);
            this.Controls.Add(this.FahrenheitToRB);
            this.Name = "Form1";
            this.Text = "Celsius fahrenheit Muunnin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FahrenheitToRB;
        private System.Windows.Forms.RadioButton CelsiusToRB;
        private System.Windows.Forms.TextBox MaaraTB;
        private System.Windows.Forms.Button MuutaBT;
        private System.Windows.Forms.Label VastausLB;
    }
}

