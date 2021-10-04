namespace Harjoitus_20
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
            this.IdLB = new System.Windows.Forms.Label();
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.SukunimiLB = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.EtuTB = new System.Windows.Forms.TextBox();
            this.SukuTB = new System.Windows.Forms.TextBox();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.ONroTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PuhTB = new System.Windows.Forms.TextBox();
            this.OpiskelijanumeroLB = new System.Windows.Forms.Label();
            this.SahkopostiLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // IdLB
            // 
            this.IdLB.AutoSize = true;
            this.IdLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLB.Location = new System.Drawing.Point(81, 29);
            this.IdLB.Name = "IdLB";
            this.IdLB.Size = new System.Drawing.Size(32, 24);
            this.IdLB.TabIndex = 0;
            this.IdLB.Text = "ID:";
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtunimiLB.Location = new System.Drawing.Point(35, 62);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.Size = new System.Drawing.Size(78, 24);
            this.EtunimiLB.TabIndex = 1;
            this.EtunimiLB.Text = "Etunimi:";
            // 
            // SukunimiLB
            // 
            this.SukunimiLB.AutoSize = true;
            this.SukunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SukunimiLB.Location = new System.Drawing.Point(20, 94);
            this.SukunimiLB.Name = "SukunimiLB";
            this.SukunimiLB.Size = new System.Drawing.Size(93, 24);
            this.SukunimiLB.TabIndex = 2;
            this.SukunimiLB.Text = "Sukunimi:";
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(138, 29);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(169, 26);
            this.IdTB.TabIndex = 3;
            // 
            // EtuTB
            // 
            this.EtuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtuTB.Location = new System.Drawing.Point(138, 64);
            this.EtuTB.Name = "EtuTB";
            this.EtuTB.Size = new System.Drawing.Size(169, 26);
            this.EtuTB.TabIndex = 4;
            // 
            // SukuTB
            // 
            this.SukuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SukuTB.Location = new System.Drawing.Point(138, 96);
            this.SukuTB.Name = "SukuTB";
            this.SukuTB.Size = new System.Drawing.Size(169, 26);
            this.SukuTB.TabIndex = 5;
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(24, 141);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(101, 36);
            this.TyhjennaBT.TabIndex = 6;
            this.TyhjennaBT.Text = "TYHJENNÄ";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // TallennaBT
            // 
            this.TallennaBT.Location = new System.Drawing.Point(189, 141);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(91, 36);
            this.TallennaBT.TabIndex = 7;
            this.TallennaBT.Text = "TALLENNA";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Location = new System.Drawing.Point(347, 141);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(93, 36);
            this.PaivitaBT.TabIndex = 8;
            this.PaivitaBT.Text = "PÄIVITÄ";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(481, 141);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(96, 36);
            this.PoistaBT.TabIndex = 9;
            this.PoistaBT.Text = "POISTA";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // ONroTB
            // 
            this.ONroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONroTB.Location = new System.Drawing.Point(494, 96);
            this.ONroTB.Name = "ONroTB";
            this.ONroTB.Size = new System.Drawing.Size(169, 26);
            this.ONroTB.TabIndex = 15;
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(494, 64);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(169, 26);
            this.EmailTB.TabIndex = 14;
            // 
            // PuhTB
            // 
            this.PuhTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhTB.Location = new System.Drawing.Point(494, 27);
            this.PuhTB.Name = "PuhTB";
            this.PuhTB.Size = new System.Drawing.Size(169, 26);
            this.PuhTB.TabIndex = 13;
            // 
            // OpiskelijanumeroLB
            // 
            this.OpiskelijanumeroLB.AutoSize = true;
            this.OpiskelijanumeroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpiskelijanumeroLB.Location = new System.Drawing.Point(326, 94);
            this.OpiskelijanumeroLB.Name = "OpiskelijanumeroLB";
            this.OpiskelijanumeroLB.Size = new System.Drawing.Size(162, 24);
            this.OpiskelijanumeroLB.TabIndex = 12;
            this.OpiskelijanumeroLB.Text = "Opiskelijanumero:";
            // 
            // SahkopostiLB
            // 
            this.SahkopostiLB.AutoSize = true;
            this.SahkopostiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SahkopostiLB.Location = new System.Drawing.Point(381, 62);
            this.SahkopostiLB.Name = "SahkopostiLB";
            this.SahkopostiLB.Size = new System.Drawing.Size(107, 24);
            this.SahkopostiLB.TabIndex = 11;
            this.SahkopostiLB.Text = "Sähköposti:";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhelinLB.Location = new System.Drawing.Point(409, 31);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(79, 24);
            this.PuhelinLB.TabIndex = 10;
            this.PuhelinLB.Text = "Puhelin:";
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(12, 183);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(1000, 354);
            this.TietotauluDG.TabIndex = 16;
            this.TietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 538);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.ONroTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PuhTB);
            this.Controls.Add(this.OpiskelijanumeroLB);
            this.Controls.Add(this.SahkopostiLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.SukuTB);
            this.Controls.Add(this.EtuTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.SukunimiLB);
            this.Controls.Add(this.EtunimiLB);
            this.Controls.Add(this.IdLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLB;
        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.Label SukunimiLB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox EtuTB;
        private System.Windows.Forms.TextBox SukuTB;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.TextBox ONroTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PuhTB;
        private System.Windows.Forms.Label OpiskelijanumeroLB;
        private System.Windows.Forms.Label SahkopostiLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.DataGridView TietotauluDG;
    }
}

