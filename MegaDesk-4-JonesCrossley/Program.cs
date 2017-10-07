using System;
using System.Windows.Forms;

namespace MegaDesk_4_JonesCrossley
{
    static class Program
    {
        public const string QUOTES_FILE_NAME = @"Assets\quotes.json";
        public const string RUSH_ORDER_PRICE_FILE = @"Assets\rushOrderPrices.txt";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
