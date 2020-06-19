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
    class Line : Figure
    {
        [NonSerialized()]
        System.Drawing.Rectangle rect;// Не серриализуемая вспомогательная переменная;
        [NonSerialized()] int x, y, x1 , y1;// Не серриализуемая вспомогательная переменная;
        [NonSerialized()] Pen pen;// Не серриализуемая вспомогательная переменная;
        public Line(int x1, int y1, int s, Color b, Color l, int w, int h, bool fill) : base(x1, y1, s, b, l, w, h, fill)
        {
        }

        override public void Draw(Graphics g, int x, int y)
        {
            pen = new Pen(l, s);
            g.DrawLine(pen,point1.x + x, point1.y + y, point2.x + x, point2.y + y);//Метод класса Graphics, отвечающий за рисование прямой линии;
        }
        override public void DrawDash(Graphics g)
        {   
            Pen pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(pen, point1.x, point1.y, point2.x, point2.y);//Метод класса Graphics, отвечающий за рисование прямой линии;
        }
        override public void Clear(Graphics g)
        {
            Pen pen = new Pen(Color.White);
            if (point1.x < point2.x)
            {
                x = point1.x;
                x1 = point2.x;
            }
            else
            {
                x = point2.x;
                x1 = point1.x;
            };
            if (point1.y < point2.y)
            {
                y = point1.y;
                y1 = point2.y;
            }
            else 
            {
                y = point2.y;
                y1 = point1.y;
            };// Нормализация;
            Point pcl1 = new Point(x, y);//Вспомогательные переменные
            Point pcl2 = new Point(x1, y1);//Вспомогательные переменные
            rect = System.Drawing.Rectangle.FromLTRB(pcl1.x, pcl1.y, pcl2.x, pcl2.y);
                     
            g.DrawRectangle(pen, rect);//Рисование прямоугольника для очистки(В последствии не используется из-за буферизации;
            Brush brush = new SolidBrush(Color.White);
            g.FillRectangle(brush, rect);// Заливка прямоугольника для очистки(В последствии не используется из-за буферизации;
        }
        public override void MouseMove(Graphics g, MouseEventArgs e)
        {
            point2.x = e.X;
            point2.y = e.Y;
            DrawDash(g);
        }
    }
}
