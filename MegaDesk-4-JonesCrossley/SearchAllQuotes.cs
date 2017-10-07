using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_4_JonesCrossley
{
    public partial class SearchAllQuotes : Form
    {
        MainMenu frmMainMenu;
        List<DeskQuote> lstDeskQuotes;

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
            List<DeskQuote> list;

            // Read file, create list of quotes
            JsonSerializer ser = new JsonSerializer();
            string JSONstring = File.ReadAllText(Program.QUOTES_FILE_NAME);
            list = JsonConvert.DeserializeObject<List<DeskQuote>>(JSONstring);

            // Make sure our list is empty rather than null if there are no entries in the file.
            if (list == null)
            {
                list = new List<DeskQuote>();
            }
        
            return list;
        }

        private void CmbSurfaceSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desk.DesktopMaterial SurfaceText;
            if (Enum.TryParse(CmbSurfaceSelect.SelectedItem.ToString(), out Desk.DesktopMaterial selectedSurface))
                SurfaceText = selectedSurface;
            else
                return;

            // Generate a filtered list of quotes based on the selected combobox item.
            List<DeskQuote> filteredList = new List<DeskQuote>();

            foreach(DeskQuote quote in lstDeskQuotes)
            {
                if (quote.Desk.Surface == SurfaceText)
                {
                    filteredList.Add(quote);
                }
            }

            // Load Listview based on filtered list (show the user what we found).
            LoadList(filteredList);

            // Enable view button
            BtnViewQuote.Enabled = (lbQuotes.Items.Count > 0);
        }

        private void LoadList(List<DeskQuote> quotes)
        {
            // Set List datasource.
            lbQuotes.DataSource = quotes;
            lbQuotes.DisplayMember = "CustomerName";
            lbQuotes.ValueMember = "QuoteDate";
                       
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
