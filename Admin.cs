using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakip
{
    internal class Admin
    {
        public string apath = Application.StartupPath;
        public const string araclartxtkonum = "\\araclar.json";


        internal static bool PlakaKontrol(TextBox plaka, ErrorProvider errorProvider1)
        {
            try
            {
                int.Parse(plaka.Text.Substring(0, 1));
                errorProvider1.Clear();
                return true;
            }
            catch (Exception)
            {
                errorProvider1.SetError(plaka, "Plakayı yanlış yazdınız?");
                return false;
            }

        }

        internal static void XYZAyarla(ref int x, ref int y, ref int z)
        {
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
        }
        public static async void ÖğeTaşı(Control control, int newY, IWin32Window gizlenecekoge = default, bool visible = true)
        {
            //
            // Mustafa Dişbudak
            Control gizlenecek = ConvertToControl(gizlenecekoge);
            // tarafından
            //
            int eskiY = control.Location.Y;
            int foruzunlugu = (eskiY > newY) ? eskiY - newY : newY - eskiY;
            bool yukari = (eskiY > newY);
            if (!visible) gizlenecek.Visible = visible; // Gizlenecekse güzel görünüm için önceden gizle
            for (int i = 0; i < foruzunlugu; i++)
            {
                _ = yukari ? eskiY-- : eskiY++;
                control.Location = new Point(control.Location.X, eskiY);
                await Task.Run(() => { Thread.Sleep(10); });
            }
            if (gizlenecek != default) gizlenecek.Visible = visible; // Gösterilecekse hareket bittikten sonra göster.
        }
        public static async void ÖğeTaşı2(Control control, int newY, List<IWin32Window> gizlenecekogeler = default, bool visible = true)
        {
            //
            // Mustafa Dişbudak
            //
            //
            int eskiY = control.Location.Y;
            int foruzunlugu = (eskiY > newY) ? eskiY - newY : newY - eskiY;
            bool yukari = (eskiY > newY);

            if (!visible)  // Gizlenecekse hareket başlamadan önce göster.
                foreach (var gizlenecekoge in gizlenecekogeler)
                {
                    Control gizlenecek = ConvertToControl(gizlenecekoge);
                    if (gizlenecek != default) gizlenecek.Visible = visible;
                }// Gizlenecekse güzel görünüm için önceden gizle

            //
            // HAREKET KISMI
            //
            for (int i = 0; i < foruzunlugu; i++)
            {
                _ = yukari ? eskiY-- : eskiY++;
                control.Location = new Point(control.Location.X, eskiY);
                await Task.Run(() => { Thread.Sleep(4); });
            }
            //
            // HAREKET KISMI
            //

            if (visible)  // Gösterilecekse hareket bittikten sonra göster.
                foreach (var gizlenecekoge in gizlenecekogeler)
                {

                    Control gizlenecek = ConvertToControl(gizlenecekoge);
                    if (gizlenecek != default) gizlenecek.Visible = visible; // Gösterilecekse hareket bittikten sonra göster.

                }
            //
            // tarafından
            //

        }
        private static Control ConvertToControl(IWin32Window win)
        {           // BU KISIM İNTERNETTEN ALINDI  //
            if (!(win is Control))
            {
                return default;
            }
            return (Control)win;
        }           // BU KISIM İNTERNETTEN ALINDI  //

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public const string Author = "Mustafa Dişbudak";
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
