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

            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            float size = float.Parse(textBox3.Text);


            Square sq = new Square(x, y, size);

            
            sq.ColorName = "Red";

            
            sq.Draw(pictureBox1);

            
            MessageBox.Show(sq.ToString());

            
            sq.Move(10);

           
            float factor = 2;
            sq.Scale(ref factor);

            
            sq.Resize();

            
            var data = sq.GetData();
            MessageBox.Show($"X={data.x}, Y={data.y}, Size={data.size}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
