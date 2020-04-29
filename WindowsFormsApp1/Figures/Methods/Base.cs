using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Figures
{
    abstract partial class Base
    {
        protected Base(Color color, decimal pen_size)
        {
            this.color = color;
            this.pen_size = pen_size;
            pen = new Pen(color, (float)this.pen_size);
        }
    }
}
