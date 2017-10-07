using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_4_JonesCrossley
{
    public partial class ViewAllQuotes : Form
    {
        MainMenu frmMainMenu;

        public ViewAllQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            frmMainMenu = mainMenu;
            DisplayFileContents();
        }

        private void DisplayFileContents()
        {
            // Read file, display on form.

            // Read the JSON file.
            JsonSerializer ser = new JsonSerializer();
            string JSONstring = File.ReadAllText(Program.QUOTES_FILE_NAME);
            
            // For now, just display the raw JSON text.
            TbFileContents.Text += JSONstring;
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.Show();
        }
    }
}
