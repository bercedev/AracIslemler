using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using __;

namespace AracTakip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int /*delta = 0*/ x, y, z;

        private void Button1_Click(object sender, EventArgs e)
        {
            Form frm = new KayıtForm();
            frm.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabelRenkDegisme();
        }

        private void Msmodu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            if (menuStrip1.Visible)
            {
                Admin.ÖğeTaşı(
                    label1,
                    25,
                    menuStrip1,
                    false
                    );
                Admin.ÖğeTaşı2(
                    msmodu,
                    179,
                    new List<IWin32Window> { button1, button2, button3 },
                    true
                    );
                exit.Location = new Point(326, 12);
                msmodu.Text = "MenuStrip Moduna Geç";
            }
            else
            {
                Admin.ÖğeTaşı(
                    label1,
                    89, 
                    menuStrip1
                    );
                Admin.ÖğeTaşı2(
                    msmodu,
                    129,
                    new List<IWin32Window> { button1, button2, button3 },
                    false
                    );
                exit.Location = new Point(326, 187);
                msmodu.Text = "Button Moduna Geç";
            }
        }

        private void LabelRenkDegisme()
        {
            //if (delta == 9)
            //{
            Admin.XYZAyarla(ref x, ref y, ref z);
            label1.ForeColor = Color.FromArgb(x, y, z);
            //delta = 0;
            //}
            //delta++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form frm = new YakıtVerForm();
            frm.ShowDialog();
        }

 
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form frm = new KayıtForm();
            frm.ShowDialog();
        }

        //public static void ButtonGizle(Control.ControlCollection Controls)
        //{

        //}
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
