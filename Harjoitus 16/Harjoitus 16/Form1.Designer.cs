namespace Harjoitus_16
{
    partial class LaskuriForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinuutitCB = new System.Windows.Forms.ComboBox();
            this.SekuntitCB = new System.Windows.Forms.ComboBox();
            this.AikaLB = new System.Windows.Forms.Label();
            this.AloitaBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit:";
            // 
            // MinuutitCB
            // 
            this.MinuutitCB.FormattingEnabled = true;
            this.MinuutitCB.Location = new System.Drawing.Point(16, 36);
            this.MinuutitCB.Name = "MinuutitCB";
            this.MinuutitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinuutitCB.Size = new System.Drawing.Size(76, 32);
            this.MinuutitCB.TabIndex = 2;
            // 
            // SekuntitCB
            // 
            this.SekuntitCB.FormattingEnabled = true;
            this.SekuntitCB.Location = new System.Drawing.Point(102, 36);
            this.SekuntitCB.Name = "SekuntitCB";
            this.SekuntitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SekuntitCB.Size = new System.Drawing.Size(76, 32);
            this.SekuntitCB.TabIndex = 3;
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AikaLB.Location = new System.Drawing.Point(38, 80);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(112, 42);
            this.AikaLB.TabIndex = 4;
            this.AikaLB.Text = "00:00";
            // 
            // AloitaBT
            // 
            this.AloitaBT.Location = new System.Drawing.Point(16, 134);
            this.AloitaBT.Name = "AloitaBT";
            this.AloitaBT.Size = new System.Drawing.Size(80, 32);
            this.AloitaBT.TabIndex = 5;
            this.AloitaBT.Text = "Aloita";
            this.AloitaBT.UseVisualStyleBackColor = true;
            this.AloitaBT.Click += new System.EventHandler(this.AloitaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Location = new System.Drawing.Point(102, 133);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(84, 33);
            this.LopetaBT.TabIndex = 6;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // LaskuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 208);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.AloitaBT);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.SekuntitCB);
            this.Controls.Add(this.MinuutitCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LaskuriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.LaskuriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MinuutitCB;
        private System.Windows.Forms.ComboBox SekuntitCB;
        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button AloitaBT;
        private System.Windows.Forms.Button LopetaBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}

