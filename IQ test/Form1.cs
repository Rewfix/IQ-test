using System;
using System.Drawing;
using System.Windows.Forms;

namespace IQ_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(IQ_test.Properties.Resources.i1);
            pictureBox1.BackgroundImage = bmp;
        }

        int a = 0; int b = 0; int c = 0; int d = 0;
        int[] answers = new int[5];
        void met(int a)
        {
            switch (answers[a])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = true;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    break;
            }
            switch (a)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(IQ_test.Properties.Resources.i1); break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(IQ_test.Properties.Resources.i2); break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(IQ_test.Properties.Resources.i3); break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(IQ_test.Properties.Resources.i4); break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(IQ_test.Properties.Resources.i5); break;
            }
            b = a + 1;
            label1.Text = "Вопрос №" + b;
        }

        void button1_Click(object sender, EventArgs e)
        {
            a++;
            if (a > 4) a = 4;
            met(a);
            if (a == 4)
                button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (answers[0] == 1)
                c++;
            if (answers[1] == 3)
                c++;
            if (answers[2] == 1)
                c++;
            if (answers[3] == 5)
                c++;
            if (answers[4] == 2)
                c++;
            d = c * 100 / 5;
            DialogResult q = MessageBox.Show("Вы ответили правильно на "+ d +" процентов вопросов :)", "Результаты теста", MessageBoxButtons.RetryCancel);
            if (q == DialogResult.Cancel)
                Application.Exit();
            else
                Application.Restart();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answers[a] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answers[a] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answers[a] = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answers[a] = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            answers[a] = 5;
        }
    }
}