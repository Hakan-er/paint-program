using System.Drawing;
using System.Windows.Forms;

namespace CizimProgrami
{
    class Cizim
    {
        public static void ciz(bool kontrol, Panel cizimYeri, int sekil, Color renk, int x1, int y1, int x2, int y2)
        {
            if (kontrol)
            {
                Graphics formGrafik = cizimYeri.CreateGraphics();
                SolidBrush firca = new SolidBrush(renk);
                formGrafik.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                if (sekil == 0)
                {
                    if (x2 - x1 >= 0 && y2 - y1 >= 0) if (x2 >= 1037 || y2 >= 779) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else { Kontrol.sinirİcinde(); formGrafik.Clear(Color.White); if (Kontrol.SiniraGelindi == false) formGrafik.FillRectangle(firca, x1, y1, x2 - x1, y2 - y1); }
                    else if (x2 - x1 >= 0 && y2 - y1 < 0) if (x1 >= 1037 || y2 <= 0) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else { Kontrol.sinirİcinde(); formGrafik.Clear(Color.White); if (Kontrol.SiniraGelindi == false) formGrafik.FillRectangle(firca, x1, y2, x2 - x1, y1 - y2); }
                    else if (x2 - x1 < 0 && y2 - y1 >= 0) if (x2 <= 0 || y2 >= 779) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else { Kontrol.sinirİcinde(); formGrafik.Clear(Color.White); if (Kontrol.SiniraGelindi == false) formGrafik.FillRectangle(firca, x2, y1, x1 - x2, y2 - y1); }
                    else if (x2 - x1 < 0 && y2 - y1 < 0) if (x2 <= 0 || y2 <= 0) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else { Kontrol.sinirİcinde(); formGrafik.Clear(Color.White); if (Kontrol.SiniraGelindi == false) formGrafik.FillRectangle(firca, x2, y2, x1 - x2, y1 - y2); }
                }
                else if (sekil == 1)
                {
                    if (x2 > x1 && (x2 >= 1037 || x1 - ((2 * x2 - 2 * x1) / 2) <= 0 || y1 - ((2 * x2 - 2 * x1) / 2) + 2 * x2 - 2 * x1 >= 779 || y1 - ((2 * x2 - 2 * x1) / 2) <= 0)) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else if (x2 < x1 && (x2 <= 0 ||  x1+(x1-x2)   >= 1037 || y1-(x1-x2) <= 0 || y1 +(x1 - x2) >= 779)) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else { Kontrol.sinirİcinde(); formGrafik.Clear(Color.White); if (Kontrol.SiniraGelindi == false) formGrafik.FillEllipse(firca, x1 - ((2 * x2 - 2 * x1) / 2), y1 - ((2 * x2 - 2 * x1) / 2), 2 * x2 - 2 * x1, 2 * x2 - 2 * x1); }
                }
                else if (sekil == 2)
                {
                    Point[] noktalar = { new Point(x1, y1 - (x2 - x1)), new Point(x1 - (x2 - x1), y1 + (x2 - x1)), new Point(x1 + (x2 - x1), y1 + (x2 - x1)) };
                    if (x2 > x1 && (y1 - (x2 - x1) <= 0 || y1 + (x2 - x1) >= 779 || x1 - (x2 - x1) <= 0 || x1 + (x2 - x1) >= 1037)) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else if (x2 < x1 && (y1 - (x2 - x1) >= 779 || y1 + (x2 - x1) <= 0 || x1 - (x2 - x1) >= 1037 || x1 + (x2 - x1) <= 0)) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else { Kontrol.sinirİcinde(); formGrafik.Clear(Color.White); if (Kontrol.SiniraGelindi == false) formGrafik.FillPolygon(firca, noktalar); }
                }
                else if (sekil == 3)
                {
                    Point[] noktalar = { new Point(x1 - (x2 - x1), y1), new Point(x1 - (x2 - x1) / 2, y1 - (x2 - x1)), new Point(x1 + (x2 - x1) / 2, y1 - (x2 - x1)), new Point(x1 + (x2 - x1), y1), new Point(x1 + (x2 - x1) / 2, y1 + (x2 - x1)), new Point(x1 - (x2 - x1) / 2, y1 + (x2 - x1)) };
                    if (x2 > x1 && (x1 - (x2 - x1) <= 0 || x1 + (x2 - x1) >= 1037 || y1 - (x2 - x1) <= 0 || y1 + (x2 - x1) >= 779)) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else if (x2 < x1 && (x1 - (x2 - x1) >= 1037 || x1 + (x2 - x1) <= 0 || y1 + (x2 - x1) <= 0 || y1 - (x2 - x1) >= 779)) { if (Kontrol.SiniraGelindi == false) Kontrol.sinirAsildi(x2, y2); } else { Kontrol.sinirİcinde(); formGrafik.Clear(Color.White); if (Kontrol.SiniraGelindi == false) formGrafik.FillPolygon(firca, noktalar); }
                }
            }
        }

        public static void geciciCiz(bool kontrol, Panel cizimYeri, int sekil, Color renk, int x1, int y1, int x2, int y2)
        {
            if (kontrol)
            {
                Graphics formGrafik = cizimYeri.CreateGraphics();
                SolidBrush firca = new SolidBrush(renk);
                formGrafik.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                if (sekil == 0)
                {
                    if (x2 - x1 >= 0 && y2 - y1 >= 0) formGrafik.FillRectangle(firca, x1, y1, x2 - x1, y2 - y1);
                    else if (x2 - x1 >= 0 && y2 - y1 < 0) formGrafik.FillRectangle(firca, x1, y2, x2 - x1, y1 - y2);
                    else if (x2 - x1 < 0 && y2 - y1 >= 0) formGrafik.FillRectangle(firca, x2, y1, x1 - x2, y2 - y1);
                    else if (x2 - x1 < 0 && y2 - y1 < 0) formGrafik.FillRectangle(firca, x2, y2, x1 - x2, y1 - y2);
                }
                else if (sekil == 1)
                {
                    formGrafik.FillEllipse(firca, x1 - ((2 * x2 - 2 * x1) / 2), y1 - ((2 * x2 - 2 * x1) / 2), 2 * x2 - 2 * x1, 2 * x2 - 2 * x1);
                }
                else if (sekil == 2)
                {
                    Point[] noktalar = { new Point(x1, y1 - (x2 - x1)), new Point(x1 - (x2 - x1), y1 + (x2 - x1)), new Point(x1 + (x2 - x1), y1 + (x2 - x1)) };
                    formGrafik.FillPolygon(firca, noktalar);
                }
                else if (sekil == 3)
                {
                    Point[] noktalar = { new Point(x1 - (x2 - x1), y1), new Point(x1 - (x2 - x1) / 2, y1 - (x2 - x1)), new Point(x1 + (x2 - x1) / 2, y1 - (x2 - x1)), new Point(x1 + (x2 - x1), y1), new Point(x1 + (x2 - x1) / 2, y1 + (x2 - x1)), new Point(x1 - (x2 - x1) / 2, y1 + (x2 - x1)) };
                    formGrafik.FillPolygon(firca, noktalar);
                }
            }
        }

        public static void secim(Panel cizimYeri, int sekil, int x1, int y1, int x2, int y2)
        {
            Graphics formGrafik = cizimYeri.CreateGraphics();
            formGrafik.Clear(Color.White);
            Dosyalama.geciciDosyadanCiz(cizimYeri, true);
            Pen kalem = new Pen(Color.Black, 8);
            if (sekil == 0)
            {
                if (x2 - x1 >= 0 && y2 - y1 >= 0) formGrafik.DrawRectangle(kalem, x1 - 20, y1 - 20, x2 - x1 + 40, y2 - y1 + 40);
                else if (x2 - x1 >= 0 && y2 - y1 < 0) formGrafik.DrawRectangle(kalem, x1 - 20, y2 - 20, x2 - x1 + 40, y1 - y2 + 40);
                else if (x2 - x1 < 0 && y2 - y1 >= 0) formGrafik.DrawRectangle(kalem, x2 - 20, y1 - 20, x1 - x2 + 40, y2 - y1 + 40);
                else if (x2 - x1 < 0 && y2 - y1 < 0) formGrafik.DrawRectangle(kalem, x2 - 20, y2 - 20, x1 - x2 + 40, y1 - y2 + 40);
            }
            else if (sekil == 1)
            {
                if (x2 - x1 >= 0 && y2 - y1 >= 0) formGrafik.DrawEllipse(kalem, x1 - ((2 * x2 - 2 * x1) / 2) - 20, y1 - ((2 * x2 - 2 * x1) / 2) - 20, 2 * x2 - 2 * x1 + 40, 2 * x2 - 2 * x1 + 40);
                else if (x2 - x1 >= 0 && y2 - y1 < 0) formGrafik.DrawEllipse(kalem, x1 - ((2 * x2 - 2 * x1) / 2) - 20, y1 - ((2 * x2 - 2 * x1) / 2) - 20, 2 * x2 - 2 * x1 + 40, 2 * x2 - 2 * x1 + 40);
                else if (x2 - x1 < 0 && y2 - y1 >= 0) formGrafik.DrawEllipse(kalem, x1 - ((2 * x2 - 2 * x1) / 2) + 20, y1 - ((2 * x2 - 2 * x1) / 2) + 20, 2 * x2 - 2 * x1 - 40, 2 * x2 - 2 * x1 - 40);
                else if (x2 - x1 < 0 && y2 - y1 < 0) formGrafik.DrawEllipse(kalem, x1 - ((2 * x2 - 2 * x1) / 2) + 20, y1 - ((2 * x2 - 2 * x1) / 2) + 20, 2 * x2 - 2 * x1 - 40, 2 * x2 - 2 * x1 - 40);
            }
            else if (sekil == 2)
            {
                if (x1 < x2)
                {
                    Point[] noktalar = { new Point(x1, y1 - (x2 - x1) - 30), new Point(x1 - (x2 - x1) - 30, y1 + (x2 - x1) + 15), new Point(x1 + (x2 - x1) + 30, y1 + (x2 - x1) + 15) };
                    formGrafik.DrawPolygon(kalem, noktalar);
                }
                else
                {
                    Point[] noktalar = { new Point(x1, y1 - (x2 - x1) + 30), new Point(x1 - (x2 - x1) + 30, y1 + (x2 - x1) - 15), new Point(x1 + (x2 - x1) - 30, y1 + (x2 - x1) - 15) };
                    formGrafik.DrawPolygon(kalem, noktalar);
                }
            }
            else if (sekil == 3)
            {
                if (x1 < x2)
                {
                    Point[] noktalar = { new Point(x1 - (x2 - x1) - 15, y1), new Point(x1 - (x2 - x1) / 2 - 15, y1 - (x2 - x1) - 15), new Point(x1 + (x2 - x1) / 2 + 15, y1 - (x2 - x1) - 15), new Point(x1 + 15 + (x2 - x1), y1), new Point(x1 + (x2 - x1) / 2 + 15, y1 + (x2 - x1) + 15), new Point(x1 - (x2 - x1) / 2 - 15, y1 + (x2 - x1) + 15) };
                    formGrafik.DrawPolygon(kalem, noktalar);
                }
                else
                {
                    Point[] noktalar = { new Point(x1 - (x2 - x1) + 15, y1), new Point(x1 - (x2 - x1) / 2 + 15, y1 - (x2 - x1) + 15), new Point(x1 + (x2 - x1) / 2 - 15, y1 - (x2 - x1) + 15), new Point(x1 - 15 + (x2 - x1), y1), new Point(x1 + (x2 - x1) / 2 - 15, y1 + (x2 - x1) - 15), new Point(x1 - (x2 - x1) / 2 + 15, y1 + (x2 - x1) - 15) };
                    formGrafik.DrawPolygon(kalem, noktalar);
                }
            }
        }
    }
}
