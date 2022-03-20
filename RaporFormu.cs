using __;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AracTakip
{
    public partial class RaporFormu : Form
    {
        public RaporFormu()
        {
            InitializeComponent();
        }
        private readonly string araclarJsonLocation = $"{Application.StartupPath}{Admin.araclarjsonkonum}";
        private readonly string hareketJsonLocation = $"{Application.StartupPath}{Admin.hareketjsonkonum}";

        private void RaporFormu_Load(object sender, EventArgs e)
        {
            Admin.PlakalarıGetir(plaka, araclarJsonLocation);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        int x, y, z;

        private void Msmodu_Click(object sender, EventArgs e)
        {
            string filetxt = File.ReadAllText(hareketJsonLocation);
            var js = Json.ReadAndReturnOuts(filetxt);
            bindingSource1.DataSource = js.OutList;
            dataGridView1.DataSource = bindingSource1;
        }

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
