using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    class BevelTransformer : ITransformer<BevelParameters>
    {
        public Size ResultSize { get; private set; }

        Size size;
        double angleInRadians;

        public void Initialize(Size size, BevelParameters parameters)
        {
            this.size = size;
            angleInRadians = parameters.AngleInDegrees * Math.PI / 180;

            ResultSize = new Size(
                         (int)Math.Round((Math.Abs(Math.Tan(angleInRadians) * size.Height) + size.Width)),
                         (int)size.Height);
        }

        public Point? MapPoint(Point newPoint)
        {
            var p = new Point(newPoint.X - ResultSize.Width,
                        newPoint.Y);

            var x = (int)Math.Round((p.X +
                p.Y * Math.Tan(angleInRadians) + size.Width));

            var y = (int)p.Y;

            if (x < 0 || x >= size.Width || y < 0 || y >= size.Height)
                return null;

            return new Point(x, y);
        }
    }
}
