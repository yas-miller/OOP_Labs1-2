using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    static class Risovalka
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        private static Form1 Form1;
        private static Form Form2;
        
        public static Graphics gdi;
        public static Color color;
        public static decimal pen_size;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 = new Form1();
            Form2 = new Form();

            Form2.MdiParent = Form1;
            Form2.Parent = Form1.panel2;
            Form2.Height = Form1.panel2.Height;
            Form2.Width = Form1.panel2.Width;
            Form2.FormBorderStyle = FormBorderStyle.None;
            Form2.Show();

            gdi = Form2.CreateGraphics();
            color = Form1.colorDialog1.Color;
            pen_size = Form1.numericUpDown1.Value;

            Form1.button1.Click += new EventHandler(Form1.button1_Click);
            Form1.button2.Click += new EventHandler(Form1.button2_Click);
            Form1.button3.Click += new EventHandler(Form1.button3_Click);
            Form1.button4.Click += new EventHandler(Form1.button4_Click);
            Form1.button5.Click += new EventHandler(Form1.button5_Click);
            Form1.button6.Click += new EventHandler(Form1.button6_Click);
            
            Application.Run(Form1);
        }
        public static bool CheckCoord(int[] coordinates)
        {
            for (int i = 0; i<coordinates.Count();i++)
            {
                if (coordinates[i] < 0) return false;
            }
            return true;
        }
    }

}
