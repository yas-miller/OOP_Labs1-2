using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Risovalka;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Figures.Rect rect = new Figures.Rect(color,pen_size);
            try
            {
                rect.x = System.Convert.ToInt32(this.textBox1.Text);
                rect.y = System.Convert.ToInt32(this.textBox2.Text);
                rect.width = System.Convert.ToInt32(this.textBox3.Text);
                rect.height = System.Convert.ToInt32(this.textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
            int[] coordinates = new int[4];
            coordinates[0] = rect.x;
            coordinates[1] = rect.y;
            coordinates[2] = rect.width;
            coordinates[3] = rect.height;

            if(Risovalka.CheckCoord(coordinates)) rect.Draw(gdi);
            else MessageBox.Show("Неверный ввод, параметр(-ы) не могут быть отрицательными",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Figures.Square square = new Figures.Square(color, pen_size);
            try
            {
                square.x = System.Convert.ToInt32(this.textBox11.Text);
                square.y = System.Convert.ToInt32(this.textBox12.Text);
                square.width = System.Convert.ToInt32(this.textBox13.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                return;
            }
            int[] coordinates = new int[3];
            coordinates[0] = square.x;
            coordinates[1] = square.y;
            coordinates[2] = square.width;

            if (Risovalka.CheckCoord(coordinates)) square.Draw(gdi);
            else MessageBox.Show("Неверный ввод, параметр(-ы) не могут быть отрицательными",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Figures.Triangle triangle = new Figures.Triangle(color, pen_size);
            try
            {
                triangle.x1 = System.Convert.ToInt32(this.textBox21.Text);
                triangle.y1 = System.Convert.ToInt32(this.textBox22.Text);
                triangle.x2 = System.Convert.ToInt32(this.textBox23.Text);
                triangle.y2 = System.Convert.ToInt32(this.textBox24.Text);
                triangle.x3 = System.Convert.ToInt32(this.textBox25.Text);
                triangle.y3 = System.Convert.ToInt32(this.textBox26.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                return;
            }
            int[] coordinates = new int[6];
            coordinates[0] = triangle.x1;
            coordinates[1] = triangle.y1;
            coordinates[2] = triangle.x2;
            coordinates[3] = triangle.y2;
            coordinates[4] = triangle.x3;
            coordinates[5] = triangle.y3;

            if (Risovalka.CheckCoord(coordinates)) triangle.Draw(gdi);
            else MessageBox.Show("Неверный ввод, параметр(-ы) не могут быть отрицательными",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Figures.Ellipse ellipse = new Figures.Ellipse(color, pen_size);
            try
            {
                ellipse.x = System.Convert.ToInt32(this.textBox31.Text);
                ellipse.y = System.Convert.ToInt32(this.textBox32.Text);
                ellipse.radiusX = System.Convert.ToInt32(this.textBox33.Text);
                ellipse.radiusY = System.Convert.ToInt32(this.textBox34.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                return;
            }
            int[] coordinates = new int[4];
            coordinates[0] = ellipse.x;
            coordinates[1] = ellipse.y;
            coordinates[2] = ellipse.radiusX;
            coordinates[3] = ellipse.radiusY;

            if (Risovalka.CheckCoord(coordinates)) ellipse.Draw(gdi);
            else MessageBox.Show("Неверный ввод, параметр(-ы) не могут быть отрицательными",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            Figures.Circle circle = new Figures.Circle(color, pen_size);
            try
            {
                circle.x = System.Convert.ToInt32(this.textBox41.Text);
                circle.y = System.Convert.ToInt32(this.textBox42.Text);
                circle.radiusX = System.Convert.ToInt32(this.textBox43.Text);
                
            }
            catch
            {
                MessageBox.Show("Неверный ввод",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                return;
            }
            int[] coordinates = new int[3];
            coordinates[0] = circle.x;
            coordinates[1] = circle.y;
            coordinates[2] = circle.radiusX;

            if (Risovalka.CheckCoord(coordinates))
            {
                circle.radiusY = circle.radiusX;
                circle.Draw(gdi);
            }
            else MessageBox.Show("Неверный ввод, параметр(-ы) не могут быть отрицательными",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        public void button6_Click(object sender, EventArgs e)
        {
            Figures.Line line = new Figures.Line(color, pen_size);
            try
            {
                line.x1 = System.Convert.ToInt32(this.textBox51.Text);
                line.y1 = System.Convert.ToInt32(this.textBox52.Text);
                line.x2 = System.Convert.ToInt32(this.textBox53.Text);
                line.y2 = System.Convert.ToInt32(this.textBox54.Text);
            }
            catch
            {
                MessageBox.Show("Неверный ввод",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                return;
            }
            int[] coordinates = new int[4];
            coordinates[0] = line.x1;
            coordinates[1] = line.y1;
            coordinates[2] = line.x2;
            coordinates[3] = line.y2;

            if (Risovalka.CheckCoord(coordinates)) line.Draw(gdi);
            else MessageBox.Show("Неверный ввод, параметр(-ы) не могут быть отрицательными",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                button8.BackColor = color;
                label25.Text = "Цвет: " + colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button8.BackColor = colorDialog1.Color;
            label25.Text = "Цвет: " + colorDialog1.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen_size = numericUpDown1.Value;
        }
    }
}
