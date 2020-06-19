using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace fulllab
{
    [Serializable]
    class Ellipse : Figure
    {
        [NonSerialized()] Pen pen;
        public Ellipse(int x1, int y1, int s, Color b, Color l, int w, int h, bool fill) : base(x1, y1, s, b, l, w, h, fill)
        {
        }

        override public void Draw(Graphics g, int x, int y)
        {
            
            pen = new Pen(l, s);



            System.Drawing.Rectangle rect = System.Drawing.Rectangle.FromLTRB(point1.x + x, point1.y + y, point2.x + x, point2.y + y);
            if (fill == true)
            {
                Brush brush = new SolidBrush(b);
                g.FillEllipse(brush, rect);// Метод класса Graphics, отвечающий за заливку эллипса;

            }
            g.DrawEllipse(pen, rect);//Метод класса Graphics, отвечающий за рисование эллипса;

        }
        override public void DrawDash(Graphics g)
        {
            
            Pen pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            System.Drawing.Rectangle rect = System.Drawing.Rectangle.FromLTRB(point1.x, point1.y, point2.x, point2.y);
            g.DrawEllipse(pen, rect);//Метод класса Graphics, отвечающий за рисование эллипса;
        }
        override public void Clear(Graphics g)
        {
            Pen pen = new Pen(Color.White);
            System.Drawing.Rectangle rect = System.Drawing.Rectangle.FromLTRB(point1.x, point1.y, point2.x, point2.y);
            g.DrawRectangle(pen, rect);//Метод класса Graphics, отвечающий за рисование эллипса;
            Brush brush = new SolidBrush(Color.White);
            g.FillRectangle(brush, rect);// Метод класса Graphics, отвечающий за заливку эллипса;
        }
    }
}
