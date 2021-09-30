
namespace MegaDesk_Stratton
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.custNameLbl = new System.Windows.Forms.Label();
            this.custNameInput = new System.Windows.Forms.TextBox();
            this.deskWidthLbl = new System.Windows.Forms.Label();
            this.deskWidthInput = new System.Windows.Forms.TextBox();
            this.deskDepthLbl = new System.Windows.Forms.Label();
            this.deskDepthInput = new System.Windows.Forms.TextBox();
            this.drawerCntLbl = new System.Windows.Forms.Label();
            this.drawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.desktopMatLbl = new System.Windows.Forms.Label();
            this.desktopMatComboBox = new System.Windows.Forms.ComboBox();
            this.rushLbl = new System.Windows.Forms.Label();
            this.rushComboBox = new System.Windows.Forms.ComboBox();
            this.submitQuoteBtn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drawersUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // custNameLbl
            // 
            this.custNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameLbl.Location = new System.Drawing.Point(22, 24);
            this.custNameLbl.Name = "custNameLbl";
            this.custNameLbl.Size = new System.Drawing.Size(186, 20);
            this.custNameLbl.TabIndex = 0;
            this.custNameLbl.Text = "Customer Name";
            // 
            // custNameInput
            // 
            this.custNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameInput.Location = new System.Drawing.Point(209, 18);
            this.custNameInput.Name = "custNameInput";
            this.custNameInput.Size = new System.Drawing.Size(150, 26);
            this.custNameInput.TabIndex = 1;
            this.custNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.custNameInput_Validating);
            // 
            // deskWidthLbl
            // 
            this.deskWidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthLbl.Location = new System.Drawing.Point(22, 62);
            this.deskWidthLbl.Name = "deskWidthLbl";
            this.deskWidthLbl.Size = new System.Drawing.Size(186, 20);
            this.deskWidthLbl.TabIndex = 0;
            this.deskWidthLbl.Text = "Desk Width (inches)";
            // 
            // deskWidthInput
            // 
            this.deskWidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthInput.Location = new System.Drawing.Point(209, 59);
            this.deskWidthInput.Name = "deskWidthInput";
            this.deskWidthInput.Size = new System.Drawing.Size(150, 26);
            this.deskWidthInput.TabIndex = 2;
            this.deskWidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.deskWidthInput_Validating);
            // 
            // deskDepthLbl
            // 
            this.deskDepthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthLbl.Location = new System.Drawing.Point(22, 107);
            this.deskDepthLbl.Name = "deskDepthLbl";
            this.deskDepthLbl.Size = new System.Drawing.Size(186, 20);
            this.deskDepthLbl.TabIndex = 0;
            this.deskDepthLbl.Text = "Desk Depth (inches)";
            // 
            // deskDepthInput
            // 
            this.deskDepthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthInput.Location = new System.Drawing.Point(209, 101);
            this.deskDepthInput.Name = "deskDepthInput";
            this.deskDepthInput.Size = new System.Drawing.Size(150, 26);
            this.deskDepthInput.TabIndex = 3;
            this.deskDepthInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deskDepthInput_KeyDown);
            this.deskDepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deskDepthInput_KeyPress);
            this.deskDepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.deskDepthInput_Validating);
            // 
            // drawerCntLbl
            // 
            this.drawerCntLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerCntLbl.Location = new System.Drawing.Point(23, 152);
            this.drawerCntLbl.Name = "drawerCntLbl";
            this.drawerCntLbl.Size = new System.Drawing.Size(186, 20);
            this.drawerCntLbl.TabIndex = 0;
            this.drawerCntLbl.Text = "Number of Drawers";
            // 
            // drawersUpDown
            // 
            this.drawersUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersUpDown.Location = new System.Drawing.Point(209, 155);
            this.drawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersUpDown.Name = "drawersUpDown";
            this.drawersUpDown.Size = new System.Drawing.Size(150, 26);
            this.drawersUpDown.TabIndex = 4;
            // 
            // desktopMatLbl
            // 
            this.desktopMatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopMatLbl.Location = new System.Drawing.Point(24, 200);
            this.desktopMatLbl.Name = "desktopMatLbl";
            this.desktopMatLbl.Size = new System.Drawing.Size(186, 20);
            this.desktopMatLbl.TabIndex = 0;
            this.desktopMatLbl.Text = "Desktop Material";
            // 
            // desktopMatComboBox
            // 
            this.desktopMatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopMatComboBox.FormattingEnabled = true;
            this.desktopMatComboBox.ItemHeight = 20;
            this.desktopMatComboBox.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "pine",
            "rosewood",
            "veneer"});
            this.desktopMatComboBox.Location = new System.Drawing.Point(209, 198);
            this.desktopMatComboBox.Name = "desktopMatComboBox";
            this.desktopMatComboBox.Size = new System.Drawing.Size(150, 28);
            this.desktopMatComboBox.TabIndex = 5;
            this.desktopMatComboBox.Text = " ";
            this.desktopMatComboBox.SelectionChangeCommitted += new System.EventHandler(this.desktopMatComboBox_SelectionChangeCommitted);
            // 
            // rushLbl
            // 
            this.rushLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushLbl.Location = new System.Drawing.Point(24, 248);
            this.rushLbl.Name = "rushLbl";
            this.rushLbl.Size = new System.Drawing.Size(186, 20);
            this.rushLbl.TabIndex = 0;
            this.rushLbl.Text = "Rush Order Options";
            // 
            // rushComboBox
            // 
            this.rushComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushComboBox.FormattingEnabled = true;
            this.rushComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushComboBox.Location = new System.Drawing.Point(209, 247);
            this.rushComboBox.Name = "rushComboBox";
            this.rushComboBox.Size = new System.Drawing.Size(150, 28);
            this.rushComboBox.TabIndex = 6;
            this.rushComboBox.SelectionChangeCommitted += new System.EventHandler(this.rushComboBox_SelectionChangeCommitted);
            // 
            // submitQuoteBtn
            // 
            this.submitQuoteBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.submitQuoteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.submitQuoteBtn.FlatAppearance.BorderSize = 2;
            this.submitQuoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitQuoteBtn.Location = new System.Drawing.Point(209, 316);
            this.submitQuoteBtn.Name = "submitQuoteBtn";
            this.submitQuoteBtn.Padding = new System.Windows.Forms.Padding(2);
            this.submitQuoteBtn.Size = new System.Drawing.Size(150, 32);
            this.submitQuoteBtn.TabIndex = 7;
            this.submitQuoteBtn.Text = "Submit";
            this.submitQuoteBtn.UseVisualStyleBackColor = false;
            this.submitQuoteBtn.Click += new System.EventHandler(this.submitQuoteBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(25, 378);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Padding = new System.Windows.Forms.Padding(2);
            this.dateLbl.Size = new System.Drawing.Size(16, 21);
            this.dateLbl.TabIndex = 9;
            this.dateLbl.Text = " ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 413);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.submitQuoteBtn);
            this.Controls.Add(this.rushComboBox);
            this.Controls.Add(this.rushLbl);
            this.Controls.Add(this.desktopMatComboBox);
            this.Controls.Add(this.desktopMatLbl);
            this.Controls.Add(this.drawersUpDown);
            this.Controls.Add(this.drawerCntLbl);
            this.Controls.Add(this.deskDepthInput);
            this.Controls.Add(this.deskDepthLbl);
            this.Controls.Add(this.deskWidthInput);
            this.Controls.Add(this.deskWidthLbl);
            this.Controls.Add(this.custNameInput);
            this.Controls.Add(this.custNameLbl);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.drawersUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label custNameLbl;
        private System.Windows.Forms.TextBox custNameInput;
        private System.Windows.Forms.Label deskWidthLbl;
        private System.Windows.Forms.TextBox deskWidthInput;
        private System.Windows.Forms.Label deskDepthLbl;
        private System.Windows.Forms.TextBox deskDepthInput;
        private System.Windows.Forms.Label drawerCntLbl;
        private System.Windows.Forms.NumericUpDown drawersUpDown;
        private System.Windows.Forms.Label desktopMatLbl;
        private System.Windows.Forms.ComboBox desktopMatComboBox;
        private System.Windows.Forms.Label rushLbl;
        private System.Windows.Forms.ComboBox rushComboBox;
        private System.Windows.Forms.Button submitQuoteBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}