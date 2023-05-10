namespace DinamickoProgramiranje
{
    partial class FormZadatak4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZadatak4));
            this.btnNazad = new System.Windows.Forms.Button();
            this.gbPojmovnik = new System.Windows.Forms.GroupBox();
            this.rtbPojmovnik = new System.Windows.Forms.RichTextBox();
            this.gbIzracun = new System.Windows.Forms.GroupBox();
            this.brojMinimalno = new System.Windows.Forms.NumericUpDown();
            this.lbMinimalno = new System.Windows.Forms.Label();
            this.brojRabat = new System.Windows.Forms.NumericUpDown();
            this.lbRabat = new System.Windows.Forms.Label();
            this.brojC = new System.Windows.Forms.NumericUpDown();
            this.lbC = new System.Windows.Forms.Label();
            this.brojP = new System.Windows.Forms.NumericUpDown();
            this.brojM = new System.Windows.Forms.NumericUpDown();
            this.lbM = new System.Windows.Forms.Label();
            this.brojR = new System.Windows.Forms.NumericUpDown();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.lbP = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.gbPostupakBezRabata = new System.Windows.Forms.GroupBox();
            this.rtbPostupakBezRabata = new System.Windows.Forms.RichTextBox();
            this.gbPostupakSRabatom = new System.Windows.Forms.GroupBox();
            this.rtbPostupakSRabatom = new System.Windows.Forms.RichTextBox();
            this.gbPojmovnik.SuspendLayout();
            this.gbIzracun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brojMinimalno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRabat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojR)).BeginInit();
            this.gbPostupakBezRabata.SuspendLayout();
            this.gbPostupakSRabatom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNazad.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazad.Location = new System.Drawing.Point(841, 727);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(215, 70);
            this.btnNazad.TabIndex = 9;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // gbPojmovnik
            // 
            this.gbPojmovnik.Controls.Add(this.rtbPojmovnik);
            this.gbPojmovnik.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPojmovnik.Location = new System.Drawing.Point(47, 37);
            this.gbPojmovnik.Name = "gbPojmovnik";
            this.gbPojmovnik.Size = new System.Drawing.Size(803, 221);
            this.gbPojmovnik.TabIndex = 10;
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
            this.rtbPojmovnik.Size = new System.Drawing.Size(773, 166);
            this.rtbPojmovnik.TabIndex = 1;
            this.rtbPojmovnik.Text = resources.GetString("rtbPojmovnik.Text");
            // 
            // gbIzracun
            // 
            this.gbIzracun.Controls.Add(this.brojMinimalno);
            this.gbIzracun.Controls.Add(this.lbMinimalno);
            this.gbIzracun.Controls.Add(this.brojRabat);
            this.gbIzracun.Controls.Add(this.lbRabat);
            this.gbIzracun.Controls.Add(this.brojC);
            this.gbIzracun.Controls.Add(this.lbC);
            this.gbIzracun.Controls.Add(this.brojP);
            this.gbIzracun.Controls.Add(this.brojM);
            this.gbIzracun.Controls.Add(this.lbM);
            this.gbIzracun.Controls.Add(this.brojR);
            this.gbIzracun.Controls.Add(this.btnIzracunaj);
            this.gbIzracun.Controls.Add(this.lbP);
            this.gbIzracun.Controls.Add(this.lbR);
            this.gbIzracun.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbIzracun.Location = new System.Drawing.Point(47, 280);
            this.gbIzracun.Name = "gbIzracun";
            this.gbIzracun.Size = new System.Drawing.Size(803, 281);
            this.gbIzracun.TabIndex = 12;
            this.gbIzracun.TabStop = false;
            this.gbIzracun.Text = "Izračun:";
            // 
            // brojMinimalno
            // 
            this.brojMinimalno.Location = new System.Drawing.Point(592, 96);
            this.brojMinimalno.Name = "brojMinimalno";
            this.brojMinimalno.Size = new System.Drawing.Size(169, 40);
            this.brojMinimalno.TabIndex = 25;
            // 
            // lbMinimalno
            // 
            this.lbMinimalno.AutoSize = true;
            this.lbMinimalno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMinimalno.Location = new System.Drawing.Point(411, 104);
            this.lbMinimalno.Name = "lbMinimalno";
            this.lbMinimalno.Size = new System.Drawing.Size(109, 22);
            this.lbMinimalno.TabIndex = 24;
            this.lbMinimalno.Text = "Unesite Min:";
            // 
            // brojRabat
            // 
            this.brojRabat.Location = new System.Drawing.Point(592, 40);
            this.brojRabat.Name = "brojRabat";
            this.brojRabat.Size = new System.Drawing.Size(169, 40);
            this.brojRabat.TabIndex = 23;
            // 
            // lbRabat
            // 
            this.lbRabat.AutoSize = true;
            this.lbRabat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRabat.Location = new System.Drawing.Point(411, 48);
            this.lbRabat.Name = "lbRabat";
            this.lbRabat.Size = new System.Drawing.Size(129, 22);
            this.lbRabat.TabIndex = 22;
            this.lbRabat.Text = "Unesite Rabat:";
            // 
            // brojC
            // 
            this.brojC.Location = new System.Drawing.Point(170, 207);
            this.brojC.Name = "brojC";
            this.brojC.Size = new System.Drawing.Size(169, 40);
            this.brojC.TabIndex = 21;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbC.Location = new System.Drawing.Point(26, 216);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(94, 22);
            this.lbC.TabIndex = 20;
            this.lbC.Text = "Unesite C:";
            // 
            // brojP
            // 
            this.brojP.Location = new System.Drawing.Point(170, 151);
            this.brojP.Name = "brojP";
            this.brojP.Size = new System.Drawing.Size(169, 40);
            this.brojP.TabIndex = 19;
            // 
            // brojM
            // 
            this.brojM.Location = new System.Drawing.Point(170, 39);
            this.brojM.Name = "brojM";
            this.brojM.Size = new System.Drawing.Size(169, 40);
            this.brojM.TabIndex = 18;
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbM.Location = new System.Drawing.Point(26, 48);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(95, 22);
            this.lbM.TabIndex = 12;
            this.lbM.Text = "Unesite M:";
            // 
            // brojR
            // 
            this.brojR.Location = new System.Drawing.Point(170, 95);
            this.brojR.Name = "brojR";
            this.brojR.Size = new System.Drawing.Size(169, 40);
            this.brojR.TabIndex = 17;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIzracunaj.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunaj.Location = new System.Drawing.Point(460, 163);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(235, 75);
            this.btnIzracunaj.TabIndex = 10;
            this.btnIzracunaj.Text = "IZRAČUNAJ";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbP.Location = new System.Drawing.Point(26, 160);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(93, 22);
            this.lbP.TabIndex = 14;
            this.lbP.Text = "Unesite P:";
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbR.Location = new System.Drawing.Point(26, 104);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(94, 22);
            this.lbR.TabIndex = 10;
            this.lbR.Text = "Unesite R:";
            // 
            // gbPostupakBezRabata
            // 
            this.gbPostupakBezRabata.Controls.Add(this.rtbPostupakBezRabata);
            this.gbPostupakBezRabata.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPostupakBezRabata.Location = new System.Drawing.Point(911, 37);
            this.gbPostupakBezRabata.Name = "gbPostupakBezRabata";
            this.gbPostupakBezRabata.Size = new System.Drawing.Size(504, 524);
            this.gbPostupakBezRabata.TabIndex = 18;
            this.gbPostupakBezRabata.TabStop = false;
            this.gbPostupakBezRabata.Text = "Postupak bez rabata:";
            // 
            // rtbPostupakBezRabata
            // 
            this.rtbPostupakBezRabata.BackColor = System.Drawing.SystemColors.Info;
            this.rtbPostupakBezRabata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbPostupakBezRabata.Location = new System.Drawing.Point(15, 34);
            this.rtbPostupakBezRabata.Name = "rtbPostupakBezRabata";
            this.rtbPostupakBezRabata.ReadOnly = true;
            this.rtbPostupakBezRabata.Size = new System.Drawing.Size(469, 471);
            this.rtbPostupakBezRabata.TabIndex = 2;
            this.rtbPostupakBezRabata.Text = "";
            // 
            // gbPostupakSRabatom
            // 
            this.gbPostupakSRabatom.Controls.Add(this.rtbPostupakSRabatom);
            this.gbPostupakSRabatom.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPostupakSRabatom.Location = new System.Drawing.Point(1470, 37);
            this.gbPostupakSRabatom.Name = "gbPostupakSRabatom";
            this.gbPostupakSRabatom.Size = new System.Drawing.Size(504, 524);
            this.gbPostupakSRabatom.TabIndex = 19;
            this.gbPostupakSRabatom.TabStop = false;
            this.gbPostupakSRabatom.Text = "Postupak s rabatom:";
            // 
            // rtbPostupakSRabatom
            // 
            this.rtbPostupakSRabatom.BackColor = System.Drawing.SystemColors.Info;
            this.rtbPostupakSRabatom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbPostupakSRabatom.Location = new System.Drawing.Point(13, 39);
            this.rtbPostupakSRabatom.Name = "rtbPostupakSRabatom";
            this.rtbPostupakSRabatom.ReadOnly = true;
            this.rtbPostupakSRabatom.Size = new System.Drawing.Size(471, 466);
            this.rtbPostupakSRabatom.TabIndex = 2;
            this.rtbPostupakSRabatom.Text = "";
            // 
            // FormZadatak4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2062, 858);
            this.Controls.Add(this.gbPostupakSRabatom);
            this.Controls.Add(this.gbPostupakBezRabata);
            this.Controls.Add(this.gbIzracun);
            this.Controls.Add(this.gbPojmovnik);
            this.Controls.Add(this.btnNazad);
            this.Name = "FormZadatak4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metoda usporedbe ukupnih troškova ponude";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormZadatak4_Load);
            this.gbPojmovnik.ResumeLayout(false);
            this.gbIzracun.ResumeLayout(false);
            this.gbIzracun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brojMinimalno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRabat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojR)).EndInit();
            this.gbPostupakBezRabata.ResumeLayout(false);
            this.gbPostupakSRabatom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.GroupBox gbPojmovnik;
        private System.Windows.Forms.RichTextBox rtbPojmovnik;
        private System.Windows.Forms.GroupBox gbIzracun;
        private System.Windows.Forms.NumericUpDown brojC;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.NumericUpDown brojP;
        private System.Windows.Forms.NumericUpDown brojM;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.NumericUpDown brojR;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.NumericUpDown brojRabat;
        private System.Windows.Forms.Label lbRabat;
        private System.Windows.Forms.GroupBox gbPostupakBezRabata;
        private System.Windows.Forms.RichTextBox rtbPostupakBezRabata;
        private System.Windows.Forms.GroupBox gbPostupakSRabatom;
        private System.Windows.Forms.RichTextBox rtbPostupakSRabatom;
        private System.Windows.Forms.NumericUpDown brojMinimalno;
        private System.Windows.Forms.Label lbMinimalno;
    }
}