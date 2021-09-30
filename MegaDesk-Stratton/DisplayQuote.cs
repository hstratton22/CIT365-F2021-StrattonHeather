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
{/// <summary>
/// DisplayQuote form including constructor and methods to display _deskQuote to user
/// </summary>
    public partial class DisplayQuote : Form

    {
        private DeskQuote _deskQuote;
        /// <summary>
        /// receives Deskquote from AddQuote
        /// </summary>
        /// <param name="dq"></param>

        public DisplayQuote(DeskQuote dq)
        {
            _deskQuote = dq;

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
        /// <summary>
        /// closes the quote form box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayQuoteMenuBtn_Click(object sender, EventArgs e)
        {
            //why not working?
            //System.InvalidCastException: 'Unable to cast object of type 'MegaDesk_Stratton.AddQuote' to type 
            //MainMenu viewMainMenu = (MainMenu)Tag;
            //viewMainMenu.Tag = this;
            //viewMainMenu.Show();
            this.Close();
            Application.Exit();
        }/// <summary>
        /// replaces with DisplayQuote_Load
        /// </summary>
        private void setValues()
        {

        }/// <summary>
        /// loads all the data from _deskQuote and assigns to labels for user view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            displayCustNameBox.Text =  _deskQuote.GetCustName();
            displayQuoteDrawerCntBox.Text = _deskQuote.GetDesk().GetDrawerCount().ToString();
            displayQuoteRushBox.Text = _deskQuote.GetRush().ToString();
            displayQuoteRushCostBox.Text = _deskQuote.CalcRushCost().ToString();
            displayQuoteRushBox.Text = _deskQuote.GetRush().ToString();
            displayQuoteWidthBox.Text = _deskQuote.GetDesk().GetWidth().ToString();
            displayQuoteDepthBox.Text = _deskQuote.GetDesk().GetDepth().ToString();
            displayQuoteAreaBox.Text = _deskQuote.GetDesk().GetArea().ToString();
            displayQuoteAreaCostBox.Text = _deskQuote.AreaTotalCost().ToString();
            displayQuoteDateBox.Text = _deskQuote.GetDate().ToString();
            displayQuoteDrawerCostBox.Text = _deskQuote.CalcDrawerCost().ToString();
            displayQuoteMatBox.Text = _deskQuote.GetDesk().GetDesktopMaterial().ToString();
            displayQuoteMatCostBox.Text = _deskQuote.CalcSurfaceCost().ToString();
            displayQuoteTotalCostBox.Text = _deskQuote.GetQuote().ToString();

        }

        /*private void displayQuoteWidthBox_Click(object sender, EventArgs e)
        {
            displayQuoteWidthBox.Text = _deskQuote.GetCustName();
        }*/
    }
}
