
namespace MegaDesk_Stratton
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.deskImageMenu = new System.Windows.Forms.PictureBox();
            this.addNewQuotesBtn = new System.Windows.Forms.Button();
            this.viewQuotesBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskImageMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // deskImageMenu
            // 
            this.deskImageMenu.BackColor = System.Drawing.SystemColors.Control;
            this.deskImageMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deskImageMenu.Image = ((System.Drawing.Image)(resources.GetObject("deskImageMenu.Image")));
            this.deskImageMenu.Location = new System.Drawing.Point(287, 79);
            this.deskImageMenu.Name = "deskImageMenu";
            this.deskImageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.deskImageMenu.Size = new System.Drawing.Size(172, 186);
            this.deskImageMenu.TabIndex = 4;
            this.deskImageMenu.TabStop = false;
            // 
            // addNewQuotesBtn
            // 
            this.addNewQuotesBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addNewQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuotesBtn.Location = new System.Drawing.Point(43, 43);
            this.addNewQuotesBtn.Name = "addNewQuotesBtn";
            this.addNewQuotesBtn.Size = new System.Drawing.Size(200, 50);
            this.addNewQuotesBtn.TabIndex = 5;
            this.addNewQuotesBtn.Text = "&Add New Quote";
            this.addNewQuotesBtn.UseVisualStyleBackColor = false;
            this.addNewQuotesBtn.Click += new System.EventHandler(this.addNewQuotesBtn_Click);
            // 
            // viewQuotesBtn
            // 
            this.viewQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotesBtn.Location = new System.Drawing.Point(43, 113);
            this.viewQuotesBtn.Name = "viewQuotesBtn";
            this.viewQuotesBtn.Size = new System.Drawing.Size(200, 50);
            this.viewQuotesBtn.TabIndex = 6;
            this.viewQuotesBtn.Text = "&View Quotes";
            this.viewQuotesBtn.UseVisualStyleBackColor = true;
            this.viewQuotesBtn.Click += new System.EventHandler(this.viewQuotesBtn_Click);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesBtn.Location = new System.Drawing.Point(43, 185);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(200, 50);
            this.searchQuotesBtn.TabIndex = 7;
            this.searchQuotesBtn.Text = "&Search Quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.searchQuotesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(43, 260);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 50);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MegaDesk_Stratton.Properties.Resources.woodgrain_texture_background;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.viewQuotesBtn);
            this.Controls.Add(this.addNewQuotesBtn);
            this.Controls.Add(this.deskImageMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskImageMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox deskImageMenu;
        private System.Windows.Forms.Button addNewQuotesBtn;
        private System.Windows.Forms.Button viewQuotesBtn;
        private System.Windows.Forms.Button searchQuotesBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

