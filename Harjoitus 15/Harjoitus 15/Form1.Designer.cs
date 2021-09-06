namespace Harjoitus_15
{
    partial class sekunttiForm
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
            this.AikaLB = new System.Windows.Forms.Label();
            this.KaynnistaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.AikaTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AikaLB.Location = new System.Drawing.Point(12, 9);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(603, 108);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00.00.00.000";
            // 
            // KaynnistaBT
            // 
            this.KaynnistaBT.Location = new System.Drawing.Point(30, 174);
            this.KaynnistaBT.Name = "KaynnistaBT";
            this.KaynnistaBT.Size = new System.Drawing.Size(127, 78);
            this.KaynnistaBT.TabIndex = 1;
            this.KaynnistaBT.Text = "Käynnistä";
            this.KaynnistaBT.UseVisualStyleBackColor = true;
            this.KaynnistaBT.Click += new System.EventHandler(this.KaynnistaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(440, 174);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(137, 78);
            this.TyhjennaBT.TabIndex = 2;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Location = new System.Drawing.Point(233, 174);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(137, 78);
            this.LopetaBT.TabIndex = 3;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // AikaTM
            // 
            this.AikaTM.Enabled = true;
            this.AikaTM.Tick += new System.EventHandler(this.AikaTM_Tick);
            // 
            // sekunttiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 267);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.KaynnistaBT);
            this.Controls.Add(this.AikaLB);
            this.Name = "sekunttiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekunttikello";
            this.Load += new System.EventHandler(this.sekunttiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button KaynnistaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button LopetaBT;
        private System.Windows.Forms.Timer AikaTM;
    }
}

