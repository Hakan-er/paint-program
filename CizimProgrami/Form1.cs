using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CizimProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Kontrol.Sec == true)
                Kontrol.secimYap(panel1, e.X, e.Y);
            else
                Kontrol.cizBasildi(e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Kontrol.Sec == false)
                Kontrol.cizBirakildi(e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Kontrol.Sec == false)
            {
                Cizim.ciz(Kontrol.Ciz, panel1, Kontrol.Sekil, Kontrol.Renk, Kontrol.BaslangicX, Kontrol.BaslangicY, e.X, e.Y);
                if (Kontrol.Ciz)
                    Dosyalama.geciciDosyadanCiz(panel1, Kontrol.IlkSekilCizildi);
            }
        }
        
        private void butonTik(object sender, EventArgs e)
        {
            Graphics formGrafik = panel1.CreateGraphics();
            if (sender == button1) { Kontrol.sekilSec(0);formGrafik.Clear(Color.White);Dosyalama.geciciDosyadanCiz(panel1, Kontrol.IlkSekilCizildi); if (Kontrol.Sec) Kontrol.secBirakildi(); panel2.BackColor = Color.Gold; panel3.BackColor = SystemColors.Control; panel4.BackColor = SystemColors.Control; panel5.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control;  }
            else if (sender == button2) { Kontrol.sekilSec(1); formGrafik.Clear(Color.White); Dosyalama.geciciDosyadanCiz(panel1, Kontrol.IlkSekilCizildi); if (Kontrol.Sec) Kontrol.secBirakildi(); panel2.BackColor = SystemColors.Control; panel3.BackColor = Color.Gold; panel4.BackColor = SystemColors.Control; panel5.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control;  }
            else if (sender == button3) { Kontrol.sekilSec(2); formGrafik.Clear(Color.White); Dosyalama.geciciDosyadanCiz(panel1, Kontrol.IlkSekilCizildi); if (Kontrol.Sec) Kontrol.secBirakildi(); panel2.BackColor = SystemColors.Control; panel3.BackColor = SystemColors.Control; panel4.BackColor = Color.Gold; panel5.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control;  }
            else if (sender == button4) { Kontrol.sekilSec(3); formGrafik.Clear(Color.White); Dosyalama.geciciDosyadanCiz(panel1, Kontrol.IlkSekilCizildi); if (Kontrol.Sec) Kontrol.secBirakildi(); panel2.BackColor = SystemColors.Control; panel3.BackColor = SystemColors.Control; panel4.BackColor = SystemColors.Control; panel5.BackColor = Color.Gold; panel15.BackColor = SystemColors.Control;  }
            else if (sender == button5) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.Cyan, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.Cyan); Kontrol.secBirakildi(); panel6.BackColor = Color.Pink; panel7.BackColor = SystemColors.Control; panel8.BackColor = SystemColors.Control; panel9.BackColor = SystemColors.Control; panel10.BackColor = SystemColors.Control; panel11.BackColor = SystemColors.Control; panel12.BackColor = SystemColors.Control; panel13.BackColor = SystemColors.Control; panel14.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control; }
            else if (sender == button6) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.LightGray, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.LightGray); Kontrol.secBirakildi(); panel6.BackColor = SystemColors.Control; panel7.BackColor = Color.Pink; panel8.BackColor = SystemColors.Control; panel9.BackColor = SystemColors.Control; panel10.BackColor = SystemColors.Control; panel11.BackColor = SystemColors.Control; panel12.BackColor = SystemColors.Control; panel13.BackColor = SystemColors.Control; panel14.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control; }
            else if (sender == button7) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.Yellow, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.Yellow); Kontrol.secBirakildi(); panel6.BackColor = SystemColors.Control; panel7.BackColor = SystemColors.Control; panel8.BackColor = Color.Pink; panel9.BackColor = SystemColors.Control; panel10.BackColor = SystemColors.Control; panel11.BackColor = SystemColors.Control; panel12.BackColor = SystemColors.Control; panel13.BackColor = SystemColors.Control; panel14.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control; }
            else if (sender == button8) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.Blue, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.Blue); Kontrol.secBirakildi(); panel6.BackColor = SystemColors.Control; panel7.BackColor = SystemColors.Control; panel8.BackColor = SystemColors.Control; panel9.BackColor = Color.Pink; panel10.BackColor = SystemColors.Control; panel11.BackColor = SystemColors.Control; panel12.BackColor = SystemColors.Control; panel13.BackColor = SystemColors.Control; panel14.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control; }
            else if (sender == button9) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.Red, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.Red); Kontrol.secBirakildi(); panel6.BackColor = SystemColors.Control; panel7.BackColor = SystemColors.Control; panel8.BackColor = SystemColors.Control; panel9.BackColor = SystemColors.Control; panel10.BackColor = Color.Pink; panel11.BackColor = SystemColors.Control; panel12.BackColor = SystemColors.Control; panel13.BackColor = SystemColors.Control; panel14.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control; }
            else if (sender == button10) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.Green, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.Green); Kontrol.secBirakildi(); panel6.BackColor = SystemColors.Control; panel7.BackColor = SystemColors.Control; panel8.BackColor = SystemColors.Control; panel9.BackColor = SystemColors.Control; panel10.BackColor = SystemColors.Control; panel11.BackColor = Color.Pink; panel12.BackColor = SystemColors.Control; panel13.BackColor = SystemColors.Control; panel14.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control; }
            else if (sender == button11) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.Purple, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.Purple); Kontrol.secBirakildi(); panel6.BackColor = SystemColors.Control; panel7.BackColor = SystemColors.Control; panel8.BackColor = SystemColors.Control; panel9.BackColor = SystemColors.Control; panel10.BackColor = SystemColors.Control; panel11.BackColor = SystemColors.Control; panel12.BackColor = Color.Pink; panel13.BackColor = SystemColors.Control; panel14.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control; }
            else if (sender == button12) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.Orange, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.Orange); Kontrol.secBirakildi(); panel6.BackColor = SystemColors.Control; panel7.BackColor = SystemColors.Control; panel8.BackColor = SystemColors.Control; panel9.BackColor = SystemColors.Control; panel10.BackColor = SystemColors.Control; panel11.BackColor = SystemColors.Control; panel12.BackColor = SystemColors.Control; panel13.BackColor = Color.Pink; panel14.BackColor = SystemColors.Control; panel15.BackColor = SystemColors.Control; }
            else if (sender == button13) { if (Kontrol.Sec == true) Dosyalama.renkDegistir(panel1, Color.Brown, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.renkSec(Color.Brown); Kontrol.secBirakildi(); panel6.BackColor = SystemColors.Control; panel7.BackColor = SystemColors.Control; panel8.BackColor = SystemColors.Control; panel9.BackColor = SystemColors.Control; panel10.BackColor = SystemColors.Control; panel11.BackColor = SystemColors.Control; panel12.BackColor = SystemColors.Control; panel13.BackColor = SystemColors.Control; panel14.BackColor = Color.Pink; panel15.BackColor = SystemColors.Control; }
            else if (sender == button14) { Kontrol.secBasildi(); panel2.BackColor = SystemColors.Control; panel3.BackColor = SystemColors.Control; panel4.BackColor = SystemColors.Control; panel5.BackColor = SystemColors.Control; panel15.BackColor = Color.Gold; }
            else if (sender == button15) { Dosyalama.secileniSil(panel1, Kontrol.SecilenX, Kontrol.SecilenY); Kontrol.secBirakildi(); panel15.BackColor = SystemColors.Control; }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SaveFileDialog kayit = new SaveFileDialog();
            kayit.Filter = "Metin Dosyası|*.txt";
            if (kayit.ShowDialog() == DialogResult.OK)
            {
                Dosyalama.kayit(kayit);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Metin Dosyası|*.txt";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                Dosyalama.dosyaAc(dosya, panel1);
                Dosyalama.geciciDosyadanCiz(panel1, true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(Application.StartupPath.ToString() + "\\tmp.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
