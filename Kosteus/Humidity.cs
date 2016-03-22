using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosteus
{
    class Humidity
    {
        private readonly double minhumidity;
        private readonly double maxhumidity;

        private double min;
        private double max;

        public double Min

        {
            get
            {
                return min;
            }
            set
            {
                if (value < minhumidity) min = value;
            }
        }

            public double Max
        {
            get
            {
                return max;
            }
            set
            {
                if (value > maxhumidity) max = value;
            }
        }
        



















    }
}
