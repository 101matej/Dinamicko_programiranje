namespace DinamickoProgramiranje
{
    partial class FormPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPocetna));
            this.btnDinamickoProgramiranje = new System.Windows.Forms.Button();
            this.btnModelZaliha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDinamickoProgramiranje
            // 
            this.btnDinamickoProgramiranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDinamickoProgramiranje.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinamickoProgramiranje.Location = new System.Drawing.Point(127, 325);
            this.btnDinamickoProgramiranje.Name = "btnDinamickoProgramiranje";
            this.btnDinamickoProgramiranje.Size = new System.Drawing.Size(391, 59);
            this.btnDinamickoProgramiranje.TabIndex = 0;
            this.btnDinamickoProgramiranje.Text = "DINAMIČKO PROGRAMIRANJE";
            this.btnDinamickoProgramiranje.UseVisualStyleBackColor = false;
            this.btnDinamickoProgramiranje.Click += new System.EventHandler(this.btnDinamickoProgramiranje_Click);
            // 
            // btnModelZaliha
            // 
            this.btnModelZaliha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModelZaliha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelZaliha.Location = new System.Drawing.Point(127, 426);
            this.btnModelZaliha.Name = "btnModelZaliha";
            this.btnModelZaliha.Size = new System.Drawing.Size(391, 59);
            this.btnModelZaliha.TabIndex = 1;
            this.btnModelZaliha.Text = "MODELI ZALIHA";
            this.btnModelZaliha.UseVisualStyleBackColor = false;
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 533);
            this.Controls.Add(this.btnModelZaliha);
            this.Controls.Add(this.btnDinamickoProgramiranje);
            this.Name = "FormPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDinamickoProgramiranje;
        private System.Windows.Forms.Button btnModelZaliha;
    }
}

