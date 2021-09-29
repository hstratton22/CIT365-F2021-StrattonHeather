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
           

            _newQuote.SetDesk(_newDesk);

            //newDesk.SetDesktopMaterial()//TryParse("desktopMatComboBox.Text", out DesktopMaterial );
           // if (rushComboBox.Text != null) {
            //    try { _newQuote.SetRush(Convert.ToInt32(rushComboBox.Text)); }
           //     catch (InvalidCastException ie) { }
            //    }
            
            // MessageBox.Show(newQuote.ToString());

          
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

            //how to send newQuote object to DisplayQuote with info??
            
           // this.Close();

        }

        private void deskWidthInput_Validating(object sender, CancelEventArgs e)
        { 

            if (deskWidthInput.Text != null && deskWidthInput.Text != string.Empty)
            {
                             
                    if (!ValidWidth(deskWidthInput.Text))
                    {

                        errorProvider2.SetError(deskWidthInput, $"Width must be greater than {_newDesk.GetMINWIDTH()} and less than {_newDesk.GetMAXWIDTH()}");
                    }
                    else
                    {
                        errorProvider2.SetError(this.deskWidthInput, String.Empty);
                    }
                }
            
        }
        public bool ValidWidth(string widthInput)
        {
            try
            {
                var parsedWidth = int.Parse(widthInput);
                if (_newDesk.ValidatedWidth(parsedWidth))
                { return true; }
                else
                { return false; }
            }
            catch (ArgumentException ae) { return false; }

         }

        private void custNameInput_Validating(object sender, CancelEventArgs e)
        {
            if(custNameInput.Text == string.Empty)
            { errorProvider1.SetError(custNameInput, "Name is required."); }
            else
            {
                errorProvider1.SetError(custNameInput, string.Empty);
            }
        }

        private void deskDepthInput_Validating(object sender, CancelEventArgs e)
        {
            if(deskDepthInput.Text != null && deskDepthInput.Text != string.Empty)
            {
                if (!ValidDepth(deskDepthInput.Text))
                {
                    errorProvider3.SetError(deskDepthInput, $"Depth must be greater than {_newDesk.GetMINDEPTH()} and less than {_newDesk.GetMAXDEPTH() }");
                }
                else
                {
                    errorProvider3.SetError(deskDepthInput, string.Empty);
                }
            }
        }
        public bool ValidDepth(string depthInput)
        { if (_newDesk.ValidatedDepth(int.Parse(depthInput)))
            { return true; }
            else return false;
        }
        private bool notNumber = false;
        private void deskWidthInput_KeyDown(object sender, KeyEventArgs e)
        {
            notNumber = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if(e.KeyCode != Keys.Back)
                    {
                        notNumber = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                notNumber = true;
            }
        }

        private void deskWidthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notNumber) e.Handled = true;
        }
        private bool depthNotNumber = false;
        private void deskDepthInput_KeyDown(object sender, KeyEventArgs e)
        {
            depthNotNumber = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        depthNotNumber = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                depthNotNumber = true;
            }
        }

        private void deskDepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (depthNotNumber) e.Handled = true;
        }
    }
    
}
