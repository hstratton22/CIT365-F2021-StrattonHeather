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
    public partial class DisplayQuote : Form

    {
        private DeskQuote _deskQuote;


        public DisplayQuote(DeskQuote dq)
        {
            _deskQuote = dq;
            displayCustNameBox.Text = this._deskQuote.GetCustName();
            displayQuoteDrawerCostBox.Text = _deskQuote.CalcDrawerCost().ToString();
            displayQuoteRushCostBox.Text = _deskQuote.CalcRushCost().ToString();
            displayQuoteRushBox.Text = _deskQuote.GetRush().ToString();
            displayQuoteWidthBox.Text = _deskQuote.GetDesk().GetWidth().ToString();
            displayQuoteDepthBox.Text = _deskQuote.GetDesk().GetDepth().ToString();
            displayQuoteAreaBox.Text = _deskQuote.GetDesk().GetArea().ToString();
            displayQuoteAreaCostBox.Text = _deskQuote.AreaTotalCost().ToString();
            displayQuoteDateBox.Text = _deskQuote.GetDate().ToString();
            displayQuoteDrawerCostBox.Text = _deskQuote.CalcDrawerCost().ToString();


            //setValues();
            InitializeComponent();
        }

        private void displayClose_Click(object sender, EventArgs e)
        {
           //why not working?
            // MainMenu viewMainMenu = (MainMenu)Tag;
           // viewMainMenu.Tag = this;
           // viewMainMenu.Show();
           // this.Close();
        }

        private void displayQuoteMenuBtn_Click(object sender, EventArgs e)
        {
            //why not working?
           // MainMenu viewMainMenu = (MainMenu)Tag;
            //viewMainMenu.Tag = this;
           // viewMainMenu.Show();
            //this.Close();
        }
        private void setValues()
        {

        }

        /*private void displayQuoteWidthBox_Click(object sender, EventArgs e)
        {
            displayQuoteWidthBox.Text = _deskQuote.GetCustName();
        }*/
    }
}
