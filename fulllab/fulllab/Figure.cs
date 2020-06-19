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
    abstract class Figure//Ключевое слово, говорящее о том, что класс - абстрактный;
    {
        public Point point1, point2, pointabs;//Объявление объектов класса Point;
        public int s = 1;//Объявление и инициализация переменной, отвечающей за размер линии;
        public Color b = Color.White, l = Color.Black;// Объявление и инициализация объектов класса Color отвечающих за цвет линии и заливки;
        public int w = 800, h = 600;// Объявление и инициализация переменных, отвечающих за размер области для рисования;
        public bool fill = false;// Объявление и инициализация переменной, отвечаю за заливку;

        public Figure(int x1, int y1, int s, Color b, Color l, int w, int h, bool fill)//Конструктор класса;
        {
            point1 = new Point(x1, y1);//Присвоение значения переменной через конструктор;
            point2 = new Point(x1, y1);//Присвоение значения переменной через конструктор;
            pointabs = new Point(x1, y1);//Присвоение значения переменной через конструктор;
            this.b = b;//Присвоение значения переменной через конструктор;
            this.l = l;//Присвоение значения переменной через конструктор;
            this.s = s;//Присвоение значения переменной через конструктор;
            this.w = w;//Присвоение значения переменной через конструктор;
            this.h = h;//Присвоение значения переменной через конструктор;
            this.fill = fill;//Присвоение значения переменной через конструктор;
        }

        abstract public void Draw(Graphics g, int x, int y);//Абстрактный метод, реализация которого будет представлена в наследующих классах;
        abstract public void DrawDash(Graphics g);//Абстрактный метод, реализация которого будет представлена в наследующих классах;
        abstract public void Clear(Graphics g);//Абстрактный метод, реализация которого будет представлена в наследующих классах;

        virtual public void MouseMove(Graphics g, MouseEventArgs e)//Виртуальный метод, реализация которого может изменяться в наследующих классах;
        {
          
         
            if(e.X > pointabs.x)
            {
                point2.x = e.X;
            }
            else
            {
                point1.x = e.X;
            }
            if(e.Y > pointabs.y)
            {
                point2.y = e.Y;
            }
            else
            {
                point1.y = e.Y;
            }//Нормализация;
            
            DrawDash(g);//Вызов метода рисования пунктиром;
        }
        public void Scroll(int x, int y)//Пересчет координат в зависимости с положением видимой области относительно холста;
        {
            point1.x -= x;
            point1.y -= y;
            point2.x -= x;
            point2.y -= y;
        }


    }
}
