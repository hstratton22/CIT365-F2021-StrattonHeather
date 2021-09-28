using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stratton
{
    class Desk
    {
        private const int MINWIDTH = 24;
        private const int MAXWIDTH = 96;
        private const int MINDEPTH = 12;
        private const int MAXDEPTH = 48;
        private int width = 0;
        private int widthInput = 0;
        private int depth = 0;
        private int depthInput = 0;
        private int drawerCount = 0;
        private int area = 0;
        private DesktopMaterial desktopMaterial;

        public Desk() { }
        public int GetWidth() { return width; }
        public void SetWidth(int widthInput) { if (ValidatedWidth(widthInput)) { width = widthInput; } }
        public int GetDepth() { return depth; }
        public void SetDepth(int depthInput) { if (ValidatedDepth(depthInput)) depth = depthInput; }
        public bool ValidatedWidth(int widthInput) { if (widthInput > MINWIDTH && widthInput < MAXWIDTH) return true; else return false; }

        public bool ValidatedDepth(int depthInput) { if (depthInput > MINDEPTH && depthInput > MAXDEPTH) return true; else return false; }
        public int GetArea() { return area; }
        public void SetArea(int width, int depth) { area = width * depth; }
        public int GetDrawerCount() { return drawerCount; }
        public void SetDrawerCount(int count) { drawerCount = count; }
        public DesktopMaterial GetDesktopMaterial() {return desktopMaterial;}
        public void SetDesktopMaterial( DesktopMaterial sm)
        {
            desktopMaterial = sm;

        }
        public override string ToString()
        {
            return base.ToString(); // + "width: " + width + "\n" + " depth: "+ depth;
        }




    }
    enum DesktopMaterial
    {
        laminate, oak, pine, rosewood, veneer
    }
}
