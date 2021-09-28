
namespace MegaDesk_Stratton
{
    partial class ViewAllQuotes
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
            this.allQuotesClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allQuotesClose
            // 
            this.allQuotesClose.Location = new System.Drawing.Point(713, 415);
            this.allQuotesClose.Name = "allQuotesClose";
            this.allQuotesClose.Size = new System.Drawing.Size(75, 23);
            this.allQuotesClose.TabIndex = 0;
            this.allQuotesClose.Text = "Close";
            this.allQuotesClose.UseVisualStyleBackColor = true;
            this.allQuotesClose.Click += new System.EventHandler(this.allQuotesClose_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allQuotesClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allQuotesClose;
    }
}