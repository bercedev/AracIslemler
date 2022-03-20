using System;
using System.Collections.Generic;
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
        private void Msmodu_Click(object sender, EventArgs e)
        {
            bool af = Admin.PlakaKontrol(plaka, errorProvider1);
            if (tutar.Text == "") af = false;
            if (!af) return;

            Out @out = new Out { Date = dateTimePicker1.Text, Plaka = plaka.Text, Tutar = double.Parse(tutar.Text) };



            Textbox.Temizle(Controls, ref cmd);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");
            MessageBox.Show(numbers.Dequeue());
        }
    }
}
