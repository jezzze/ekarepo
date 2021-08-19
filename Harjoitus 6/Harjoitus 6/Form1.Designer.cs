namespace Harjoitus_6
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.VirheViestiLB = new System.Windows.Forms.Label();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.VirheViestiLB);
            this.SalasanaPanel.Controls.Add(this.tarkistaBT);
            this.SalasanaPanel.Controls.Add(this.salasanaTB);
            this.SalasanaPanel.Controls.Add(this.kayttajaTB);
            this.SalasanaPanel.Controls.Add(this.SalasanaLB);
            this.SalasanaPanel.Controls.Add(this.KayttajaLB);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(633, 266);
            this.SalasanaPanel.TabIndex = 0;
            // 
            // VirheViestiLB
            // 
            this.VirheViestiLB.AutoSize = true;
            this.VirheViestiLB.Location = new System.Drawing.Point(90, 214);
            this.VirheViestiLB.Name = "VirheViestiLB";
            this.VirheViestiLB.Size = new System.Drawing.Size(69, 29);
            this.VirheViestiLB.TabIndex = 5;
            this.VirheViestiLB.Text = "Virhe";
            this.VirheViestiLB.Visible = false;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tarkistaBT.Location = new System.Drawing.Point(408, 139);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(113, 63);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = true;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(250, 98);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.PasswordChar = '*';
            this.salasanaTB.Size = new System.Drawing.Size(271, 35);
            this.salasanaTB.TabIndex = 3;
            this.salasanaTB.TextChanged += new System.EventHandler(this.salasanaTB_TextChanged);
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(250, 49);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(271, 35);
            this.kayttajaTB.TabIndex = 2;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Location = new System.Drawing.Point(126, 98);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(118, 29);
            this.SalasanaLB.TabIndex = 1;
            this.SalasanaLB.Text = "Salasana:";
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.Location = new System.Drawing.Point(71, 52);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(173, 29);
            this.KayttajaLB.TabIndex = 0;
            this.KayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.label1);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(633, 266);
            this.SalasanaOikeinPanel.TabIndex = 1;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa Sivulleni";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 266);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Controls.Add(this.SalasanaPanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaPanel;
        private System.Windows.Forms.Label VirheViestiLB;
        private System.Windows.Forms.Button tarkistaBT;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label KayttajaLB;
        private System.Windows.Forms.Panel SalasanaOikeinPanel;
        private System.Windows.Forms.Label label1;
    }
}

