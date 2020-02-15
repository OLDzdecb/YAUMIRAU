using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (a < 0)
            {
                a = -a;
            }
            label1.Text = Convert.ToString(a);
            textBox1.Text = "";
            string text = label1.Text;
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            using (FileStream fstream = new FileStream(@"D:\SomeDir\mod.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            a = a*a;
            textBox1.Text = "";
            label1.Text = Convert.ToString(a);
            string text = label1.Text;
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            using (FileStream fstream = new FileStream(@"D:\SomeDir\kvadr.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text);
            a = Math.Sqrt(a);
            textBox1.Text = "";
            label1.Text = Convert.ToString(a);
            string text = label1.Text;
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            using (FileStream fstream = new FileStream(@"D:\SomeDir\koren.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
