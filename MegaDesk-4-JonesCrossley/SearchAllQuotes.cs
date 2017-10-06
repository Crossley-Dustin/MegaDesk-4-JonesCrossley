using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_3_DustinCrossley
{
    public partial class SearchAllQuotes : Form
    {
        MainMenu frmMainMenu;
        List<DeskQuote> lstDeskQuotes;
        const string FILE_NAME = "quotes.txt";

        public SearchAllQuotes(MainMenu MainMenu)
        {
            InitializeComponent();
            frmMainMenu = MainMenu;
            BtnViewQuote.Enabled = false;
        }

        private void SearchAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.Show();
        }

        private void SearchAllQuotes_Load(object sender, EventArgs e)
        {
            // Read quotes file and populate list of quotes
            lstDeskQuotes = GetQuotesFromFile();
        }

        private List<DeskQuote> GetQuotesFromFile()
        {
            List<DeskQuote> list = new List<DeskQuote>();

            // Read file, create list of quotes
            StreamReader reader = new StreamReader(FILE_NAME);

            while (reader.EndOfStream == false)
            {
                DeskQuote quote = new DeskQuote();

                string line = reader.ReadLine();
                string[] fields = line.Split(',');

                if (line.Length == 0)
                    continue;

                // Field order:
                // CustomerName, QuoteDate, QuoteAmount, RushOrderDays, DeskWidth, DeskDepth, DeskDrawerCount, DeskSurfaceMaterial

                quote.CustomerName = fields[0].ToString();
                quote.QuoteDate = DateTime.Parse(fields[1]);
                quote.QuoteAmount = decimal.Parse(fields[2]);
                quote.RushOrderDays = (DeskQuote.RushDays)Convert.ToInt32(int.Parse(fields[3]));
                quote.Desk.Width = int.Parse(fields[4]);
                quote.Desk.Depth = int.Parse(fields[5]);
                quote.Desk.DrawerCount = int.Parse(fields[6]);
                bool comboSurfaceConverted;
                comboSurfaceConverted = Enum.TryParse(fields[7], out Desk.SurfaceType selectedSurface);
                if (comboSurfaceConverted)
                    quote.Desk.Surface = selectedSurface;
                
                // Save quote to list.
                list.Add(quote);

            }
            
            // Clean up.
            reader.Close();
            reader.Dispose();

            return list;
        }

        private void CmbSurfaceSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desk.SurfaceType SurfaceText;
            if (Enum.TryParse(CmbSurfaceSelect.SelectedItem.ToString(), out Desk.SurfaceType selectedSurface))
                SurfaceText = selectedSurface;
            else
                return;

            List<DeskQuote> filteredList = new List<DeskQuote>();

            foreach(DeskQuote quote in lstDeskQuotes)
            {
                if (quote.Desk.Surface == SurfaceText)
                {
                    filteredList.Add(quote);
                }
            }

            // Load Listview based on filtered list
            LoadList(filteredList);

            // Enable view button
            BtnViewQuote.Enabled = (lbQuotes.Items.Count > 0);
        }

        private void LoadList(List<DeskQuote> quotes)
        {
            //// Set up basic details about listview.
            //lvQuotes.View = View.Details;
            //lvQuotes.GridLines = true;
            //lvQuotes.FullRowSelect = true;


            //// Add column headers.
            //lvQuotes.Columns.Add("Surface Material");
            //lvQuotes.AutoResizeColumn(0,ColumnHeaderAutoResizeStyle.HeaderSize);
            //lvQuotes.Columns.Add("Quote Date");
            //lvQuotes.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

            lbQuotes.DataSource = quotes;
            lbQuotes.DisplayMember = "CustomerName";
            lbQuotes.ValueMember = "QuoteDate";
            
            //foreach (DeskQuote quote in quotes)
            //{
            //    lbQuotes.Items.Add(quote);
            //}
                
            
            
        }

        private void BtnViewQuote_Click(object sender, EventArgs e)
        {
            // Identify the currently selected quote and send to viewer.
            DeskQuote quote;
            quote = (DeskQuote)lbQuotes.SelectedItem;

            DisplayQuote viewQuote = new DisplayQuote(quote, this);
            viewQuote.Show();
            frmMainMenu.Hide();
            this.Hide();

        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
