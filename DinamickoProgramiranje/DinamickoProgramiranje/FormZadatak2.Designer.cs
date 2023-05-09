namespace DinamickoProgramiranje
{
    partial class FormZadatak2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZadatak2));
            this.gbPojmovnik = new System.Windows.Forms.GroupBox();
            this.rtbPojmovnik = new System.Windows.Forms.RichTextBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.gbIzracun = new System.Windows.Forms.GroupBox();
            this.brojP = new System.Windows.Forms.NumericUpDown();
            this.brojM = new System.Windows.Forms.NumericUpDown();
            this.brojR = new System.Windows.Forms.NumericUpDown();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.lbP = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.brojC = new System.Windows.Forms.NumericUpDown();
            this.lbC = new System.Windows.Forms.Label();
            this.gbPostupak = new System.Windows.Forms.GroupBox();
            this.rtbPostupak = new System.Windows.Forms.RichTextBox();
            this.gbPojmovnik.SuspendLayout();
            this.gbIzracun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brojP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojC)).BeginInit();
            this.gbPostupak.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPojmovnik
            // 
            this.gbPojmovnik.Controls.Add(this.rtbPojmovnik);
            this.gbPojmovnik.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPojmovnik.Location = new System.Drawing.Point(12, 12);
            this.gbPojmovnik.Name = "gbPojmovnik";
            this.gbPojmovnik.Size = new System.Drawing.Size(592, 154);
            this.gbPojmovnik.TabIndex = 2;
            this.gbPojmovnik.TabStop = false;
            this.gbPojmovnik.Text = "Pojmovnik:";
            // 
            // rtbPojmovnik
            // 
            this.rtbPojmovnik.BackColor = System.Drawing.SystemColors.Info;
            this.rtbPojmovnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbPojmovnik.Location = new System.Drawing.Point(6, 30);
            this.rtbPojmovnik.Name = "rtbPojmovnik";
            this.rtbPojmovnik.ReadOnly = true;
            this.rtbPojmovnik.Size = new System.Drawing.Size(573, 110);
            this.rtbPojmovnik.TabIndex = 1;
            this.rtbPojmovnik.Text = resources.GetString("rtbPojmovnik.Text");
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNazad.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazad.Location = new System.Drawing.Point(626, 24);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(112, 59);
            this.btnNazad.TabIndex = 7;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // gbIzracun
            // 
            this.gbIzracun.Controls.Add(this.brojC);
            this.gbIzracun.Controls.Add(this.lbC);
            this.gbIzracun.Controls.Add(this.brojP);
            this.gbIzracun.Controls.Add(this.brojM);
            this.gbIzracun.Controls.Add(this.lbM);
            this.gbIzracun.Controls.Add(this.brojR);
            this.gbIzracun.Controls.Add(this.btnIzracunaj);
            this.gbIzracun.Controls.Add(this.lbP);
            this.gbIzracun.Controls.Add(this.lbR);
            this.gbIzracun.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIzracun.Location = new System.Drawing.Point(12, 172);
            this.gbIzracun.Name = "gbIzracun";
            this.gbIzracun.Size = new System.Drawing.Size(592, 206);
            this.gbIzracun.TabIndex = 10;
            this.gbIzracun.TabStop = false;
            this.gbIzracun.Text = "Izračun:";
            // 
            // brojP
            // 
            this.brojP.Location = new System.Drawing.Point(111, 77);
            this.brojP.Name = "brojP";
            this.brojP.Size = new System.Drawing.Size(135, 31);
            this.brojP.TabIndex = 19;
            // 
            // brojM
            // 
            this.brojM.Location = new System.Drawing.Point(111, 40);
            this.brojM.Name = "brojM";
            this.brojM.Size = new System.Drawing.Size(135, 31);
            this.brojM.TabIndex = 18;
            // 
            // brojR
            // 
            this.brojR.Location = new System.Drawing.Point(111, 114);
            this.brojR.Name = "brojR";
            this.brojR.Size = new System.Drawing.Size(135, 31);
            this.brojR.TabIndex = 17;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIzracunaj.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunaj.Location = new System.Drawing.Point(352, 83);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(150, 59);
            this.btnIzracunaj.TabIndex = 10;
            this.btnIzracunaj.Text = "IZRAČUNAJ";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbP.Location = new System.Drawing.Point(27, 85);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(68, 16);
            this.lbP.TabIndex = 14;
            this.lbP.Text = "Unesite P:";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbM.Location = new System.Drawing.Point(27, 48);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(70, 16);
            this.lbM.TabIndex = 12;
            this.lbM.Text = "Unesite M:";
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbR.Location = new System.Drawing.Point(27, 122);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(69, 16);
            this.lbR.TabIndex = 10;
            this.lbR.Text = "Unesite R:";
            // 
            // brojC
            // 
            this.brojC.Location = new System.Drawing.Point(111, 152);
            this.brojC.Name = "brojC";
            this.brojC.Size = new System.Drawing.Size(135, 31);
            this.brojC.TabIndex = 21;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbC.Location = new System.Drawing.Point(27, 160);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(68, 16);
            this.lbC.TabIndex = 20;
            this.lbC.Text = "Unesite C:";
            // 
            // gbPostupak
            // 
            this.gbPostupak.Controls.Add(this.rtbPostupak);
            this.gbPostupak.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPostupak.Location = new System.Drawing.Point(12, 384);
            this.gbPostupak.Name = "gbPostupak";
            this.gbPostupak.Size = new System.Drawing.Size(592, 199);
            this.gbPostupak.TabIndex = 16;
            this.gbPostupak.TabStop = false;
            this.gbPostupak.Text = "Postupak:";
            // 
            // rtbPostupak
            // 
            this.rtbPostupak.BackColor = System.Drawing.SystemColors.Info;
            this.rtbPostupak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbPostupak.Location = new System.Drawing.Point(13, 30);
            this.rtbPostupak.Name = "rtbPostupak";
            this.rtbPostupak.ReadOnly = true;
            this.rtbPostupak.Size = new System.Drawing.Size(566, 145);
            this.rtbPostupak.TabIndex = 2;
            this.rtbPostupak.Text = "";
            // 
            // FormZadatak2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 574);
            this.Controls.Add(this.gbPostupak);
            this.Controls.Add(this.gbIzracun);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.gbPojmovnik);
            this.Name = "FormZadatak2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimalni broj jedinica po jednoj narudžbi";
            this.gbPojmovnik.ResumeLayout(false);
            this.gbIzracun.ResumeLayout(false);
            this.gbIzracun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brojP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojC)).EndInit();
            this.gbPostupak.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPojmovnik;
        private System.Windows.Forms.RichTextBox rtbPojmovnik;
        private System.Windows.Forms.Button btnNazad;
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
        private System.Windows.Forms.GroupBox gbPostupak;
        private System.Windows.Forms.RichTextBox rtbPostupak;
    }
}