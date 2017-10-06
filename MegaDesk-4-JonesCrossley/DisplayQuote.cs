using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_DustinCrossley
{
    public partial class DisplayQuote : Form
    {
        DeskQuote Quote;
        SearchAllQuotes frmSearchQuotes;

        public DisplayQuote(DeskQuote Desk_Quote, SearchAllQuotes SearchQuotes)
        {
            InitializeComponent();
            Quote = Desk_Quote;
            frmSearchQuotes = SearchQuotes;
            DisplayCurrentQuote();
        }

        private void DisplayCurrentQuote()
        {
            tbCustomerName.Text = Quote.CustomerName;
            TbQuoteDate.Text = Quote.QuoteDate.ToString();
            TbQuoteAmount.Text = Quote.QuoteAmount.ToString("C");
            TbRushDays.Text = Convert.ToString((int)Quote.RushOrderDays);
            TbDrawerCount.Text = Quote.Desk.DrawerCount.ToString();
            TbDeskWidth.Text = Quote.Desk.Width.ToString();
            TbDeskDepth.Text = Quote.Desk.Depth.ToString();
            TbSurfaceMaterial.Text = Quote.Desk.Surface.ToString();

        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSearchQuotes.Show();
        }

        private void BtnReturnToSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
