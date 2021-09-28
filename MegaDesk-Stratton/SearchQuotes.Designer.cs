
namespace MegaDesk_Stratton
{
    partial class SearchQuotes
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
            this.searchQuotesClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchQuotesClose
            // 
            this.searchQuotesClose.Location = new System.Drawing.Point(713, 415);
            this.searchQuotesClose.Name = "searchQuotesClose";
            this.searchQuotesClose.Size = new System.Drawing.Size(75, 23);
            this.searchQuotesClose.TabIndex = 0;
            this.searchQuotesClose.Text = "Close";
            this.searchQuotesClose.UseVisualStyleBackColor = true;
            this.searchQuotesClose.Click += new System.EventHandler(this.searchQuotesClose_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchQuotesClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchQuotesClose;
    }
}