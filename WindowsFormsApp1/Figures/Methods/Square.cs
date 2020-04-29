using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Figures
{
    partial class Square: Rect
    {
        public Square(Color color, decimal pen_size) : base(color, pen_size)
        {

        }
        public new void Draw(Graphics gdi)
        {
            rectangle = new Rectangle();
            rectangle.X = x;
            rectangle.Y = y;
            rectangle.Width = width;
            rectangle.Height = width;
            gdi.DrawRectangle(pen, rectangle);
        }
    }
}
