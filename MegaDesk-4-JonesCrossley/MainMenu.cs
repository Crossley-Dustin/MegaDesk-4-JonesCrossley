using System;
using System.Windows.Forms;

namespace MegaDesk_3_DustinCrossley
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote NewQuote = new AddQuote(this);
            NewQuote.Show();
            this.Hide();
        }

        private void BtnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchAllQuotes SearchQuote = new SearchAllQuotes(this);
            SearchQuote.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewAll = new ViewAllQuotes(this);
            ViewAll.Show();
            this.Hide();
        }
    }
}
