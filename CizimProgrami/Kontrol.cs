using System.Windows.Forms;
using System.Drawing;

namespace CizimProgrami
{
    class Kontrol
    {
        private static bool siniraGelindi = false;
        public static bool SiniraGelindi { get { return siniraGelindi; } }
        private static bool ilkSekilCizildi = false;
        public static bool IlkSekilCizildi { get { return ilkSekilCizildi; } }
        private static int baslangicX;
        public static int BaslangicX { get { return baslangicX; } }
        private static int baslangicY;
        public static int BaslangicY { get { return baslangicY; } }
        private static int bitisX;
        public static int BitisX { get { return bitisX; } }
        private static int bitisY;
        public static int BitisY { get { return bitisY; } }
        private static bool ciz;
        public static bool Ciz { get { return ciz; } }
        private static bool sec = false;
        public static bool Sec { get { return sec; } }
        private static int secilenX;
        public static int SecilenX { get { return secilenX; } }
        private static int secilenY;
        public static int SecilenY { get { return secilenY; } }
        private static Color renk = Color.White;
        public static Color Renk { get { return renk; } }
        private static int sekil = -1;
        public static int Sekil { get { return sekil; } }
        private static int sinirX;
        public static int SinirX { get { return sinirX; } }
        private static int sinirY;
        public static int SinirY { get { return sinirY; } }

        public static void cizBasildi(MouseEventArgs e)
        {
            if (renk != Color.White)
            {
                baslangicX = e.X;
                baslangicY = e.Y;
                ciz = true;
            }
        }

        public static void cizBirakildi(MouseEventArgs e)
        {
            if (renk != Color.White)
            {
                bitisX = e.X;
                bitisY = e.Y;
                ciz = false;
                Dosyalama.geciciKayit();
                ilkSekilCizildi = true;
            }
        }

        public static void sinirAsildi(int x, int y)
        {
            siniraGelindi = true;
             sinirX = x;
             sinirY = y;
        }

        public static void sinirİcinde()
        {
            siniraGelindi = false;
        }

        public static void secBasildi()
        {
            sec = true;
        }
        public static void secBirakildi()
        {
            secilenX = 0;
            secilenY = 0;
            sec = false;
        }

        public static void secimYap(Panel cizimYeri, int x, int y)
        {
            secilenX = x;
            secilenY = y;
            Dosyalama.secileniBul(cizimYeri, x, y);
        }

        public static void sekilSec(int secilenSekil)
        {
            sekil = secilenSekil;
        }

        public static void renkSec(Color secilenRenk)
        {
            renk = secilenRenk;
        }
        
        public static void ilkSekil()
        {
            ilkSekilCizildi = true;
        }
    }
}
