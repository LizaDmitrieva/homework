using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class RangeDecreasingFilter : PixelFilter
    {
        public RangeDecreasingFilter() : base(new RangeDecreasingParameters()) { }

        public override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            double c1 = (parameters as RangeDecreasingParameters).Coefficent1;
            double c2 = (parameters as RangeDecreasingParameters).Coefficent2;

            return (c2 - c1) * original + c1;
        }

        public override string ToString()
        {
            return "Сужение диапазона";
        }
    }
}
