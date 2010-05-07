using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greyhound.TileEditor
{
    public class HSLColor
    {
        #region Fields

        private double h;
        public double H { get; set; }

        private double s;
        public double S { get; set; }

        private double l;
        public double L { get; set; }

        #endregion Fields

        #region Constructor

        public HSLColor(double H, double S, double L)
        {
            this.h = H;
            this.s = S;
            this.l = L;
        }

        public HSLColor()
            : this(0, 0, 0)
        {
        }

        #endregion
    }
}
