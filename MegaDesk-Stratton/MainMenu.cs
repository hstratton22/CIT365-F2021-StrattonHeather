using System;/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace MegaDesk_Stratton
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void addNewQuotesBtn_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            this.Hide();
        }

        private void viewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewAllQuotes = new ViewAllQuotes();
            viewViewAllQuotes.Tag = this;
            viewViewAllQuotes.Show(this);
            this.Hide();
        }

        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();//this.Close();
        }
    }
}
