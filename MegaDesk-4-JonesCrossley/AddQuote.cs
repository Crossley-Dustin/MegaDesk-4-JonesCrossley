using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MegaDesk_4_JonesCrossley
{
    public partial class AddQuote : Form
    {
        Form frmMainMenu;
        //Desk DeskDetails = new Desk();
        DeskQuote DQuote = new DeskQuote();
 
        public AddQuote(Form MainMenuForm)
        {
            InitializeComponent();
            frmMainMenu = MainMenuForm;
            LoadDrawersDDL();
            LoadRushDDL();
            LoadSurfaceDDL();
        }

        private void BtnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu.Show();
            this.Close();
        }

        private void BtnSaveQuote_Click(object sender, EventArgs e)
        {
            // Grab all values and generate the price quote

            DQuote.Desk.Width = int.Parse(tbDeskWidth.Text);
            DQuote.Desk.Depth = int.Parse(tbDeskDepth.Text);
            DQuote.Desk.DrawerCount = Convert.ToInt32(cmbNumDrawers.SelectedItem);
            string selectedComboSurface = cmbSurfaceMaterial.SelectedItem.ToString();
            bool comboSurfaceConverted;
            comboSurfaceConverted = Enum.TryParse(selectedComboSurface, out Desk.DesktopMaterial selectedSurface);
            if (comboSurfaceConverted)
            {
                DQuote.Desk.Surface = selectedSurface;
            }
            
            DQuote.CustomerName = tbCustomerName.Text;
            DQuote.RushOrderDays = (DeskQuote.RushDays)Convert.ToInt32(cmbRushDays.SelectedItem.ToString());

            // Calculate the quote
            DQuote.CalculateDeskQuote();

            // Save details to file
            SaveToQuoteFile();

            frmMainMenu.Show();
            this.Close();
        }

        private void TbDeskWidth_Validating(object sender, CancelEventArgs e)
        {
            // Allow user to tab or otherwise move through the field without adding a value
            if (tbDeskWidth.Text.Length == 0)
                return;

            try
            {
                bool CancelProgress = false;

                // Rest error provider
                ErrProv_DeskQuote.Clear();

                // Parse to a number
                int.TryParse(tbDeskWidth.Text, out int userWidth);

                // 
                int UserNumber = int.Parse(tbDeskWidth.Text);

                // Check against min max constraints.
                if (userWidth < DeskQuote.MIN_WIDTH)
                {
                    ErrProv_DeskQuote.SetError(tbDeskWidth, "Width must be " + DeskQuote.MIN_WIDTH + " or greater.");
                    CancelProgress = true;
                }

                if (userWidth > DeskQuote.MAX_WIDTH)
                {
                    ErrProv_DeskQuote.SetError(tbDeskWidth, "Width must be " + DeskQuote.MAX_WIDTH + " or less.");
                    CancelProgress = true;
                }

                if (CancelProgress)
                {
                    e.Cancel = true;
                    tbDeskWidth.Select(0, tbDeskWidth.Text.Length);
                }
            }
            catch (Exception exception)
            {
                ErrProv_DeskQuote.SetError(tbDeskWidth, exception.Message);
                tbDeskWidth.Select(0, tbDeskWidth.Text.Length);
                e.Cancel = true;
            }

        }

        private void TbDeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bool CancelProgress = false;
            string FullString = string.Empty;
            //int FullNumber = 0;


            // Check for control characters, hanlde if true.
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Validate for non digit (0-9) key value.
                if (!Char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;
                return;
            }

            //// See what the resulting value would be with already existing char plus this incoming char.
            //char[] tbChars = tbDeskDepth.Text.ToCharArray();
            //// Put the number together
            //if (tbChars.Length > 0)
            //{
            //    FullString = string.Concat(tbChars);
            //    FullString = string.Concat(FullString, e.KeyChar);
            //}
            //else
            //    // We only have the current character, so run with it.
            //    FullString = string.Concat(e.KeyChar);

            //// Convert the full string to an int
            //int.TryParse(FullString, out FullNumber);


        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.Show();
        }

        private void TbDeskDepth_Validating(object sender, CancelEventArgs e)
        {
            // Allow user to tab or otherwise move through the field without adding a value
            if (tbDeskDepth.Text.Length == 0)
                return;

            // Rest error provider.
            ErrProv_DeskQuote.Clear();

            bool CancelProgress = false;
            bool isNum = int.TryParse(tbDeskDepth.Text, out int UserNumber);

            if (!isNum)
            {
                ErrProv_DeskQuote.SetError(tbDeskDepth, "Please enter a valid number.");
                CancelProgress = true;
            }

            // If we have a valid number, then check total value of the text field against min max constraints.
            if (isNum)
            {
                if (UserNumber < DeskQuote.MIN_DEPTH)
                {
                    ErrProv_DeskQuote.SetError(tbDeskDepth, "Depth must be " + DeskQuote.MIN_DEPTH + " or greater.");
                    CancelProgress = true;
                }
                if (UserNumber > DeskQuote.MAX_DEPTH)
                {
                    ErrProv_DeskQuote.SetError(tbDeskDepth, "Depth must be " + DeskQuote.MAX_DEPTH + " or less.");
                    CancelProgress = true;
                }
            }

            // Carry out cancel process so user doesn't move to the next field.
            if (CancelProgress)
            {
                e.Cancel = true;
                tbDeskDepth.Select(0, tbDeskDepth.Text.Length);
            }
        }

        private void LoadDrawersDDL()
        {
            //// Use range defined in the Desk class          
            //for(int i = DeskQuote.MIN_DRAWERS; i <= DeskQuote.MAX_DRAWERS; i++)
            //{
            //    cmbNumDrawers.Items.Add(new KeyValuePair<string,string>(i.ToString(), i.ToString()));
            //}
            //// Set which piece of data is displayed and which is the value when selected
            //cmbNumDrawers.DisplayMember = "Value";
            //cmbNumDrawers.ValueMember = "Key";
            //// Set the default value
            //cmbNumDrawers.SelectedIndex = 0;
        }

        private void LoadRushDDL()
        {
            ////DeskQuote.RushDays.Three

            ////foreach (DeskQuote.RushDays NumDays in Enum.GetValues(typeof(DeskQuote.RushDays)))
            ////{
            ////    Console.WriteLine(NumDays);
            ////}

            ////foreach (DeskQuote.RushDays ValueDays in Enum.GetValues(typeof(DeskQuote.RushDays)))
            ////{
            ////    Console.WriteLine(ValueDays);
            ////}

            //cmbRushDays.Items.Add(new KeyValuePair<int, string>(0, "0"));
            //cmbRushDays.Items.Add(new KeyValuePair<int, string>(3, "3"));
            //cmbRushDays.Items.Add(new KeyValuePair<int, string>(5, "5"));
            //cmbRushDays.Items.Add(new KeyValuePair<int, string>(7, "7"));
            //cmbRushDays.DisplayMember = "Value";
            //cmbRushDays.ValueMember = "Key";
            //// Set the default value
            //cmbRushDays.SelectedIndex = 0;
        }

        private void LoadSurfaceDDL()
        {
            // Use list of values from Desk enumeration
            List<Desk.DesktopMaterial> materials = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            cmbSurfaceMaterial.DataSource = materials;
        }

        private bool SaveToQuoteFile()
        {
            // Save current quote details to a file

            try
            {
                List<DeskQuote> list;

                // Read the current JSON file and convert it to a list of quotes.
                string JsonString = File.ReadAllText(Program.QUOTES_FILE_NAME);
                list = JsonConvert.DeserializeObject<List<DeskQuote>>(JsonString);
                
                // If there are no quotes in the file, set the list to empty rather than null (we need a reference to the list).
                if(list == null)
                {
                    list = new List<DeskQuote>();
                }

                // Add the current quote to the list
                list.Add(DQuote);
                // Serialize the entire list to a string. Format it so it looks purty.
                string outputJSON = JsonConvert.SerializeObject(list, Formatting.Indented);
                // Write all the text back out to the JSON file. We are not appending. We are overwriting the entire file.
                File.WriteAllText(Program.QUOTES_FILE_NAME, outputJSON);
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;



        }
    }
}
