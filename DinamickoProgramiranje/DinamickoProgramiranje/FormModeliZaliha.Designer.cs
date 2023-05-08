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
            this.gbPojmovnik = new System.Windows.Forms.GroupBox();
            this.rtbPojmovnik = new System.Windows.Forms.RichTextBox();
            this.btnZad1 = new System.Windows.Forms.Button();
            this.btnZad2 = new System.Windows.Forms.Button();
            this.btnZad3 = new System.Windows.Forms.Button();
            this.gbZadaci = new System.Windows.Forms.GroupBox();
            this.btnZad4 = new System.Windows.Forms.Button();
            this.gbPojmovnik.SuspendLayout();
            this.gbZadaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPojmovnik
            // 
            this.gbPojmovnik.Controls.Add(this.rtbPojmovnik);
            this.gbPojmovnik.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPojmovnik.Location = new System.Drawing.Point(41, 442);
            this.gbPojmovnik.Name = "gbPojmovnik";
            this.gbPojmovnik.Size = new System.Drawing.Size(592, 125);
            this.gbPojmovnik.TabIndex = 0;
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
            this.rtbPojmovnik.Size = new System.Drawing.Size(573, 84);
            this.rtbPojmovnik.TabIndex = 1;
            this.rtbPojmovnik.Text = resources.GetString("rtbPojmovnik.Text");
            // 
            // btnZad1
            // 
            this.btnZad1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZad1.Location = new System.Drawing.Point(20, 42);
            this.btnZad1.Name = "btnZad1";
            this.btnZad1.Size = new System.Drawing.Size(500, 59);
            this.btnZad1.TabIndex = 1;
            this.btnZad1.Text = "OPTIMALNI GODIŠNJI BROJ NARUDŽBI";
            this.btnZad1.UseVisualStyleBackColor = true;
            this.btnZad1.Click += new System.EventHandler(this.btnZad1_Click);
            // 
            // btnZad2
            // 
            this.btnZad2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZad2.Location = new System.Drawing.Point(20, 119);
            this.btnZad2.Name = "btnZad2";
            this.btnZad2.Size = new System.Drawing.Size(500, 59);
            this.btnZad2.TabIndex = 2;
            this.btnZad2.Text = "OPTIMALNI BROJ JEDINICA PO JEDNOJ NARUDŽBI";
            this.btnZad2.UseVisualStyleBackColor = true;
            this.btnZad2.Click += new System.EventHandler(this.btnZad2_Click);
            // 
            // btnZad3
            // 
            this.btnZad3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZad3.Location = new System.Drawing.Point(20, 198);
            this.btnZad3.Name = "btnZad3";
            this.btnZad3.Size = new System.Drawing.Size(500, 59);
            this.btnZad3.TabIndex = 3;
            this.btnZad3.Text = "OPTIMALNI BROJ DANA OPSKRBLJIVANJA";
            this.btnZad3.UseVisualStyleBackColor = true;
            this.btnZad3.Click += new System.EventHandler(this.btnZad3_Click);
            // 
            // gbZadaci
            // 
            this.gbZadaci.Controls.Add(this.btnZad4);
            this.gbZadaci.Controls.Add(this.btnZad1);
            this.gbZadaci.Controls.Add(this.btnZad3);
            this.gbZadaci.Controls.Add(this.btnZad2);
            this.gbZadaci.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbZadaci.Location = new System.Drawing.Point(32, 25);
            this.gbZadaci.Name = "gbZadaci";
            this.gbZadaci.Size = new System.Drawing.Size(555, 355);
            this.gbZadaci.TabIndex = 4;
            this.gbZadaci.TabStop = false;
            this.gbZadaci.Text = "Odaberite tip zadatka:";
            // 
            // btnZad4
            // 
            this.btnZad4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZad4.Location = new System.Drawing.Point(20, 278);
            this.btnZad4.Name = "btnZad4";
            this.btnZad4.Size = new System.Drawing.Size(500, 59);
            this.btnZad4.TabIndex = 4;
            this.btnZad4.Text = "METODA USPOREDBE UKUPNIH TROŠKOVA PONUDA";
            this.btnZad4.UseVisualStyleBackColor = true;
            this.btnZad4.Click += new System.EventHandler(this.btnZad4_Click);
            // 
            // FormModeliZaliha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 615);
            this.Controls.Add(this.gbZadaci);
            this.Controls.Add(this.gbPojmovnik);
            this.Name = "FormModeliZaliha";
            this.Text = "Modeli zaliha";
            this.gbPojmovnik.ResumeLayout(false);
            this.gbZadaci.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPojmovnik;
        private System.Windows.Forms.RichTextBox rtbPojmovnik;
        private System.Windows.Forms.Button btnZad1;
        private System.Windows.Forms.Button btnZad2;
        private System.Windows.Forms.Button btnZad3;
        private System.Windows.Forms.GroupBox gbZadaci;
        private System.Windows.Forms.Button btnZad4;
    }
}