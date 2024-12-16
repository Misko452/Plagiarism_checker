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
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInputPattern
            // 
            this.textBoxInputPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInputPattern.Location = new System.Drawing.Point(32, 24);
            this.textBoxInputPattern.Name = "textBoxInputPattern";
            this.textBoxInputPattern.Size = new System.Drawing.Size(1193, 53);
            this.textBoxInputPattern.TabIndex = 0;
            this.textBoxInputPattern.TextChanged += new System.EventHandler(this.textBoxInputPattern_TextChanged);
            // 
            // richTextBoxOriginalText
            // 
            this.richTextBoxOriginalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxOriginalText.Location = new System.Drawing.Point(32, 116);
            this.richTextBoxOriginalText.Name = "richTextBoxOriginalText";
            this.richTextBoxOriginalText.Size = new System.Drawing.Size(1193, 642);
            this.richTextBoxOriginalText.TabIndex = 1;
            this.richTextBoxOriginalText.Text = "";
            // 
            // textBoxPercentage
            // 
            this.textBoxPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPercentage.Location = new System.Drawing.Point(32, 781);
            this.textBoxPercentage.Name = "textBoxPercentage";
            this.textBoxPercentage.ReadOnly = true;
            this.textBoxPercentage.Size = new System.Drawing.Size(645, 53);
            this.textBoxPercentage.TabIndex = 2;
            this.textBoxPercentage.Text = "Match percentage %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 858);
            this.Controls.Add(this.textBoxPercentage);
            this.Controls.Add(this.richTextBoxOriginalText);
            this.Controls.Add(this.textBoxInputPattern);
            this.Name = "Form1";
            this.Text = "Plagiate finder | Text search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputPattern;
        private System.Windows.Forms.RichTextBox richTextBoxOriginalText;
        private System.Windows.Forms.TextBox textBoxPercentage;
    }
}

