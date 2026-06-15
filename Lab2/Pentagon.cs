using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    class Pentagon : Shape
    {
        public Pentagon(float x, float y,
                        float width, float height)
            : base(x, y, width, height)
        {
        }

        public override float Area()
        {
            float side = _width;

            return (float)
                ((5 * side * side) /
                (4 * Math.Tan(Math.PI / 5)));
        }

        public override void Draw(
            PictureBox pictureBox,
            Color color)
        {
            Graphics g =
                Graphics.FromHwnd(pictureBox.Handle);

            Pen pen = new Pen(color, 2);

            PointF[] points =
            {
                new PointF(_x + _width / 2, _y),

                new PointF(_x + _width,
                           _y + _height / 3),

                new PointF(_x + _width * 0.8f,
                           _y + _height),

                new PointF(_x + _width * 0.2f,
                           _y + _height),

                new PointF(_x,
                           _y + _height / 3)
            };

            g.DrawPolygon(pen, points);
        }
    }
}
