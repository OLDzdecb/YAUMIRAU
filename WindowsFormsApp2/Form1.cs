using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void сложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sloj = new Form2();
            sloj.Show();
        }

        private void вычитаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vich = new Form3();
            vich.Show();
        }

        private void умножениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form umnoj = new Form4();
            umnoj.Show();
        }

        private void делениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form del = new Form5();
            del.Show();
        }
        private void модульКвадратКореньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mod = new Form6();
            mod.Show();

        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form na2 = new Form7();
            na2.Show();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form na3 = new Form8();
            na3.Show();
        }
    }
}
