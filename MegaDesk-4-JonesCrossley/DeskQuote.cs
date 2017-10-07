using System;

namespace MegaDesk_4_JonesCrossley
{
    public class DeskQuote
    {

        public string CustomerName { get; set; }
        public RushDays RushOrderDays { get; set; }

        public Desk Desk = new Desk();
        private const decimal BASE_PRICE = 200;
        private const decimal PER_DRAWER_PRICE = 50;
        public int materialPrice = 0;


        public decimal QuoteAmount { get; set; }
        public DateTime QuoteDate { get; set; }
        public string material { get => material; set => material = value; }

        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int MIN_DRAWERS = 0;
        public const int MAX_DRAWERS = 7;
        //public const int DEFAULT_PRODUCTION_DAYS = 14;

        //private const decimal 

        //public decimal QuoteAmount {get { return _QuoteAmount; }}
        //public DateTime QuoteDate {get { return _QuoteDate; }}

        public enum RushDays
        {
            None = 0,
            Three = 3,
            Five = 5,
            Seven = 7
        }

        public void CalculateDeskQuote()
        {

            // Updates the QuoteAmount and QuoteDate
            QuoteAmount = BASE_PRICE + LargeDeskPrice() + DrawerPrice() + materialPrice + RushOrderPrice();
            QuoteDate = DateTime.Now;

            switch (material)
            {
                case "Laminate":
                    materialPrice = (int)Desk.DesktopMaterials.Laminate;
                    break;
                case "Oak":
                    materialPrice = (int)Desk.DesktopMaterials.Oak;
                    break;
                case "Rosewood":
                    materialPrice = (int)Desk.DesktopMaterials.Rosewood;
                    break;
                case "Veneer":
                    materialPrice = (int)Desk.DesktopMaterials.Veneer;
                    break;
                case "Pine":
                    materialPrice = (int)Desk.DesktopMaterials.Pine;
                    break;
            }
        }

        private decimal DrawerPrice()
        {
            // Returns cost of all drawers
            return PER_DRAWER_PRICE * Desk.DrawerCount;
        }

        private decimal LargeDeskPrice()
        {
            // Returns cost of large desks > 1000 sq in.
            if (Desk.getSurfaceArea() > 1000)
            {
                return Desk.getSurfaceArea() - 1000;
            }
            else
                return 0;
        }

        private decimal RushOrderPrice()
        {

            if (RushOrderDays == RushDays.None)
                return 0;

            // Returns cost of rush order.
            if (Desk.getSurfaceArea() < 1000)
            {
                switch (RushOrderDays)
                {
                    case RushDays.Three:
                        return 60;
                    case RushDays.Five:
                        return 40;
                    case RushDays.Seven:
                        return 30;
                    default:
                        return 9999999;
                }
            }
            else if (Desk.getSurfaceArea() >= 1000 && Desk.getSurfaceArea() <= 2000)
            {
                switch (RushOrderDays)
                {
                    case RushDays.Three:
                        return 70;
                    case RushDays.Five:
                        return 50;
                    case RushDays.Seven:
                        return 35;
                    default:
                        return 9999999;
                }
            }
            else
            {
                switch (RushOrderDays)
                {
                    case RushDays.Three:
                        return 80;
                    case RushDays.Five:
                        return 60;
                    case RushDays.Seven:
                        return 40;
                    default:
                        return 9999999;
                }
            }
        }
            
    }
}


