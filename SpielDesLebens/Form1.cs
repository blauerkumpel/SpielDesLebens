using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpielDesLebens
{
    public partial class SpielDesLebens : Form
    {
        Bitmap theBitmap;
        SolidBrush brushBlack = new SolidBrush(Color.Black);
        SolidBrush brushWhite = new SolidBrush(Color.White);
        SolidBrush brushRed = new SolidBrush(Color.Red);
        Pen black = new Pen(Brushes.Black);
        int[,] steine;
        int schritt = 0;

        public SpielDesLebens()
        {
            InitializeComponent();
            theBitmap = new Bitmap(pnl_canvas.Width, pnl_canvas.Height);
            steine = new int[101, 101];

            for (int x = 0; x < 101; x++)
            {
                for (int y = 0; y < 101; y++)
                {
                    steine[x, y] = 1;
                }
            }

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnl_canvas, new object[] { true });
            DrawGame();
        }

        private void DrawGame()
        {
            using (Graphics g = Graphics.FromImage(theBitmap))
            {
                for (int x = 0; x < 101; x++)
                {
                    for (int y = 0; y < 101; y++)
                    {
                        if (steine[x, y] == 1)
                        {
                            g.FillRectangle(brushWhite, x * 10, y * 10, 10, 10);
                        }
                        if (steine[x, y] == 2)
                        {
                            g.FillRectangle(brushBlack, x * 10, y * 10, 10, 10);
                        }
                        g.DrawRectangle(black, x * 10, y * 10, 10, 10);
                    }
                }

            }
            pnl_canvas.Invalidate();

            schritt++;
            lbl_schritt.Text = "Schritte: " + schritt;
        }

        private void pnl_canvas_Paint(object sender, PaintEventArgs e)
        {
            //unter pnl_canvas_Paint_1 zu finden
        }

        private void pnl_canvas_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mausklick auf " + e.Location);
            int kx = 0; int ky = 0;
            kx = e.X/10 ; ky = e.Y/10 ;

            if (steine[kx, ky] == 1)
            {
                steine[kx, ky] = 2;
            }

            DrawGame();
        }

        private void AnAusRätsel_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x < 101; x++)
            {
                for (int y = 0; y < 101; y++)
                {
                    
                }
            }
        }

        private void pnl_canvas_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(theBitmap, new Point(0, 0));
        }
    }
}
