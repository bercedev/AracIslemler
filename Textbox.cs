using System.Windows.Forms;

namespace AracTakip
{
    internal static class Textbox
    {

        public static void Temizle(Control.ControlCollection Controls, ref bool cmd)
        {
            foreach (var item in Controls)
            {
                if (item is TextBox box)
                {
                    box.Text = "";
                }
            }

            cmd = false;
        }

        public static bool HepsiYazılmışMı(Control.ControlCollection Controls,Control control1, ErrorProvider errorProvider1)
        {
            foreach (var item in Controls)
            {
                if (item is TextBox box && box.Text == "")
                {
                    errorProvider1.SetError(control1, "Lütfen tüm boş alanları doldurun!");
                    return false;
                }
            }
            return true;
        }
    }
}