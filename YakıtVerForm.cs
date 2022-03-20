using __;
using System;
using System.IO;
using System.Windows.Forms;

namespace AracTakip
{
    public partial class YakıtVerForm : Form
    {
        public YakıtVerForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool cmd = false;
        private readonly string araclarJsonLocation = $"{Application.StartupPath}{Admin.araclarjsonkonum}";

        private void Msmodu_Click(object sender, EventArgs e)
        {
            bool af = Admin.PlakaKontrol(plaka, errorProvider1);
            if (tutar.Text == "") af = false;
            if (!af) return;

            Out @out = new Out { Date = dateTimePicker1.Text, Plaka = plaka.Text, Tutar = double.Parse(tutar.Text) };


            Json.AllSteps JAllSteps = new Json.AllSteps()
            {
                JsonFileName = Admin.hareketjsonkonum,
                StartupPath = Application.StartupPath,
                JsonaEklenecekClass = @out
            };

            JAllSteps.RunAndAddOut();


            Textbox.Temizle(Controls, ref cmd);
            MessageBox.Show("Bilgi","Yakıt Verme Kayıtları Başarıyla Gerçekleşti",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void YakıtVerForm_Load(object sender, EventArgs e)
        {
            Admin.PlakalarıGetir(plaka,araclarJsonLocation);
        }
    }
}
