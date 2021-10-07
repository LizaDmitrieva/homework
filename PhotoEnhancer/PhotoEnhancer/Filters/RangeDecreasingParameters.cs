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
        public double Coefficent1 { get; set; }
        public double Coefficent2 { get; set; }

        public ParameterInfo[] GetDisciption()
        {
            return new[]
            {
                new ParameterInfo()
                {
                    Name = "Коэффициент 1",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.01
                },

                new ParameterInfo()
                {
                    Name = "Коэффициент 2",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 1,
                    Increment = 0.01
                }
            };
        }

        public void SetValues(double[] values)
        {
            if (values[1] <= values[0])
            {
                MessageBox.Show("Преобразование не выполнено! Введенные значения недопустимы, коэффицент 2 должен быть больше коэффицента 1.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Coefficent1 = values[0];
            Coefficent2 = values[1];
        }
    }
}
