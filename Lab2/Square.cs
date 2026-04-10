using System;
using System.Drawing;
using System.Windows.Forms;

class Square
{
   
    private float _x;
    private float _y;
    private float _size;
    private string _colorName = "Blue";

    
    public float X
    {
        get { return _x; }
        set { _x = value; }
    }


    public float Y
    {
        get { return _y; }
        set
        {
            if (value < 0)
                throw new Exception("Y не може бути відємним");
            _y = value;
        }
    }

   
    public float Size
    {
        get { return _size; }
        set { _size = (value <= 0) ? 50 : value; }
    }

    
    public float Perimeter
    {
        get { return _size * 4; }
    }

    
    public string ColorName
    {
        get { return _colorName; }
        set { _colorName = value; }
    }

   
    public Square(float x, float y, float size)
    {
        X = x;
        Y = y;
        Size = size;
    }

    
    public void Draw(PictureBox box)
    {
        Graphics g = Graphics.FromHwnd(box.Handle);
        Pen pen = new Pen(Color.FromName(_colorName), 2);

        g.DrawRectangle(pen, _x, _y, _size, _size);
    }

  
    public override string ToString()
    {
        return $"Square: X={_x}, Y={_y}, Size={_size}, P={Perimeter}";
    }

    

    public void Move(float dx, float dy)
    {
        _x += dx;
        _y += dy;
    }

    public void Move(float dx)
    {
        _x += dx;
        _y += dx;
    }

    public void Scale(ref float factor)
    {
        _size *= factor;
        factor += 1; 
    }

    
    public void Resize(float newSize = 100)
    {
        _size = newSize;
    }

    
    public (float x, float y, float size) GetData()
    {
        return (_x, _y, _size);
    }
}