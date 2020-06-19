using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace fulllab
{
    [Serializable]//Указатель на то, что класс может быть серриализирован;
    class Rectangle : Figure//Наследование от класса Figure;
    {
        [NonSerialized()] Pen pen;//Не серриализуемая вспомогательная переменная;
        public Rectangle(int x1, int y1, int s, Color b, Color l, int w, int h, bool fill) : base(x1, y1, s, b, l, w, h, fill)//Конструктор класса, на основе унаследованного;
        {
        }

        override public void Draw(Graphics g, int x, int y)//Реализация унаследованного абстрактного метода;
        {
            
            pen = new Pen(l, s);//Инициализация объекта класса Pen;
            


           
            System.Drawing.Rectangle rect = System.Drawing.Rectangle.FromLTRB(point1.x + x, point1.y + y, point2.x + x, point2.y + y);//Объявление и инициализация объекта класса Rectangle;
            if (fill == true)//Проверка условия необходимости заливки;
            {
                Brush brush = new SolidBrush(b);//Объявление инициализация переменной класса Brush;
                g.FillRectangle(brush, rect);//Метод класса Graphics, служащий для заливки;
            }
            g.DrawRectangle(pen, rect); //Метод класса Graphics, рисующий прямоугольник;

        }
        override public void DrawDash(Graphics g)//Реализация унаследованного абстрактного метода;
        {
            
            Pen pen = new Pen(Color.Black);//Объявление и инициализация объекта класса Pen;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;//Задание стиля линии - пунктир;
            System.Drawing.Rectangle rect = System.Drawing.Rectangle.FromLTRB(point1.x, point1.y, point2.x, point2.y);//Объявление и инициализация объекта класса Rectangle;
            g.DrawRectangle(pen, rect);//Метод класса Graphics, рисующий прямоугольник;
        }
        override public void Clear(Graphics g)//Реализация унаследованного абстрактного метода;
        {
            Pen pen = new Pen(Color.White);//Объявление и инициализация объекта класса Pen;
            System.Drawing.Rectangle rect = System.Drawing.Rectangle.FromLTRB(point1.x, point1.y, point2.x, point2.y);//Объявление и инициализация объекта класса Rectangle;
            g.DrawRectangle(pen, rect);//Метод класса Graphics, рисующий прямоугольник;
        }
    }
}
