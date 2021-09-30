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
        //private readonly DeskQuote _newQuote = new DeskQuote();
        //DeskQuote newQuote = new DeskQuote();
        //private readonly Desk _newDesk = new Desk();
        //private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private DeskQuote _newQuote;
        private Desk _newDesk;





        public AddQuote(Desk d, DeskQuote q)
        {
            _newDesk = d;
            _newQuote = q;
            //desktopMatComboBox.Items.AddRange(Enum.GetNames(typeof(DesktopMaterial)));
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
            _newDesk.SetArea(_newDesk.GetWidth(), _newDesk.GetDepth());
            _newDesk.SetDrawerCount(drawersUpDown.Value);//(Convert.ToInt32(
                                                         //var drawerCounting = (Convert.ToInt32(drawersUpDown.Value));

            var surfaceMat = desktopMatComboBox.Text;
            //MessageBox.Show(surfaceMat);
            var rushTime = rushComboBox.Text;
           

            _newQuote.SetDesk(_newDesk);
            _newQuote.setQuote();

                     
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
            //var myQuote = new DeskQuote(_newDesk, _newQuote);
            //MessageBox.Show(myQuote.ToString());
            var viewDisplayQuote = new DisplayQuote(_newQuote);
           // DisplayQuote viewDisplayQuote = new DisplayQuote(myQuote);
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
                
                for (int ch = 0; ch < deskWidthInput.Text.Length; ch++)
                {
                    if (!Char.IsDigit(deskWidthInput.Text[ch]) && (!Char.IsControl(deskWidthInput.Text[ch])))
                    {
                        //MessageBox.Show("not digit!");
                        //can still submit although not valid....
                        e.Cancel= true;
                        deskWidthInput.Select(0, deskWidthInput.Text.Length);
                        deskWidthInput.Focus();

                        errorProvider2.SetError(deskWidthInput, "Enter valid number");
                    }
                    else
                    {
                        errorProvider2.SetError(deskWidthInput, "");//Please enter a number
                        if (!ValidWidth(deskWidthInput.Text))
                        {

                            errorProvider2.SetError(deskWidthInput, $"Width must be greater than or equal to {_newDesk.GetMINWIDTH()} and less than or equal to {_newDesk.GetMAXWIDTH()}");
                        }
                        else
                        {
                            errorProvider2.SetError(deskWidthInput, String.Empty);//"Valid");//);//this.
                        }

                        
                    }
                }
                }
            else
            {
                errorProvider2.SetError(deskWidthInput, "Enter valid number");
            }
          
}
        public bool ValidWidth(string widthInput)
        {
            
                if (_newDesk.ValidatedWidth(int.Parse(widthInput)))
                { return true; }
                else
                { return false; }
            

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
                    errorProvider3.SetError(deskDepthInput, $"Depth must be greater than or equal to {_newDesk.GetMINDEPTH()} and less than or equal to {_newDesk.GetMAXDEPTH() }");
                }
                else
                {
                    errorProvider3.SetError(deskDepthInput, string.Empty);
                }
            }
            else
            {
                errorProvider3.SetError(deskDepthInput, "Enter a valid number.");
            }
        }
        public bool ValidDepth(string depthInput)
        { if (_newDesk.ValidatedDepth(int.Parse(depthInput)))
            { return true; }
            else return false;
        }
        /*
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
        */
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

        private void desktopMatComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ComboBox senderComboBox = (ComboBox)sender;
            string selectedMaterial = this.desktopMatComboBox.SelectedItem.ToString();
            selectedMaterial.Trim();
            _newDesk.SetDesktopMaterial(selectedMaterial);
            //MessageBox.Show(selectedMaterial);
        }

        private void rushComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedRush = this.rushComboBox.SelectedItem.ToString();
            selectedRush.Trim();
            try
            {
                _newQuote.SetRush(int.Parse(selectedRush));
                //MessageBox.Show(selectedRush);
            }
            catch (Exception exc) {_newQuote.SetRush(0);
                //MessageBox.Show(selectedRush.ToString());
                }
        }

        /* private void desktopMatComboBox_SelectedIndexChanged(object sender, EventArgs e)
         {//not set to instance of object?
             ComboBox cmb = (ComboBox)sender;
             int selectedIndex = cmb.SelectedIndex;
             int selectedValue = (int)cmb.SelectedValue;
             MessageBox.Show( selectedIndex + ", " + selectedValue);

         }*/
    }
    
}
