using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_3_DustinCrossley
{
    public partial class ViewAllQuotes : Form
    {
        MainMenu frmMainMenu;
        const string FILE_NAME = "quotes.txt";

        public ViewAllQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            frmMainMenu = mainMenu;
            DisplayFileContents();
        }

        private void DisplayFileContents()
        {
            // Read file, display on form.
            StreamReader reader = new StreamReader(FILE_NAME);

            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();

                // Don't include empty lines
                if (line.Length == 0)
                    continue;

                // Write the line out to a text box
                TbFileContents.Text += line + Environment.NewLine;
            }

            // Clean up.
            reader.Close();
            reader.Dispose();
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
