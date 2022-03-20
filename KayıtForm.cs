using __;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakip
{
    public partial class KayıtForm : Form
    {
        public KayıtForm()
        {
            InitializeComponent();
        }
        int /*delta = 0*/ x, y, z;
        
        private void KayıtForm_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Msmodu_Click(object sender, EventArgs e)
        {
            bool af = Admin.PlakaKontrol(plaka, errorProvider1);
            bool fa = Textbox.HepsiYazılmışMı(Controls, msmodu, errorProvider1);
            if (!af || !fa) return;

            string filetxt = File.ReadAllText(Application.StartupPath + Admin.araclartxtkonum);
            var ars = Json.Read(filetxt);
            ars.Araclar.Add(
                new Araç
                {
                    Marka = marka.Text,
                    Model = model.Text,
                    Plaka = plaka.Text,
                    Renk = renk.Text
                }
            );

            File.WriteAllText(
                Application.StartupPath + Admin.araclartxtkonum,
                Json.Create(ars)
                );

            //runPython.CreateAndRun(
            //    Scripts.ListDump,
            //    Application.StartupPath + Admin.araclartxtkonum
            //    );

            Textbox.Temizle(Controls,
                ref cmd);
            MessageBox.Show("Kayıt İşlemi Tamamlandı !");
            Close();
        }
        bool cmd = true;
        private void TextBox3_TextChanged(object sender, EventArgs e) => Textbox3Ac();

        void Textbox3Ac()
        {
            if (renk.Text.Length < 2 && cmd)
            {
                cmd = true;
                contextMenuStrip1.Show(renk, 5, 5);
            }
        }
        private void BaşkaBirRenkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd = false;
            renk.Text = "";
        }

        private void MorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            string text = toolStripMenuItem.Text;
            renk.Text = text;
        }

        private void TextBox3_MouseClick(
            object sender,
            MouseEventArgs e)
        {
            contextMenuStrip1.Show(renk, 5, 5);
        }

        readonly Random rnd = new Random();
        readonly List<string> ornekaraclar = new List<string> { "Mercedes", "Opel", "Renault", "Tesla", "Mitsubishi", "Fiat", "Toyota", "Honda", "Dacia", "Wolkswagen" };
        readonly List<string> ornekmodeller = new List<string> { "Benz", "Astra", "Fluance", "Model X", "L 200", "Egea", "Corolla", "Civic", "Duster", "Passat" };
        readonly List<string> renkler = new List<string> { "Kırmızı", "Sarı", "Beyaz", "Kahverengi", "Gumus Gri", "Siyah", "Turuncu", "Pembe", "Mor", "Lacivert" };

        async void RandomDoldur()
        {
            Textbox.Temizle(Controls, ref cmd);
            await Task.Run(() =>
            {
                
                button1.Enabled = false;
                for (int i = 0; i < rnd.Next(5); i++)
                {
                    plaka.Text = String.Format("{0} TR {1}", rnd.Next(1, 82), rnd.Next(500));
                    Thread.Sleep(33);
                }
                for (int i = 0; i < 10; i++)
                {
                    int markarnd = rnd.Next(0, 10);
                    marka.Text = ornekaraclar[markarnd];
                    model.Text = ornekmodeller[markarnd];
                    Thread.Sleep(33);
                }
                for (int i = 0; i < 20; i++)
                {
                    renk.Text = renkler[rnd.Next(0, 10)];
                    Thread.Sleep(33);
                }
                button1.Enabled = true;
            });
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            RandomDoldur();

        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    Araçlar universiteOgrencileri = new Araçlar
        //    {
        //        Author = Admin.Author
        //    };

        //    List<Araç> p = new List<Araç>();
        //    Araç ogrenci1 = new Araç { Marka = "Şafak" };
        //    Araç ogrenci2 = new Araç { Marka = "Dilara" };
        //    Araç ogrenci3 = new Araç { Marka = "Can" };

        //    p.Add(ogrenci1);
        //    p.Add(ogrenci2);
        //    p.Add(ogrenci3);
        //    universiteOgrencileri.Araclar = p;
        //    string json = JsonConvert.SerializeObject(universiteOgrencileri);
        //    Clipboard.SetText(json);
        //    MessageBox.Show(json);

        //}

        private void LabelRenkDegisme()
        {
            //if (delta == 9)
            //{
            Admin.XYZAyarla(ref x, ref y, ref z);
            label5.ForeColor = Color.FromArgb(x, y, z);
            //delta = 0;
            //}
            //delta++;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabelRenkDegisme();
        }
    }
}
