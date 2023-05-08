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
            this.rb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Location = new System.Drawing.Point(283, 116);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(40, 20);
            this.rb.TabIndex = 0;
            this.rb.TabStop = true;
            this.rb.Text = "rb";
            this.rb.UseVisualStyleBackColor = true;
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb);
            this.Name = "FormPocetna";
            this.Text = "Početna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb;
    }
}

