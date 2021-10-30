using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeskExperiment.Models
{
    public class Desk
    {
        public int ID { get; set; }
        //private const int MinWidth = 24;
        //private const int MaxWidth = 96;
       // private const int MinDepth = 12;
        //private const int MaxDepth = 48;
        //1-100: ^([1-9][0-9]?|100)$ or /^([1-9]{1,2}|100)$/
        //0-100: ^(0|[1-9][0-9]?|100)$

        //private int _width;
        //private int _depth;
        [EnumDataType(typeof(DesktopMaterial))]
        public DesktopMaterial desktopMaterial { get; set; }
       // public int GetMinWidth() { return MinWidth; }
        //public int GetMaxWidth() { return MaxWidth; }
        //public int GetMinDepth() { return MinDepth; }
       // public int GetMaxDepth() { return MaxDepth; }
        //[RegularExpression(/^([1 - 9]{1,2}|100)$)]
        [Range(24, 96)]
        [Required]
        public int Width { get; set; }
        /*{
            get { return _width; }
            set
            {
                if (ValidatedWidth(value))
                {
                    _width = value;
                }
            }
        }*/
        [Range(12, 48)]
        [Required]
        public int Depth { get; set; }
        /*
        {
            get { return _depth; }
            set
            {
                if (ValidatedDepth(value))
                { _depth = value; }
            }
        }*/
        public int Area
        {
            //get { return _width * _depth; }
            get { return Width * Depth; }
        }
       // public bool ValidatedWidth(int widthInput) { if (widthInput >= MinWidth && widthInput <= MaxWidth) return true; else return false; }

        //public bool ValidatedDepth(int depthInput) { if (depthInput >= MinDepth && depthInput <= MaxDepth) return true; else return false; }
        [Range(0, 7)]
        [Required]

        public int DrawerCount { get; set; }


        /// <summary>
        /// override of ToString() for testing references
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Width: {0}, Depth: {1}, Material: {2}", Width, Depth, desktopMaterial);
        }





    }/// <summary>
     /// surface options enum
     /// </summary>
    public enum DesktopMaterial
    {
        Laminate, Oak, Pine, Rosewood, Veneer
    }
}

