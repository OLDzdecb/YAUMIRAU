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
    public partial class Form7 : Form
    {
        int[] a = new int[4];
        int[] b = new int[4];
        int[] c = new int[4];
        public Form7()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            a[0] = Convert.ToInt32(textBox1.Text);
            a[1] = Convert.ToInt32(textBox2.Text);
            a[2] = Convert.ToInt32(textBox3.Text);
            a[3] = Convert.ToInt32(textBox4.Text);
            b[0] = Convert.ToInt32(textBox5.Text);
            b[1] = Convert.ToInt32(textBox6.Text);
            b[2] = Convert.ToInt32(textBox7.Text);
            b[3] = Convert.ToInt32(textBox8.Text);
            int i = 0;
            for (i = 0; i < 4; i++)
            {
                a[i] = a[i] + b[i];
            }
            label1.Text = Convert.ToString(a[0]);
            label2.Text = Convert.ToString(a[1]);
            label3.Text = Convert.ToString(a[2]);
            label4.Text = Convert.ToString(a[3]);
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            string text1 = label1.Text;
            string text2 = label2.Text;
            string text3 = label3.Text;
            string text4 = label4.Text;
           text1 = "  " + text1;
            text2 = "  " + text2;
            text3 = "  " + text3 + "\n";
            text4 = "  " + text4;
            using (FileStream fstream = new FileStream(@"D:\SomeDir\matrix2sloj.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text1);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text2);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text3);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text4);
                fstream.Write(array, 0, array.Length);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a[0] = Convert.ToInt32(textBox1.Text);
            a[1] = Convert.ToInt32(textBox2.Text);
            a[2] = Convert.ToInt32(textBox3.Text);
            a[3] = Convert.ToInt32(textBox4.Text);
            b[0] = Convert.ToInt32(textBox5.Text);
            b[1] = Convert.ToInt32(textBox6.Text);
            b[2] = Convert.ToInt32(textBox7.Text);
            b[3] = Convert.ToInt32(textBox8.Text);
            int i;
            for (i = 0; i < 4; i++)
            {
                a[i] = a[i] - b[i];
            }
            label1.Text = Convert.ToString(a[0]);
            label2.Text = Convert.ToString(a[1]);
            label3.Text = Convert.ToString(a[2]);
            label4.Text = Convert.ToString(a[3]);
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            string text1 = label1.Text;
            string text2 = label2.Text;
            string text3 = label3.Text;
            string text4 = label4.Text;
            text1 = "  " + text1;
            text2 = "  " + text2;
            text3 = "  " + text3 + "\n";
            text4 = "  " + text4;
            using (FileStream fstream = new FileStream(@"D:\SomeDir\matrix2minus.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text1);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text2);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text3);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text4);
                fstream.Write(array, 0, array.Length);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            a[0] = Convert.ToInt32(textBox1.Text);
            a[1] = Convert.ToInt32(textBox2.Text);
            a[2] = Convert.ToInt32(textBox3.Text);
            a[3] = Convert.ToInt32(textBox4.Text);
            b[0] = Convert.ToInt32(textBox5.Text);
            b[1] = Convert.ToInt32(textBox6.Text);
            b[2] = Convert.ToInt32(textBox7.Text);
            b[3] = Convert.ToInt32(textBox8.Text);
            c[0] = a[0] * b[0] + a[1] * b[2];
            c[1] = a[0] * b[1] + a[1] * b[3];
            c[2] = a[2] * b[0] + a[3] * b[2];
            c[3] = a[2] * b[1] + a[3] * b[3];
            label1.Text = Convert.ToString(c[0]);
            label2.Text = Convert.ToString(c[1]);
            label3.Text = Convert.ToString(c[2]);
            label4.Text = Convert.ToString(c[3]);
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            string text1 = label1.Text;
            string text2 = label2.Text;
            string text3 = label3.Text;
            string text4 = label4.Text;
            text1 = "  " + text1;
            text2 = "  " + text2;
            text3 = "  " + text3 + "\n";
            text4 = "  " + text4;
            using (FileStream fstream = new FileStream(@"D:\SomeDir\matrix2umnoj.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text1);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text2);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text3);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text4);
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}
