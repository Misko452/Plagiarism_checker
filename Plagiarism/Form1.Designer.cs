namespace Plagiarism
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInputPattern = new System.Windows.Forms.TextBox();
            this.richTextBoxOriginalText = new System.Windows.Forms.RichTextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputPattern
            // 
            this.textBoxInputPattern.Location = new System.Drawing.Point(32, 133);
            this.textBoxInputPattern.Name = "textBoxInputPattern";
            this.textBoxInputPattern.Size = new System.Drawing.Size(1193, 26);
            this.textBoxInputPattern.TabIndex = 0;
            // 
            // richTextBoxOriginalText
            // 
            this.richTextBoxOriginalText.Location = new System.Drawing.Point(32, 222);
            this.richTextBoxOriginalText.Name = "richTextBoxOriginalText";
            this.richTextBoxOriginalText.Size = new System.Drawing.Size(1193, 510);
            this.richTextBoxOriginalText.TabIndex = 1;
            this.richTextBoxOriginalText.Text = "";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(537, 767);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(137, 57);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 858);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.richTextBoxOriginalText);
            this.Controls.Add(this.textBoxInputPattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputPattern;
        private System.Windows.Forms.RichTextBox richTextBoxOriginalText;
        private System.Windows.Forms.Button buttonFind;
    }
}

