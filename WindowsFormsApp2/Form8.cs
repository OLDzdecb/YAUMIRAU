using System;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form8 : Form
    {
        int[] a = new int[9];
        int[] b = new int[9];
        int[] c = new int[9];
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a[0] = Convert.ToInt32(textBox1.Text);
            a[1] = Convert.ToInt32(textBox2.Text);
            a[2] = Convert.ToInt32(textBox3.Text);
            a[3] = Convert.ToInt32(textBox4.Text);
            a[4] = Convert.ToInt32(textBox5.Text);
            a[5] = Convert.ToInt32(textBox6.Text);
            a[6] = Convert.ToInt32(textBox7.Text);
            a[7] = Convert.ToInt32(textBox8.Text);
            a[8] = Convert.ToInt32(textBox9.Text);
            b[0] = Convert.ToInt32(textBox10.Text);
            b[1] = Convert.ToInt32(textBox11.Text);
            b[2] = Convert.ToInt32(textBox12.Text);
            b[3] = Convert.ToInt32(textBox13.Text);
            b[4] = Convert.ToInt32(textBox14.Text);
            b[5] = Convert.ToInt32(textBox15.Text);
            b[6] = Convert.ToInt32(textBox16.Text);
            b[7] = Convert.ToInt32(textBox17.Text);
            b[8] = Convert.ToInt32(textBox18.Text);
            int i = 0;
            for (i = 0; i < 9; i++)
            {
                a[i] = a[i] + b[i];
            }
            label1.Text = Convert.ToString(a[0]);
            label2.Text = Convert.ToString(a[1]);
            label3.Text = Convert.ToString(a[2]);
            label4.Text = Convert.ToString(a[3]);
            label5.Text = Convert.ToString(a[4]);
            label6.Text = Convert.ToString(a[5]);
            label7.Text = Convert.ToString(a[6]);
            label8.Text = Convert.ToString(a[7]);
            label9.Text = Convert.ToString(a[8]);
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
            string text5 = label5.Text;
            string text6 = label6.Text;
            string text7 = label7.Text;
            string text8 = label8.Text;
            string text9 = label9.Text;
            text1 = "  " + text1;
            text2 = "  " + text2;
            text3 = "  " + text3 + "\n";
            text4 = "  " + text4;
            text5 = "  " + text5;
            text6 = "  " + text6 + "\n";
            text7 = "  " + text7;
            text8 = "  " + text8;
            text9 = "  " + text9 + "\n";
            using (FileStream fstream = new FileStream(@"D:\SomeDir\matrix3sum.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text1);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text2);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text3);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text4);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text5);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text6);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text7);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text8);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text9);
                fstream.Write(array, 0, array.Length);

            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a[0] = Convert.ToInt32(textBox1.Text);
            a[1] = Convert.ToInt32(textBox2.Text);
            a[2] = Convert.ToInt32(textBox3.Text);
            a[3] = Convert.ToInt32(textBox4.Text);
            a[4] = Convert.ToInt32(textBox5.Text);
            a[5] = Convert.ToInt32(textBox6.Text);
            a[6] = Convert.ToInt32(textBox7.Text);
            a[7] = Convert.ToInt32(textBox8.Text);
            a[8] = Convert.ToInt32(textBox9.Text);
            b[0] = Convert.ToInt32(textBox10.Text);
            b[1] = Convert.ToInt32(textBox11.Text);
            b[2] = Convert.ToInt32(textBox12.Text);
            b[3] = Convert.ToInt32(textBox13.Text);
            b[4] = Convert.ToInt32(textBox14.Text);
            b[5] = Convert.ToInt32(textBox15.Text);
            b[6] = Convert.ToInt32(textBox16.Text);
            b[7] = Convert.ToInt32(textBox17.Text);
            b[8] = Convert.ToInt32(textBox18.Text);
            int i = 0;
            for (i = 0; i < 9; i++)
            {
                a[i] = a[i] - b[i];
            }
            label1.Text = Convert.ToString(a[0]);
            label2.Text = Convert.ToString(a[1]);
            label3.Text = Convert.ToString(a[2]);
            label4.Text = Convert.ToString(a[3]);
            label5.Text = Convert.ToString(a[4]);
            label6.Text = Convert.ToString(a[5]);
            label7.Text = Convert.ToString(a[6]);
            label8.Text = Convert.ToString(a[7]);
            label9.Text = Convert.ToString(a[8]);
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
            string text5 = label5.Text;
            string text6 = label6.Text;
            string text7 = label7.Text;
            string text8 = label8.Text;
            string text9 = label9.Text;
            text1 = "  " + text1;
            text2 = "  " + text2;
            text3 = "  " + text3 + "\n";
            text4 = "  " + text4;
            text5 = "  " + text5;
            text6 = "  " + text6 + "\n";
            text7 = "  " + text7;
            text8 = "  " + text8;
            text9 = "  " + text9 + "\n";
            using (FileStream fstream = new FileStream(@"D:\SomeDir\matrix3minus.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text1);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text2);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text3);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text4);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text5);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text6);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text7);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text8);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text9);
                fstream.Write(array, 0, array.Length);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a[0] = Convert.ToInt32(textBox1.Text);
            a[1] = Convert.ToInt32(textBox2.Text);
            a[2] = Convert.ToInt32(textBox3.Text);
            a[3] = Convert.ToInt32(textBox4.Text);
            a[4] = Convert.ToInt32(textBox5.Text);
            a[5] = Convert.ToInt32(textBox6.Text);
            a[6] = Convert.ToInt32(textBox7.Text);
            a[7] = Convert.ToInt32(textBox8.Text);
            a[8] = Convert.ToInt32(textBox9.Text);
            b[0] = Convert.ToInt32(textBox10.Text);
            b[1] = Convert.ToInt32(textBox11.Text);
            b[2] = Convert.ToInt32(textBox12.Text);
            b[3] = Convert.ToInt32(textBox13.Text);
            b[4] = Convert.ToInt32(textBox14.Text);
            b[5] = Convert.ToInt32(textBox15.Text);
            b[6] = Convert.ToInt32(textBox16.Text);
            b[7] = Convert.ToInt32(textBox17.Text);
            b[8] = Convert.ToInt32(textBox18.Text);
            c[0] = a[0] * b[0] + a[1] * b[3] + a[2] * b[6];
            c[1] = a[0] * b[1] + a[1] * b[4] + a[2] * b[7];
            c[2] = a[0] * b[2] + a[1] * b[5] + a[2] * b[8];
            c[3] = a[2] * b[0] + a[3] * b[3] + a[4] * b[6];
            c[4] = a[2] * b[1] + a[3] * b[4] + a[4] * b[7];
            c[5] = a[2] * b[2] + a[3] * b[5] + a[4] * b[8];
            c[6] = a[6] * b[0] + a[7] * b[3] + a[8] * b[6];
            c[7] = a[6] * b[1] + a[7] * b[4] + a[8] * b[7];
            c[8] = a[6] * b[2] + a[7] * b[5] + a[8] * b[8];
            label1.Text = Convert.ToString(c[0]);
            label2.Text = Convert.ToString(c[1]);
            label3.Text = Convert.ToString(c[2]);
            label4.Text = Convert.ToString(c[3]);
            label5.Text = Convert.ToString(c[4]);
            label6.Text = Convert.ToString(c[5]);
            label7.Text = Convert.ToString(c[6]);
            label8.Text = Convert.ToString(c[7]);
            label9.Text = Convert.ToString(c[8]);
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
            string text5 = label5.Text;
            string text6 = label6.Text;
            string text7 = label7.Text;
            string text8 = label8.Text;
            string text9 = label9.Text;
            text1 = "  " + text1;
            text2 = "  " + text2;
            text3 = "  " + text3 + "\n";
            text4 = "  " + text4;
            text5 = "  " + text5;
            text6 = "  " + text6 + "\n";
            text7 = "  " + text7;
            text8 = "  " + text8;
            text9 = "  " + text9 + "\n";
            using (FileStream fstream = new FileStream(@"D:\SomeDir\matrix3umnoj.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text1);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text2);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text3);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text4);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text5);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text6);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text7);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text8);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text9);
                fstream.Write(array, 0, array.Length);

            }
        }
    }
}
