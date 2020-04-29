﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Figures
{
    partial class Rect: Base
    {
        
        public Rect(Color color, decimal pen_size) : base(color, pen_size)
        {
            rectangle = new Rectangle();
        }
        public void Draw(Graphics gdi)
        {
            rectangle.X = x;
            rectangle.Y = y;
            rectangle.Width = width;
            rectangle.Height = height;
            gdi.DrawRectangle(pen, rectangle);
        }
    }
}
