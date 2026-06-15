using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x;
            float y;
            float width;
            float height;

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Оберіть фігуру");
                return;
            }

            if (!float.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Помилка");
                return;
            }

            if (!float.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Помилка");
                return;
            }

            if (!float.TryParse(textBox3.Text, out width))
            {
                MessageBox.Show("Помилка");
                return;
            }

            if (!float.TryParse(textBox4.Text, out height))
            {
                MessageBox.Show("Помилка");
                return;
            }

            pictureBox1.Refresh();

            Shape shape;

            switch (comboBox1.Text)
            {
                case "П'ятикутник":

                    shape =
                        new Pentagon(
                            x,
                            y,
                            width,
                            height);

                    break;

                case "Еліпс":

                    shape =
                        new Ellipse(
                            x,
                            y,
                            width,
                            height);

                    break;

                default:
                    return;
            }

            shape.Draw(
                pictureBox1,
                Color.Blue);

            MessageBox.Show(
                "Площа = " +
                shape.Area().ToString("F2"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
