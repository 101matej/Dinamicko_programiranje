namespace DinamickoProgramiranje
{
    partial class FormModeliZaliha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModeliZaliha));
            this.btnZad1 = new System.Windows.Forms.Button();
            this.btnZad2 = new System.Windows.Forms.Button();
            this.btnZad3 = new System.Windows.Forms.Button();
            this.gbZadaci = new System.Windows.Forms.GroupBox();
            this.btnZad4 = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.gbZadaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZad1
            // 
            this.btnZad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZad1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZad1.Location = new System.Drawing.Point(21, 40);
            this.btnZad1.Name = "btnZad1";
            this.btnZad1.Size = new System.Drawing.Size(950, 89);
            this.btnZad1.TabIndex = 1;
            this.btnZad1.Text = "OPTIMALNI GODIŠNJI BROJ NARUDŽBI";
            this.btnZad1.UseVisualStyleBackColor = false;
            this.btnZad1.Click += new System.EventHandler(this.btnZad1_Click);
            // 
            // btnZad2
            // 
            this.btnZad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZad2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZad2.Location = new System.Drawing.Point(21, 136);
            this.btnZad2.Name = "btnZad2";
            this.btnZad2.Size = new System.Drawing.Size(950, 89);
            this.btnZad2.TabIndex = 2;
            this.btnZad2.Text = "OPTIMALNI BROJ JEDINICA PO JEDNOJ NARUDŽBI";
            this.btnZad2.UseVisualStyleBackColor = false;
            this.btnZad2.Click += new System.EventHandler(this.btnZad2_Click);
            // 
            // btnZad3
            // 
            this.btnZad3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZad3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZad3.Location = new System.Drawing.Point(21, 240);
            this.btnZad3.Name = "btnZad3";
            this.btnZad3.Size = new System.Drawing.Size(950, 89);
            this.btnZad3.TabIndex = 3;
            this.btnZad3.Text = "OPTIMALNI BROJ DANA OPSKRBLJIVANJA";
            this.btnZad3.UseVisualStyleBackColor = false;
            this.btnZad3.Click += new System.EventHandler(this.btnZad3_Click);
            // 
            // gbZadaci
            // 
            this.gbZadaci.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbZadaci.Controls.Add(this.btnZad4);
            this.gbZadaci.Controls.Add(this.btnZad1);
            this.gbZadaci.Controls.Add(this.btnZad3);
            this.gbZadaci.Controls.Add(this.btnZad2);
            this.gbZadaci.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbZadaci.Location = new System.Drawing.Point(271, 99);
            this.gbZadaci.Name = "gbZadaci";
            this.gbZadaci.Size = new System.Drawing.Size(989, 457);
            this.gbZadaci.TabIndex = 4;
            this.gbZadaci.TabStop = false;
            this.gbZadaci.Text = "Odaberite tip zadatka:";
            // 
            // btnZad4
            // 
            this.btnZad4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZad4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZad4.Location = new System.Drawing.Point(21, 349);
            this.btnZad4.Name = "btnZad4";
            this.btnZad4.Size = new System.Drawing.Size(950, 89);
            this.btnZad4.TabIndex = 4;
            this.btnZad4.Text = "METODA USPOREDBE UKUPNIH TROŠKOVA PONUDA";
            this.btnZad4.UseVisualStyleBackColor = false;
            this.btnZad4.Click += new System.EventHandler(this.btnZad4_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNazad.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazad.Location = new System.Drawing.Point(649, 604);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(229, 89);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // FormModeliZaliha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1999, 803);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.gbZadaci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModeliZaliha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modeli zaliha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormModeliZaliha_Load);
            this.gbZadaci.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnZad1;
        private System.Windows.Forms.Button btnZad2;
        private System.Windows.Forms.Button btnZad3;
        private System.Windows.Forms.GroupBox gbZadaci;
        private System.Windows.Forms.Button btnZad4;
        private System.Windows.Forms.Button btnNazad;
    }
}