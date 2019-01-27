using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1_IrinaOhara
{
    class DeskQuote
    {
        #region Object member variables
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk newDesk = new Desk();
        //private int RushDays;
        private int QuoteAmount;
        #endregion

        #region local variables
        private int SurfaceArea = 0;
        private int DeskSurfaceCost = 0;
        private int ExtraSurfaceCharge = 0;
        private int RushProductionCost = 0;
        #endregion

        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int PRICE_PER_DRAWER = 50;

        public DeskQuote(int width, int depth, int drawers, string material, int rushDays)
        {
            newDesk.Width = width;
            newDesk.Depth = depth;
            newDesk.NumberOfDrawers = drawers;
            newDesk.DesktopMaterial = material;
            newDesk.RushDays = rushDays;

            SurfaceArea = width * depth;
        }

        public int CalculateQuoteTotal()
        {
            return PRICE_BASE + DrawerCost() + SurfaceCost() + RushCost();
        }

        private int DrawerCost()
        {
            return newDesk.NumberOfDrawers * PRICE_PER_DRAWER;
        }

        private int SurfaceCost()
        {
            if (SurfaceArea > 1000)
            {
                ExtraSurfaceCharge = SurfaceArea - 1000;
            }

            switch (newDesk.DesktopMaterial)
            {
                case "Oak":
                    DeskSurfaceCost = 200;
                    break;
                case "Laminate":
                    DeskSurfaceCost = 100;
                    break;
                case "Pine":
                    DeskSurfaceCost = 50;
                    break;
                case "Rosewood":
                    DeskSurfaceCost = 300;
                    break;
                case "Veneer":
                    DeskSurfaceCost = 125;
                    break;
            }
            return DeskSurfaceCost + ExtraSurfaceCharge;
        }

        private int RushCost()
        {
            switch (newDesk.RushDays)
            {
                case 3:
                    if(2000 > SurfaceArea && SurfaceArea > 1000){
                        RushProductionCost = 70;
                    }
                    else if(SurfaceArea > 2000)
                    {
                        RushProductionCost = 80;
                    }
                    {
                        RushProductionCost = 60;
                    }      
                    break;

                case 5:
                    if (2000 > SurfaceArea && SurfaceArea > 1000)
                    {
                        RushProductionCost = 50;
                    }
                    else if (SurfaceArea > 2000)
                    {
                        RushProductionCost = 60;
                    }
                    {
                        RushProductionCost = 40;
                    }
                    break;

                case 7:
                    if (2000 > SurfaceArea && SurfaceArea > 1000)
                    {
                        RushProductionCost = 35;
                    }
                    else if (SurfaceArea > 2000)
                    {
                        RushProductionCost = 40;
                    }
                    {
                        RushProductionCost = 30;
                    }
                    break;
            }
            return RushProductionCost;
        }
    }
}
