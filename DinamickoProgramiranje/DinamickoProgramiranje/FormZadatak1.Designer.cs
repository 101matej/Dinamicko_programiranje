namespace DinamickoProgramiranje
{
    partial class FormZadatak1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZadatak1));
            this.gbPojmovnik = new System.Windows.Forms.GroupBox();
            this.rtbPojmovnik = new System.Windows.Forms.RichTextBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.gbIzracun = new System.Windows.Forms.GroupBox();
            this.brojC = new System.Windows.Forms.NumericUpDown();
            this.brojP = new System.Windows.Forms.NumericUpDown();
            this.brojA = new System.Windows.Forms.NumericUpDown();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.lbC = new System.Windows.Forms.Label();
            this.lbP = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.rtbPostupak = new System.Windows.Forms.RichTextBox();
            this.gbPostupak = new System.Windows.Forms.GroupBox();
            this.gbPojmovnik.SuspendLayout();
            this.gbIzracun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brojC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojA)).BeginInit();
            this.gbPostupak.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPojmovnik
            // 
            this.gbPojmovnik.Controls.Add(this.rtbPojmovnik);
            this.gbPojmovnik.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPojmovnik.Location = new System.Drawing.Point(12, 12);
            this.gbPojmovnik.Name = "gbPojmovnik";
            this.gbPojmovnik.Size = new System.Drawing.Size(722, 184);
            this.gbPojmovnik.TabIndex = 1;
            this.gbPojmovnik.TabStop = false;
            this.gbPojmovnik.Text = "Pojmovnik:";
            // 
            // rtbPojmovnik
            // 
            this.rtbPojmovnik.BackColor = System.Drawing.SystemColors.Info;
            this.rtbPojmovnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbPojmovnik.Location = new System.Drawing.Point(12, 39);
            this.rtbPojmovnik.Name = "rtbPojmovnik";
            this.rtbPojmovnik.ReadOnly = true;
            this.rtbPojmovnik.Size = new System.Drawing.Size(689, 128);
            this.rtbPojmovnik.TabIndex = 1;
            this.rtbPojmovnik.Text = resources.GetString("rtbPojmovnik.Text");
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNazad.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazad.Location = new System.Drawing.Point(225, 778);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(224, 82);
            this.btnNazad.TabIndex = 6;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // gbIzracun
            // 
            this.gbIzracun.Controls.Add(this.brojC);
            this.gbIzracun.Controls.Add(this.brojP);
            this.gbIzracun.Controls.Add(this.brojA);
            this.gbIzracun.Controls.Add(this.btnIzracunaj);
            this.gbIzracun.Controls.Add(this.lbC);
            this.gbIzracun.Controls.Add(this.lbP);
            this.gbIzracun.Controls.Add(this.lbA);
            this.gbIzracun.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbIzracun.Location = new System.Drawing.Point(12, 231);
            this.gbIzracun.Name = "gbIzracun";
            this.gbIzracun.Size = new System.Drawing.Size(722, 221);
            this.gbIzracun.TabIndex = 9;
            this.gbIzracun.TabStop = false;
            this.gbIzracun.Text = "Izračun:";
            // 
            // brojC
            // 
            this.brojC.Location = new System.Drawing.Point(138, 158);
            this.brojC.Name = "brojC";
            this.brojC.Size = new System.Drawing.Size(169, 40);
            this.brojC.TabIndex = 19;
            // 
            // brojP
            // 
            this.brojP.Location = new System.Drawing.Point(138, 97);
            this.brojP.Name = "brojP";
            this.brojP.Size = new System.Drawing.Size(169, 40);
            this.brojP.TabIndex = 18;
            // 
            // brojA
            // 
            this.brojA.Location = new System.Drawing.Point(138, 37);
            this.brojA.Name = "brojA";
            this.brojA.Size = new System.Drawing.Size(169, 40);
            this.brojA.TabIndex = 17;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIzracunaj.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunaj.Location = new System.Drawing.Point(396, 83);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(224, 82);
            this.btnIzracunaj.TabIndex = 10;
            this.btnIzracunaj.Text = "IZRAČUNAJ";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbC.Location = new System.Drawing.Point(27, 167);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(94, 22);
            this.lbC.TabIndex = 14;
            this.lbC.Text = "Unesite C:";
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbP.Location = new System.Drawing.Point(27, 106);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(93, 22);
            this.lbP.TabIndex = 12;
            this.lbP.Text = "Unesite P:";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbA.Location = new System.Drawing.Point(27, 46);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(93, 22);
            this.lbA.TabIndex = 10;
            this.lbA.Text = "Unesite A:";
            // 
            // rtbPostupak
            // 
            this.rtbPostupak.BackColor = System.Drawing.SystemColors.Info;
            this.rtbPostupak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbPostupak.Location = new System.Drawing.Point(12, 39);
            this.rtbPostupak.Name = "rtbPostupak";
            this.rtbPostupak.ReadOnly = true;
            this.rtbPostupak.Size = new System.Drawing.Size(689, 208);
            this.rtbPostupak.TabIndex = 2;
            this.rtbPostupak.Text = "";
            // 
            // gbPostupak
            // 
            this.gbPostupak.Controls.Add(this.rtbPostupak);
            this.gbPostupak.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPostupak.Location = new System.Drawing.Point(12, 495);
            this.gbPostupak.Name = "gbPostupak";
            this.gbPostupak.Size = new System.Drawing.Size(722, 265);
            this.gbPostupak.TabIndex = 15;
            this.gbPostupak.TabStop = false;
            this.gbPostupak.Text = "Postupak:";
            // 
            // FormZadatak1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2485, 845);
            this.Controls.Add(this.gbPostupak);
            this.Controls.Add(this.gbIzracun);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.gbPojmovnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormZadatak1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimalni godišnji broj narudžbi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormZadatak1_Load);
            this.gbPojmovnik.ResumeLayout(false);
            this.gbIzracun.ResumeLayout(false);
            this.gbIzracun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brojC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojA)).EndInit();
            this.gbPostupak.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPojmovnik;
        private System.Windows.Forms.RichTextBox rtbPojmovnik;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.GroupBox gbIzracun;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.RichTextBox rtbPostupak;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.GroupBox gbPostupak;
        private System.Windows.Forms.NumericUpDown brojC;
        private System.Windows.Forms.NumericUpDown brojP;
        private System.Windows.Forms.NumericUpDown brojA;
    }
}