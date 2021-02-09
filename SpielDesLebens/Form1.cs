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
        Random myRandom = new Random();

        public SpielDesLebens()
        {
            InitializeComponent();
            theBitmap = new Bitmap(pnl_canvas.Width, pnl_canvas.Height);
            steine = new int[101, 101];

            for (int x = 0; x < 101; x++)
            {
                for (int y = 0; y < 101; y++)
                {
                    steine[x, y] = myRandom.Next(0, 2);
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
                        if (steine[x, y] == 0)
                        {
                            g.FillRectangle(brushWhite, x * 10, y * 10, 10, 10);
                        }
                        if (steine[x, y] == 1)
                        {
                            g.FillRectangle(brushBlack, x * 10, y * 10, 10, 10);
                        }
                        g.DrawRectangle(black, x * 10, y * 10, 10, 10);
                    }
                }

            }
            pnl_canvas.Invalidate();


        }

        private void pnl_canvas_Paint(object sender, PaintEventArgs e)
        {
            //unter pnl_canvas_Paint_1 zu finden
        }

        private void pnl_canvas_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mausklick auf " + e.Location);
            int kx = 0; int ky = 0;
            kx = e.X / 10; ky = e.Y / 10;

            if (steine[kx, ky] == 1)
            {
                steine[kx, ky] = 2;
            }

            DrawGame();
        }

        private void AnAusRätsel_Load(object sender, EventArgs e)
        {

        }

        private void Schritt()
        {
            // WICHTIG: Ich hatte euch die Array.Clone()-Funktion gezeigt. Ohne die funktioniert euer Programm nicht, denn:
            // Nehmen wir an, die erste Zelle, die wir anschauen, würde im nächsten Schritt sterben. Wenn wir diese jetzt
            // schon sterben lassen, und uns die Zelle daneben anschauen, hat diese keine Nachbarn mehr. Allerdings
            // wäre die Zelle erst im nächsten Schritt tot, und nicht schon in diesem.

            int[,] steine2 = (int[,])steine.Clone();  //--> Wohin?

            for (int x = 0; x < 100; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    int links = x - 1, rechts = x + 1, oben = y - 1, unten = y + 1, zähler = 0;
                    if (links < 0)
                        links = 99;
                    if (rechts == 100)
                        rechts = 0;
                    if (oben < 0)
                        oben = 99;
                    if (unten == 100)
                        unten = 0;

                    if (steine[links, y] == 1) { zähler++; }
                    if (steine[rechts, y] == 1) { zähler++; }
                    if (steine[x, oben] == 1) { zähler++; }
                    if (steine[x, unten] == 1) { zähler++; }
                    if (steine[links, oben] == 1) { zähler++; }
                    if (steine[links, unten] == 1) { zähler++; }
                    if (steine[rechts, oben] == 1) { zähler++; }
                    if (steine[rechts, unten] == 1) { zähler++; }

                    if (steine[x, y] == 0)
                    {
                        // Der Rest sollte soweit funktionieren, jetzt den Herz des Programms hier noch vervollständigen
                        // Wann werden Zellen neu erschaffen?
                    }
                    else
                    {
                        // Wann sterben Zellen bzw. bleiben am Leben?
                        steine2[x, y] = 0;
                    }
                }
            }
            steine = (int[,])steine2.Clone();

            schritt++;
            lbl_schritt.Text = "Schritte: " + schritt;
        }

        private void pnl_canvas_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(theBitmap, new Point(0, 0));
        }

        private void Los_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Schritt();
            DrawGame();
        }
    }
}
