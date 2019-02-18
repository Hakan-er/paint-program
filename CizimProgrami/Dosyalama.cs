using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace CizimProgrami
{
    class Dosyalama
    {
        public static void geciciKayit()
        {
            int renk = 0;
            if (Kontrol.Renk == Color.Cyan) { renk = 0; }
            else if (Kontrol.Renk == Color.LightGray) { renk = 1; }
            else if (Kontrol.Renk == Color.Yellow) { renk = 2; }
            else if (Kontrol.Renk == Color.Blue) { renk = 3; }
            else if (Kontrol.Renk == Color.Red) { renk = 4; }
            else if (Kontrol.Renk == Color.Green) { renk = 5; }
            else if (Kontrol.Renk == Color.Purple) { renk = 6; }
            else if (Kontrol.Renk == Color.Orange) { renk = 7; }
            else if (Kontrol.Renk == Color.Brown) { renk = 8; }
            FileStream fs = new FileStream(Application.StartupPath.ToString() + "\\tmp.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            if (Kontrol.SiniraGelindi == false)
                sw.WriteLine("{0} {1} {2} {3} {4} {5}", Kontrol.BaslangicX, Kontrol.BaslangicY, Kontrol.BitisX, Kontrol.BitisY, renk, Kontrol.Sekil);
            else
                sw.WriteLine("{0} {1} {2} {3} {4} {5}", Kontrol.BaslangicX, Kontrol.BaslangicY, Kontrol.SinirX, Kontrol.SinirY, renk, Kontrol.Sekil);
            sw.Flush();
            sw.Close(); fs.Close();
        }

        public static void kayit(SaveFileDialog save)
        {

            string yazi;
            FileStream fs = new FileStream(Application.StartupPath.ToString() + "\\tmp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(save.FileName);
            for (; ; )
            {
                yazi = sr.ReadLine();
                if (yazi == null) break;
                sw.WriteLine(yazi);
            }
            sw.Flush();
            sw.Close(); sr.Close(); fs.Close();
        }

        public static void dosyaAc(OpenFileDialog file, Panel cizimYeri)
        {
            FileStream fs = new FileStream(file.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream fs2 = new FileStream(Application.StartupPath.ToString() + "\\tmp.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs2);
            for (; ; )
            {
                string yazi = sr.ReadLine();
                if (yazi == null) break;
                sw.WriteLine(yazi);
            }
            sw.Flush();
            sw.Close(); fs2.Close(); sr.Close(); fs.Close();Kontrol.ilkSekil();
        }
        public static void geciciDosyadanCiz(Panel cizimYeri, bool kontrol)
        {
            if (kontrol)
            {
                FileStream fs = new FileStream(Application.StartupPath.ToString() + "\\tmp.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                for (; ; )
                {
                    Color renk = Color.White;
                    string yazi;
                    string[] bolunmus = new string[6];
                    yazi = sr.ReadLine();
                    if (yazi == null) break;
                    bolunmus = yazi.Split(' ');
                    if (Convert.ToInt32(bolunmus[4]) == 0) { renk = Color.Cyan; }
                    else if (Convert.ToInt32(bolunmus[4]) == 1) { renk = Color.LightGray; }
                    else if (Convert.ToInt32(bolunmus[4]) == 2) { renk = Color.Yellow; }
                    else if (Convert.ToInt32(bolunmus[4]) == 3) { renk = Color.Blue; }
                    else if (Convert.ToInt32(bolunmus[4]) == 4) { renk = Color.Red; }
                    else if (Convert.ToInt32(bolunmus[4]) == 5) { renk = Color.Green; }
                    else if (Convert.ToInt32(bolunmus[4]) == 6) { renk = Color.Purple; }
                    else if (Convert.ToInt32(bolunmus[4]) == 7) { renk = Color.Orange; }
                    else if (Convert.ToInt32(bolunmus[4]) == 8) { renk = Color.Brown; }
                    Cizim.geciciCiz(true, cizimYeri, Convert.ToInt32(bolunmus[5]), renk, Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                }
                sr.Close(); fs.Close();
            }
        }

        public static void secileniBul(Panel cizimYeri, int x, int y)
        {
            FileStream fs = new FileStream(Application.StartupPath.ToString() + "\\tmp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            for (; ; )
            {
                string yazi;
                string[] bolunmus = new string[6];
                yazi = sr.ReadLine();
                if (yazi == null) break;
                bolunmus = yazi.Split(' ');
                int x1 = Convert.ToInt32(bolunmus[0]), y1 = Convert.ToInt32(bolunmus[1]), x2 = Convert.ToInt32(bolunmus[2]), y2 = Convert.ToInt32(bolunmus[2]);
                int a = x1 - ((2 * x2 - 2 * x1) / 2), b = y1 - ((2 * x2 - 2 * x1) / 2), c = (x1 - ((2 * x2 - 2 * x1) / 2)) + 2 * x2 - 2 * x1, d = (y1 - ((2 * x2 - 2 * x1) / 2)) + 2 * x2 - 2 * x1;
                if (Convert.ToInt32(bolunmus[5]) == 0)
                {
                    if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (Convert.ToInt32(bolunmus[2]) > x && x > Convert.ToInt32(bolunmus[0]) && Convert.ToInt32(bolunmus[3]) > y && y > Convert.ToInt32(bolunmus[1]))
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (Convert.ToInt32(bolunmus[2]) > x && x > Convert.ToInt32(bolunmus[0]) && Convert.ToInt32(bolunmus[1]) > y && y > Convert.ToInt32(bolunmus[3]))
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (Convert.ToInt32(bolunmus[0]) > x && x > Convert.ToInt32(bolunmus[2]) && Convert.ToInt32(bolunmus[3]) > y && y > Convert.ToInt32(bolunmus[1]))
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (Convert.ToInt32(bolunmus[0]) > x && x > Convert.ToInt32(bolunmus[2]) && Convert.ToInt32(bolunmus[1]) > y && y > Convert.ToInt32(bolunmus[3]))
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 1)
                {
                    if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (c > x && x > a && d > y && y > b)
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (c > x && x > a && d > y && y > b)
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (a > x && x > c && b > y && y > d)
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (a > x && x > c && b > y && y > d)
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 2)
                {
                    if (x1 < x2)
                    {
                        if (x1 - (x2 - x1) < x && x < x1 + (x2 - x1) && y1 - (x2 - x1) < y && y < y1 + (x2 - x1))
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                    else
                    {
                        if (x1 + (x2 - x1) < x && x < (x1 - (x2 - x1)) && y1 + (x2 - x1) < y && y < y1 - (x2 - x1))
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 3)
                {
                    if (x1 < x2)
                    {
                        if (x1 - (x2 - x1) < x && x < x1 + (x2 - x1) && y1 - (x2 - x1) < y && y < y1 + (x2 - x1))
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                    else
                    {
                        if (x1 + (x2 - x1) < x && x < x1 - (x2 - x1) && y1 + (x2 - x1) < y && y < y1 - (x2 - x1))
                        {
                            Cizim.secim(cizimYeri, Convert.ToInt32(bolunmus[5]), Convert.ToInt32(bolunmus[0]), Convert.ToInt32(bolunmus[1]), Convert.ToInt32(bolunmus[2]), Convert.ToInt32(bolunmus[3]));
                            break;
                        }
                    }
                }
            }
            sr.Close(); fs.Close();
        }

        public static void renkDegistir(Panel cizimYeri, Color renkYazi, int x, int y)
        {
            int renk = -1;
            if (renkYazi == Color.Cyan) { renk = 0; }
            else if (renkYazi == Color.LightGray) { renk = 1; }
            else if (renkYazi == Color.Yellow) { renk = 2; }
            else if (renkYazi == Color.Blue) { renk = 3; }
            else if (renkYazi == Color.Red) { renk = 4; }
            else if (renkYazi == Color.Green) { renk = 5; }
            else if (renkYazi == Color.Purple) { renk = 6; }
            else if (renkYazi == Color.Orange) { renk = 7; }
            else if (renkYazi == Color.Brown) { renk = 8; }
            FileStream fs = new FileStream(Application.StartupPath.ToString() + "\\tmp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream fs2 = new FileStream(Application.StartupPath.ToString() + "\\tmp2.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs2);
            for (; ; )
            {
                bool kontrol = false;
                string yazi;
                string[] bolunmus = new string[6];
                yazi = sr.ReadLine();
                if (yazi == null) break;
                bolunmus = yazi.Split(' ');
                int x1 = Convert.ToInt32(bolunmus[0]), y1 = Convert.ToInt32(bolunmus[1]), x2 = Convert.ToInt32(bolunmus[2]), y2 = Convert.ToInt32(bolunmus[2]);
                int a = x1 - ((2 * x2 - 2 * x1) / 2), b = y1 - ((2 * x2 - 2 * x1) / 2), c = (x1 - ((2 * x2 - 2 * x1) / 2)) + 2 * x2 - 2 * x1, d = (y1 - ((2 * x2 - 2 * x1) / 2)) + 2 * x2 - 2 * x1;
                if (Convert.ToInt32(bolunmus[5]) == 0)
                {
                    if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (Convert.ToInt32(bolunmus[2]) > x && x > Convert.ToInt32(bolunmus[0]) && Convert.ToInt32(bolunmus[3]) > y && y > Convert.ToInt32(bolunmus[1]))
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (Convert.ToInt32(bolunmus[2]) > x && x > Convert.ToInt32(bolunmus[0]) && Convert.ToInt32(bolunmus[1]) > y && y > Convert.ToInt32(bolunmus[3]))
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (Convert.ToInt32(bolunmus[0]) > x && x > Convert.ToInt32(bolunmus[2]) && Convert.ToInt32(bolunmus[3]) > y && y > Convert.ToInt32(bolunmus[1]))
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (Convert.ToInt32(bolunmus[0]) > x && x > Convert.ToInt32(bolunmus[2]) && Convert.ToInt32(bolunmus[1]) > y && y > Convert.ToInt32(bolunmus[3]))
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 1)
                {
                    if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (c > x && x > a && d > y && y > b)
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (c > x && x > a && d > y && y > b)
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (a > x && x > c && b > y && y > d)
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (a > x && x > c && b > y && y > d)
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 2)
                {
                    if (x1 < x2)
                    {
                        if (x1 - (x2 - x1) < x && x < x1 + (x2 - x1) && y1 - (x2 - x1) < y && y < y1 + (x2 - x1))
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                    else
                    {
                        if (x1 + (x2 - x1) < x && x < (x1 - (x2 - x1)) && y1 + (x2 - x1) < y && y < y1 - (x2 - x1))
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 3)
                {
                    if (x1 < x2)
                    {
                        if (x1 - (x2 - x1) < x && x < x1 + (x2 - x1) && y1 - (x2 - x1) < y && y < y1 + (x2 - x1))
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                    else
                    {
                        if (x1 + (x2 - x1) < x && x < x1 - (x2 - x1) && y1 + (x2 - x1) < y && y < y1 - (x2 - x1))
                        {
                            sw.WriteLine("{0} {1} {2} {3} {4} {5}", bolunmus[0], bolunmus[1], bolunmus[2], bolunmus[3], renk, bolunmus[5]); kontrol = true;
                        }
                    }
                }
                if (kontrol == false) sw.WriteLine(yazi);
            }
            sr.Close(); fs.Close();
            sw.Flush(); sw.Close(); fs2.Close();
            File.Delete(Application.StartupPath.ToString() + "\\tmp.txt");
            File.Move(Application.StartupPath.ToString() + "\\tmp2.txt", Application.StartupPath.ToString() + "\\tmp.txt");
            Graphics formGrafik = cizimYeri.CreateGraphics(); formGrafik.Clear(Color.White);
            geciciDosyadanCiz(cizimYeri, true);
        }

        public static void secileniSil(Panel cizimYeri, int x, int y)
        {
            FileStream fs = new FileStream(Application.StartupPath.ToString() + "\\tmp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream fs2 = new FileStream(Application.StartupPath.ToString() + "\\tmp2.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs2);
            for (; ; )
            {
                bool kontrol = false;
                string yazi;
                string[] bolunmus = new string[6];
                yazi = sr.ReadLine();
                if (yazi == null) break;
                bolunmus = yazi.Split(' ');
                int x1 = Convert.ToInt32(bolunmus[0]), y1 = Convert.ToInt32(bolunmus[1]), x2 = Convert.ToInt32(bolunmus[2]), y2 = Convert.ToInt32(bolunmus[2]);
                int a = x1 - ((2 * x2 - 2 * x1) / 2), b = y1 - ((2 * x2 - 2 * x1) / 2), c = (x1 - ((2 * x2 - 2 * x1) / 2)) + 2 * x2 - 2 * x1, d = (y1 - ((2 * x2 - 2 * x1) / 2)) + 2 * x2 - 2 * x1;
                if (Convert.ToInt32(bolunmus[5]) == 0)
                {
                    if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (Convert.ToInt32(bolunmus[2]) > x && x > Convert.ToInt32(bolunmus[0]) && Convert.ToInt32(bolunmus[3]) > y && y > Convert.ToInt32(bolunmus[1]))
                        {
                            kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (Convert.ToInt32(bolunmus[2]) > x && x > Convert.ToInt32(bolunmus[0]) && Convert.ToInt32(bolunmus[1]) > y && y > Convert.ToInt32(bolunmus[3]))
                        {
                            kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (Convert.ToInt32(bolunmus[0]) > x && x > Convert.ToInt32(bolunmus[2]) && Convert.ToInt32(bolunmus[3]) > y && y > Convert.ToInt32(bolunmus[1]))
                        {
                            kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (Convert.ToInt32(bolunmus[0]) > x && x > Convert.ToInt32(bolunmus[2]) && Convert.ToInt32(bolunmus[1]) > y && y > Convert.ToInt32(bolunmus[3]))
                        {
                            kontrol = true;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 1)
                {
                    if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (c > x && x > a && d > y && y > b)
                        {
                            kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) >= 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (c > x && x > a && d > y && y > b)
                        {
                            kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) >= 0)
                    {
                        if (a > x && x > c && b > y && y > d)
                        {
                            kontrol = true;
                        }
                    }
                    else if (Convert.ToInt32(bolunmus[2]) - Convert.ToInt32(bolunmus[0]) < 0 && Convert.ToInt32(bolunmus[3]) - Convert.ToInt32(bolunmus[1]) < 0)
                    {
                        if (a > x && x > c && b > y && y > d)
                        {
                            kontrol = true;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 2)
                {
                    if (x1 < x2)
                    {
                        if (x1 - (x2 - x1) < x && x < x1 + (x2 - x1) && y1 - (x2 - x1) < y && y < y1 + (x2 - x1))
                        {
                            kontrol = true;
                        }
                    }
                    else
                    {
                        if (x1 + (x2 - x1) < x && x < (x1 - (x2 - x1)) && y1 + (x2 - x1) < y && y < y1 - (x2 - x1))
                        {
                            kontrol = true;
                        }
                    }
                }
                else if (Convert.ToInt32(bolunmus[5]) == 3)
                {
                    if (x1 < x2)
                    {
                        if (x1 - (x2 - x1) < x && x < x1 + (x2 - x1) && y1 - (x2 - x1) < y && y < y1 + (x2 - x1))
                        {
                            kontrol = true;
                        }
                    }
                    else
                    {
                        if (x1 + (x2 - x1) < x && x < x1 - (x2 - x1) && y1 + (x2 - x1) < y && y < y1 - (x2 - x1))
                        {
                            kontrol = true;
                        }
                    }
                }
                if (kontrol == false) sw.WriteLine(yazi);
            }
            sr.Close(); fs.Close();
            sw.Flush(); sw.Close(); fs2.Close();
            File.Delete(Application.StartupPath.ToString() + "\\tmp.txt");
            File.Move(Application.StartupPath.ToString() + "\\tmp2.txt", Application.StartupPath.ToString() + "\\tmp.txt");
            Graphics formGrafik = cizimYeri.CreateGraphics(); formGrafik.Clear(Color.White);
            geciciDosyadanCiz(cizimYeri, true);
        }
    }
}
