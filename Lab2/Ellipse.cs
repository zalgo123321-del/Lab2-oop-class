using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    class Ellipse : Shape
    {
        public Ellipse(float x, float y,
                       float width, float height)
            : base(x, y, width, height)
        {
        }

        public override float Area()
        {
            return (float)
                (Math.PI * (_width / 2) * (_height / 2));
        }

        public override void Draw(
            PictureBox pictureBox,
            Color color)
        {
            Graphics g =
                Graphics.FromHwnd(pictureBox.Handle);

            Pen pen = new Pen(color, 2);

            g.DrawEllipse(
                pen,
                _x,
                _y,
                _width,
                _height);
        }
    }
}