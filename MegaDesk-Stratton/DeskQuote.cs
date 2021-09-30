using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stratton
{/// <summary>
/// DeskQuote class including constructors
/// get; set;
/// and calculation methods
/// </summary>
    public class DeskQuote
    {
        private string custName;
        private int rush;
        private int quote;
        private const int BASECOST = 200;
        private const int PERDRAWER = 50;
        private const int OVERSIZESURFACE = 1;
        private const int OVERSIZESTARTNUM = 1000;
        private const int OVERSIZEHIGHNUM = 2000;
        private DateTime date ;// = DateTime.Now;
        private Desk Desk;//readonly

        public DeskQuote()
        {
        }
        public DeskQuote(Desk desk) {
            this.Desk = desk;
        }
        public DeskQuote( Desk desk, DeskQuote newDeskQuote)//Desk desk
        {
            
    }
        
        public string GetCustName() { return this.custName; }
        public void SetCustName(string name) { custName = name; }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }
        public DateTime GetDate() { return date; }//.ToString("dd MMMM yyyy");

        public int GetRush() { return rush; }
        public void SetRush(int rushNum) {  rush= rushNum; }
       public void SetDesk(Desk desk) { Desk = desk; }
        public Desk GetDesk() { return Desk; }

        public int GetQuote() { return quote; }
        public void setQuote() { quote = AreaTotalCost() + CalcDrawerCost() + CalcRushCost() + CalcSurfaceCost(); }
        /// <summary>
        /// w*d of Desk, and calculates cost
        /// </summary>
        /// <returns></returns>
        public int AreaTotalCost()
        {
            int oversizedArea = 0;
            if (Desk.GetArea() > OVERSIZESTARTNUM)
            {
                oversizedArea = Desk.GetArea() - OVERSIZESTARTNUM;
            }
                return BASECOST + (OVERSIZESURFACE * oversizedArea);
            
        }/// <summary>
        /// calculates total cost of drawers
        /// </summary>
        /// <returns></returns>
        public int CalcDrawerCost()
        {
            return PERDRAWER * Desk.GetDrawerCount();
        }/// <summary>
        /// calculates total cost of rush order 
        /// </summary>
        /// <returns></returns>
        public int CalcRushCost() { 
            int result = 0;
            switch(rush)
            { case 3:
                    if (Desk.GetArea() < OVERSIZESTARTNUM) result = 60;
                    else if (Desk.GetArea() > OVERSIZESTARTNUM && Desk.GetArea() < OVERSIZEHIGHNUM) result = 70;
                    else result = 80;
                    break;
                case 5:
                    if (Desk.GetArea() < OVERSIZESTARTNUM) result = 40;
                    else if (Desk.GetArea() > OVERSIZESTARTNUM && Desk.GetArea() < OVERSIZEHIGHNUM) result = 50;
                    else result = 60;
                    break;
                case 7:
                    if (Desk.GetArea() < OVERSIZESTARTNUM) result = 30;
                    else if (Desk.GetArea() > OVERSIZESTARTNUM && Desk.GetArea() < OVERSIZEHIGHNUM) result = 35;
                    else result =40;
                    break;
                 default: 
                    result = 0;
                    break;

            }
            return result;
        }/// <summary>
        /// calculates surface cost using enum DesktopMaterial
        /// </summary>
        /// <returns></returns>
        public int CalcSurfaceCost()
        {
            int result = 0; 
            switch (Desk.GetDesktopMaterial()) 
            { 
                case DesktopMaterial.laminate: result = 100; break; 
                case DesktopMaterial.oak: result = 200; break; 
                case DesktopMaterial.pine: result = 50; break; 
                case DesktopMaterial.rosewood: result = 300; break; 
                case DesktopMaterial.veneer: result = 125; break;
        } return result;
            
            
}/// <summary>
/// calculates surface cost using string from combobox
/// </summary>
/// <param name="selectedSurface"></param>
/// <returns></returns>
        public int CalcSurfaceCost(string selectedSurface)
        {
            int result = 0;
            switch (selectedSurface)
            {
                case "laminate": result = 100; break;
                case "oak": result = 200; break;
                case "pine": result = 50; break;
                case "rosewood": result = 300; break;
                case "veneer": result = 125; break;
            }
            return result;


        }
        /// <summary>
        /// override ToString() including custName for reference
        /// </summary>
        /// <returns></returns>



        public override string ToString()
        {
            return base.ToString()+"\n"+
               "name:" + GetCustName();
        }




    }
}
