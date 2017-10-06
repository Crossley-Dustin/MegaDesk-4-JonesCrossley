using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_3_DustinCrossley
{
    public partial class AddQuote : Form
    {
        Form frmMainMenu;
        //Desk DeskDetails = new Desk();
        DeskQuote DQuote = new DeskQuote();
        private const string FILE_NAME = "quotes.txt";


        public AddQuote(Form MainMenuForm)
        {
            InitializeComponent();
            frmMainMenu = MainMenuForm;
            LoadDrawersDDL();
            LoadRushDDL();
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
            comboSurfaceConverted = Enum.TryParse(selectedComboSurface, out Desk.SurfaceType selectedSurface);
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



        //private void LoadSurfaceDDL()
        //{
        //    // Use list of values from Desk enumeration
        //    //Desk.SurfaceType.Laminate

        //    foreach (Desk.SurfaceType material in Enum.GetValues(typeof(Desk.SurfaceType)))
        //    {
        //        cmb
        //        material
        //    }
        //}

        private bool SaveToQuoteFile()
        {
            // Save current quote details to a file

            try
            {
                // Field order:
                // CustomerName, QuoteDate, QuoteAmount, RushOrderDays, DeskWidth, DeskDepth, DeskDrawerCount, DeskSurfaceMaterial

                const string FieldDelimiter = ",";
                StreamWriter writer;
                writer = new StreamWriter(FILE_NAME, append:true);
                writer.WriteLine
                (
                    DQuote.CustomerName
                    + FieldDelimiter + DQuote.QuoteDate
                    + FieldDelimiter + DQuote.QuoteAmount
                    + FieldDelimiter + (int)DQuote.RushOrderDays
                    + FieldDelimiter + DQuote.Desk.Width
                    + FieldDelimiter + DQuote.Desk.Depth
                    + FieldDelimiter + DQuote.Desk.DrawerCount
                    + FieldDelimiter + DQuote.Desk.Surface.ToString()
               );

                // Clean up.
                writer.Close();
                writer.Dispose();
            }
            catch (Exception)
            {
                return false;
            }
            return true;



        }
    }
}
