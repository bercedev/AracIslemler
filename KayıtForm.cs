using System;
using System.Drawing;
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
            if (true)
            {

            }

            foreach (var item in Controls)
            {
                if (item is TextBox box)
                {
                    box.Text = "";
                }
            }
        }
        bool cmd = true;
        private void TextBox3_TextChanged(object sender, EventArgs e) => Textbox3Ac();

        void Textbox3Ac()
        {
            if (textBox3.Text.Length < 2 && cmd)
            {
                cmd = true;
                contextMenuStrip1.Show(textBox3, 5, 5);
            }
        }
        private void BaşkaBirRenkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd = false;
            textBox3.Text = "";
        }

        private void MorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            string text = toolStripMenuItem.Text;
            textBox3.Text = text;
        }

        private void TextBox3_MouseClick(
            object sender,
            MouseEventArgs e)
        {
             contextMenuStrip1.Show(textBox3, 5, 5);
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
