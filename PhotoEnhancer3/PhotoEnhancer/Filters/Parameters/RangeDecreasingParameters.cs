using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEnhancer
{
    public class RangeDecreasingParameters : IParameters
    {
        [ParameterInfo(Name = "Коэффициент 1", MinValue = 0, MaxValue = 1, DefaultValue = 0, Increment = 0.01)]
        public double Coefficent1 { get; set; }

        [ParameterInfo(Name = "Коэффициент 2", MinValue = 0, MaxValue = 1, DefaultValue = 1, Increment = 0.01)]       
        public double Coefficent2 { get; set; }
    }
}
