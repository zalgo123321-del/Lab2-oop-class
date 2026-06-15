using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    abstract class Shape
    {
        protected float _x;
        protected float _y;
        protected float _width;
        protected float _height;

        protected Shape(float x, float y,
                        float width, float height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public abstract float Area();

        public abstract void Draw(
            PictureBox pictureBox,
            Color color);
    }
}