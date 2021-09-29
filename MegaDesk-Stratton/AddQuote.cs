using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratton
{
    public partial class AddQuote : Form
    {
        private readonly DeskQuote _newQuote = new DeskQuote();
        //DeskQuote newQuote = new DeskQuote();
        private readonly Desk _newDesk = new Desk();
        //private System.Windows.Forms.ErrorProvider widthErrorProvider;

       


        public AddQuote()
        {
            
            InitializeComponent();
        }
        public void createDeskQuote()
        {
            //DeskQuote newQuote = new DeskQuote();
            //Desk newDesk = new Desk();

            //date
            _newQuote.SetDate(DateTime.Now);
            dateLbl.Text = DateTime.Now.ToString("dd MMMM yyyy");// dd MM//newQuote.GetDate().ToString() ;//

            _newQuote.SetCustName(custNameInput.Text);
            _newDesk.SetWidth(int.Parse(deskWidthInput.Text));
            _newDesk.SetDepth(int.Parse(deskDepthInput.Text));
            _newDesk.SetDrawerCount(Convert.ToInt32(drawersUpDown.Value));

            //newDesk.SetDesktopMaterial()//TryParse("desktopMatComboBox.Text", out DesktopMaterial );
           // if (rushComboBox.Text != null) {
            //    try { _newQuote.SetRush(Convert.ToInt32(rushComboBox.Text)); }
           //     catch (InvalidCastException ie) { }
            //    }
            
            // MessageBox.Show(newQuote.ToString());

           // widthErrorProvider = new System.Windows.Forms.ErrorProvider();
            //widthErrorProvider.SetIconAlignment(this.deskWidthInput, ErrorIconAlignment.MiddleRight);
           // widthErrorProvider.SetIconPadding(this.deskWidthInput, 2);
            //widthErrorProvider.BlinkRate = 1000;
            //widthErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;



        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();

        }

        private void submitQuoteBtn_Click(object sender, EventArgs e)
        {
            createDeskQuote();
            var myQuote = new DeskQuote(_newDesk, _newQuote);
            DisplayQuote viewDisplayQuote = new DisplayQuote(myQuote);
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();

            //how to send newQuote object to DisplayQuote??
            
           // this.Close();

        }

        private void deskWidthInput_Validating(object sender, CancelEventArgs e)
        { //if (!(Control.ModifierKeys == Keys.Shift) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)){
          //}
            /*string errorMsg = "";
            if(deskWidthInput != null) { 

            if (!ValidWidth(deskWidthInput.Text, out errorMsg))
            {
                e.Cancel = true;
                deskWidthInput.Select(0, deskWidthInput.Text.Length);
                this.widthErrorProvider.SetError(deskWidthInput, errorMsg);
            }
            else
            {
                widthErrorProvider.SetError(this.deskWidthInput, String.Empty);
            }
            }*/
        }
        public bool ValidWidth(string widthInput, out string errorMessage)
        {
            // if (widthInput > newDesk.M)
            if (_newDesk.ValidatedWidth(int.Parse(widthInput)))
            {
                errorMessage = "";
                return true;

            }
            else { errorMessage = $"Width must be greater than {_newDesk.GetMINWIDTH()} and less than {_newDesk.GetMAXWIDTH()}"; } ;
            return false;
    }
    }
    
}
