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
    class Line2 : Figure
    {
        List<PointF> list = new List<PointF>();//Список точек на основе которых строится линия;
        [NonSerialized()] Pen pen;
       
        public Line2(int x1, int y1, int s, Color b, Color l, int w, int h, bool fill) : base(x1, y1, s, b, l, w, h, fill)
        {
          
            PointF point = new PointF(x1, y1);//Инициализация первой точки в конструкторе;
            list.Add(point);//Добавление точки в конструктор;
            list.Add(point);
           
        }

        override public void Draw(Graphics g, int x, int y)
        {
            
            pen = new Pen(l, s);
            PointF[] points = new PointF[list.Count];//Объявление массива точек, т.к. с динамическим списком метод рисования не работает;
            int n = 0;
            foreach(PointF p in list)
            {
                
                points[n] = p;
                n++;
            }//Перенос точек из списка в массив;



           
            g.DrawCurve(pen, points);//Метод для рисования;
           
        }
        override public void DrawDash(Graphics g)
        {
            
            Pen pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            PointF[] points = new PointF[list.Count];
            int n = 0;
            foreach (PointF p in list)
            {
               
                points[n] = p;
                n++;
            }
            g.DrawCurve(pen, points);
        }
        override public void Clear(Graphics g)
        {
            Pen pen = new Pen(Color.White);
            System.Drawing.Rectangle rect = System.Drawing.Rectangle.FromLTRB(point1.x, point1.y, point2.x, point2.y);
            g.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.White);
            g.FillRectangle(brush, rect);
        }
        public override void MouseMove(Graphics g, MouseEventArgs e)
        {
            
            PointF f = new PointF(e.X, e.Y);
            list.Add(f);
            if (e.X > point2.x)
            {
                point2.x = e.X;
            }
            else if (e.X < point1.x)
            {
                point1.x = e.X;
            }
            if (e.Y > point2.y)
            {
                point2.y = e.Y;
            }
            else if (e.Y < point1.y)
            {
                point1.y = e.Y;
            }//Для очистки. Более не требуется;

            DrawDash(g);
        }
    }
}
