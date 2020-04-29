using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Figures
{
    partial class Line: Base
    {
        public Line(Color color, decimal pen_size) : base(color, pen_size)
        {
            point1 = new Point();
            point2 = new Point();
        }
        public void Draw(Graphics gdi)
        {
            point1.X = x1;
            point1.Y = y1;
            point2.X = x2;
            point2.Y = y2;
            gdi.DrawLine(pen, point1, point2);

        }
    }
}
