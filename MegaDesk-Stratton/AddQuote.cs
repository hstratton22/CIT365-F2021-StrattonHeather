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
        //DeskQuote newQuote = new DeskQuote();
        //Desk newDesk = new Desk();


        public AddQuote()
        {
            InitializeComponent();
        }
        public void createDeskQuote()
        {
            DeskQuote newQuote = new DeskQuote();
            Desk newDesk = new Desk();

            //date
            newQuote.SetDate(DateTime.Now);
            dateLbl.Text = DateTime.Now.ToString("dd MMMM yyyy");// dd MM//newQuote.GetDate().ToString() ;//

            newQuote.SetCustName(custNameInput.Text);
            newDesk.SetWidth(int.Parse(deskWidthInput.Text));
            newDesk.SetDepth(int.Parse(deskDepthInput.Text));
            newDesk.SetDrawerCount(Convert.ToInt32(drawersUpDown.Value));

            //newDesk.SetDesktopMaterial()//TryParse("desktopMatComboBox.Text", out DesktopMaterial );
            newQuote.SetRush(Convert.ToInt32(rushComboBox.Text));
            MessageBox.Show(newQuote.ToString());
            

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
            //send to DisplayQuote??
            DisplayQuote viewDisplayQuote = (DisplayQuote)Tag;
            viewDisplayQuote.Show();
            this.Close();

        }
    }
}
