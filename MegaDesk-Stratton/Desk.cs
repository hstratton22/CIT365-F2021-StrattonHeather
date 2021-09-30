using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stratton
{/// <summary>
/// desk class 
/// get;set;
/// and methods
/// </summary>
    public class Desk
    {
        private const int MINWIDTH = 24;
        private const int MAXWIDTH = 96;
        private const int MINDEPTH = 12;
        private const int MAXDEPTH = 48;
        private int width = 0;
       // private int widthInput = 0;
        private int depth = 0;
        //private int depthInput = 0;
        private int drawerCount;
        private int area;
        private DesktopMaterial desktopMaterial = DesktopMaterial.pine;

        public Desk() { }
        public int GetMINWIDTH() { return MINWIDTH; }
        public int GetMAXWIDTH() { return MAXWIDTH; }
        public int GetMINDEPTH() { return MINDEPTH; }
        public int GetMAXDEPTH() { return MAXDEPTH; }
        public int GetWidth() { return width; }
        public void SetWidth(int widthInput) { if (ValidatedWidth(widthInput)) { width = widthInput; } }
        public int GetDepth() { return depth; }
        public void SetDepth(int depthInput) { if (ValidatedDepth(depthInput)) { depth = depthInput;}}
        public bool ValidatedWidth(int widthInput) { if (widthInput >= MINWIDTH && widthInput <= MAXWIDTH) return true; else return false; }

        public bool ValidatedDepth(int depthInput) { if (depthInput >= MINDEPTH && depthInput <= MAXDEPTH) return true; else return false; }
        public int GetArea() { return area; }
        public void SetArea(int width, int depth) { area = width * depth; }
        public int GetDrawerCount() { return drawerCount; }
        /// <summary>
        /// numericupdown uses decimal so converted here
        /// </summary>
        /// <param name="count"></param>
        public void SetDrawerCount(decimal count) { drawerCount = Decimal.ToInt32(count); }
        public DesktopMaterial GetDesktopMaterial() {return desktopMaterial;}
        public void SetDesktopMaterial( DesktopMaterial sm)
        {
            desktopMaterial = sm;

        }/// <summary>
        /// gets string from combobox selection and sets the value to the enum
        /// </summary>
        /// <param name="sm"></param>
        public void SetDesktopMaterial(string sm)
        {
            switch (sm)
            {
                case "laminate":desktopMaterial= DesktopMaterial.laminate; break;
                case "oak": desktopMaterial= DesktopMaterial.oak; break;
                case "pine": desktopMaterial = DesktopMaterial.pine; break;
                case "rosewood": desktopMaterial = DesktopMaterial.rosewood; break;
                case "veneer": desktopMaterial = DesktopMaterial.veneer; break;
                default: desktopMaterial = DesktopMaterial.pine; break;
            }
        }/// <summary>
        /// override of ToString() for testing references
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString(); // + "width: " + width + "\n" + " depth: "+ depth;
        }




    }/// <summary>
    /// surface options enum
    /// </summary>
    public enum DesktopMaterial
    {
        laminate, oak, pine, rosewood, veneer
    }
}
