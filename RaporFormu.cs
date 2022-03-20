using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void RaporFormu_Load(object sender, EventArgs e)
        {
            Admin.PlakalarıGetir(plaka, araclarJsonLocation);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
