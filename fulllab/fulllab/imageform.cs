using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace fulllab
{

    public partial class imageform : Form
    {
        bool mb = false; // Объявление и инициализация переменной mb отвечающей за состояние кнопки мыши(нажата/не нажата)
        Rectangle rect;// Объявление объект созданного нами класса Rectangle с названием rect;
        Line line;//Объявление объект созданного нами класса Line с названием line;
        Line2 line2;//Объявление объект созданного нами класса Line2 с названием line2;
        Ellipse ellipse;//Объявление объект созданного нами класса Ellipse с названием ellipse;
        List<Figure> list = new List<Figure>();// Объявление и инициализация объекта типизированного списка;
        bool ch = false;//Объявление и инициализация вспомогательной переменной для реализации сохранения;
        int s = 1;//Объявление и инициализация переменной, отвечающей за размер линии;
        Color b = Color.White, l = Color.Black;// Объявление и инициализация объектов класса Color отвечающих за цвет линии и заливки;
        public int choose = 0;// Объявление и инициализация вспомогательной переменной, отвечающей за выбор фигуры для рисования;
        public int w = 800, h = 600;// Объявление и инициализация переменных, отвечающих за размер области для рисования;
        public bool fill = false;// Объявление и инициализация переменной, отвечаю за заливку;
        BufferedGraphics bf;// Объявления объекта класса BufferedGraphics, который предоставляет графический буфер ;
        private BufferedGraphicsContext context;// Объявления объекта класса BufferedGraphicsContext, который создает графический буфер ;
        public imageform(int w, int h) // Конструктор класса 
        {
            InitializeComponent();//Загружает откомпилированную страницу компонента.
            this.w = w;//Передает в поле класса переменную, переданную в конструктор;
            this.h = h;//Передает в поле класса переменную, переданную в конструктор;
            this.Width = w;//Задает значение свойства формы;
            this.Height = h;//Задает значение свойства формы;
            this.AutoScroll = true;//Задает значение свойства формы;

            this.AutoScrollMinSize = new System.Drawing.Size(w, h);//Задает значение свойства формы;
        }


   

        private void imageform_MouseDown(object sender, MouseEventArgs e)//Метод, вызываемый при нажатии любой кнопки мыши;
        {
            Form1 f = (Form1)ParentForm; //Объявление и инициализация объекта созданного нами класса Form1 и передача ссылки на родительскую форму;
            s = f.s;//Получение переменной из родительской формы;
            l = f.l;//Получение переменной из родительской формы;
            b = f.b;//Получение переменной из родительской формы;
            fill = f.fill;//Получение переменной из родительской формы;
            choose = f.ch;//Получение переменной из родительской формы;
            switch (choose)//Конструкция для создания объекта класса выбранной фигуры;
            {
               case 0:

                    rect = new Rectangle(e.X, e.Y, s, b, l, w, h, fill);// Инициализация объекта, объявленного ранее;
                    if ((e.X < w) && (e.Y < h)) //Проверка условия не выхода за допустимые пределы рисования;
                    {
                        mb = true;//Установка переменной-датчика нажатия кнопки мыши в true;
                        ch = true;//Установка переменной-датчика изменений в рисунке в true;

                    }

                    break;
                case 1:

                    ellipse = new Ellipse(e.X, e.Y, s, b, l, w, h, fill);// Инициализация объекта, объявленного ранее;
                    if ((e.X < w) && (e.Y < h))//Проверка условия не выхода за допустимые пределы рисования;
                    {
                        mb = true;//Установка переменной-датчика нажатия кнопки мыши в true;
                        ch = true;//Установка переменной-датчика изменений в рисунке в true;

                    }
                    break;
                case 2:

                    line = new Line(e.X, e.Y, s, b, l, w, h, fill);// Инициализация объекта, объявленного ранее;
                    if ((e.X < w) && (e.Y < h))//Проверка условия не выхода за допустимые пределы рисования;
                    {
                        mb = true;//Установка переменной-датчика нажатия кнопки мыши в true;
                        ch = true;//Установка переменной-датчика изменений в рисунке в true;

                    }
                    break;
                case 3:

                    line2 = new Line2(e.X, e.Y, s, b, l, w, h, fill);// Инициализация объекта, объявленного ранее;
                    if ((e.X < w) && (e.Y < h))
                    {
                        mb = true;//Установка переменной-датчика нажатия кнопки мыши в true;
                        ch = true;//Установка переменной-датчика изменений в рисунке в true;

                    }
                    break;



                default:
                    break;
            }

        }

        private void imageform_MouseUp(object sender, MouseEventArgs e)//Метод, вызываемый при отпускании любой кнопки мыши;
        {
            Graphics g = CreateGraphics();//Объявление и инициализация объекта класса Graphics;
            bf.Render(g);//Передача объекту Graphics буферизированного изображения;
            switch (choose)//Конструкция отвечающая за рисование выбранной фигуры;
            {
                case 0:

                    
                    if ((e.X < w) && (e.Y < h))//Проверка условия не выхода за допустимые пределы рисования;
                    {
                        rect.Scroll(AutoScrollPosition.X, AutoScrollPosition.Y);// Метод созданного нами класса Rectangle, отвечающий за пересчет координат в соответствии с положением видимой области;
                        rect.Draw(g, AutoScrollPosition.X, AutoScrollPosition.Y);// Метод созданного нами класса Rectangle, отвечающий за отображение прямоугольника в окне формы;
                        rect.Draw(bf.Graphics, AutoScrollPosition.X, AutoScrollPosition.Y);//Сохранение нарисованного прямоугольника в буфере;

                        list.Add(rect);// Добавление объекта в список, для последующего сохранения в виде файла;
                    }
                    rect = null;// очистка переменной хранящей ссылку на объект класса Rectangle
                    mb = false;//Установка переменной-датчика нажатия кнопки мыши в false;

                    break;
                case 1:

                    
                    if ((e.X < w) && (e.Y < h))//Проверка условия не выхода за допустимые пределы рисования;
                    {
                        ellipse.Scroll(AutoScrollPosition.X, AutoScrollPosition.Y);// Метод созданного нами класса Ellipse, отвечающий за пересчет координат в соответствии с положением видимой области;
                        ellipse.Draw(g, AutoScrollPosition.X, AutoScrollPosition.Y);// Метод созданного нами класса Ellipse, отвечающий за отображение эллипса в окне формы;
                        ellipse.Draw(bf.Graphics, AutoScrollPosition.X, AutoScrollPosition.Y);//Сохранение нарисованного эллипса в буфере;

                        list.Add(ellipse);// Добавление объекта в список, для последующего сохранения в виде файла;



                    }
                    ellipse = null;// очистка переменной хранящей ссылку на объект класса Ellipse;
                    mb = false;//Установка переменной-датчика нажатия кнопки мыши в false;
                    break;
                case 2:

                    
                    if ((e.X < w) && (e.Y < h))//Проверка условия не выхода за допустимые пределы рисования;
                    {
                        line.Scroll(AutoScrollPosition.X, AutoScrollPosition.Y);// Метод класса созданного нами класса Line, отвечающий за пересчет координат в соответствии с положением видимой области;
                        line.Draw(g, AutoScrollPosition.X, AutoScrollPosition.Y);// Метод созданного нами класса Line, отвечающий за отображение линии в окне формы;
                        line.Draw(bf.Graphics, AutoScrollPosition.X, AutoScrollPosition.Y);//Сохранение нарисованной линии в буфере;

                        list.Add(line);// Добавление объекта в список, для последующего сохранения в виде файла;



                    }
                    line = null;// очистка переменной хранящей ссылку на объект класса Line
                    mb = false;//Установка переменной-датчика нажатия кнопки мыши в false;
                    break;
                case 3:

                    
                    if ((e.X < w) && (e.Y < h))//Проверка условия не выхода за допустимые пределы рисования;
                    {
                        
                        line2.Draw(g, AutoScrollPosition.X, AutoScrollPosition.Y);// Метод созданного нами класса Line2, отвечающий за отображение линии в окне формы;
                        line2.Draw(bf.Graphics, AutoScrollPosition.X, AutoScrollPosition.Y);//Сохранение нарисованной линии в буфере;

                        list.Add(line2);// Добавление объекта в список, для последующего сохранения в виде файла;



                    }
                    line2 = null;// очистка переменной хранящей ссылку на объект класса Line2
                    mb = false;//Установка переменной-датчика нажатия кнопки мыши в false;
                    break;



                default:
                    break;
            }
            
           
        }

        private void imageform_MouseMove(object sender, MouseEventArgs e)//Метод, вызываемый при мередвижении указателя мыши;
        {
            Graphics g = CreateGraphics();// Объявление и инициализация объекта Graphics;
            if (mb == true)//Проверка условия нажатия кнопки мыши;
            {
                bf.Render(g);//Передача объекту Graphics буферизированного изображения;
            }
            switch (choose)//Конструкция для работы с выбранной фигурой;
            {
                case 0:

                    if ((mb == true) && (e.X < w) && (e.Y < h))//Проверка условий нажатия кнопки мыши и не выхода за границы рисования;
                    {
                        rect.MouseMove(g, e);// Метод класса Rectangle, определяющий новые координаты для рисования фигуры и перерисовывающий ее пунктиром.

                    }
                    break;
                case 1:

                    if ((mb == true) && (e.X < w) && (e.Y < h))//Проверка условий нажатия кнопки мыши и не выхода за границы рисования;
                    {
                        ellipse.MouseMove(g, e);// Метод класса Ellipse, определяющий новые координаты для рисования фигуры и перерисовывающий ее пунктиром.

                    }
                    break;
                case 2:
                    if ((mb == true) && (e.X < w) && (e.Y < h))//Проверка условий нажатия кнопки мыши и не выхода за границы рисования;
                    {
                        line.MouseMove(g, e);// Метод класса Line, определяющий новые координаты для рисования фигуры и перерисовывающий ее пунктиром.

                    }
                    break;
                case 3:

                    if ((mb == true) && (e.X < w) && (e.Y < h))//Проверка условий нажатия кнопки мыши и не выхода за границы рисования;
                    {
                        line2.MouseMove(g, e);// Метод класса Line2, определяющий новые координаты для рисования фигуры и перерисовывающий ее пунктиром.

                    }
                    break;
                    


                default:
                    break;
            }
         
        }

        private void imageform_Paint(object sender, PaintEventArgs e)//Метод-обработчик события, вызываемый при перерисовке окна формы;
        {
            System.Drawing.Rectangle rectangle = System.Drawing.Rectangle.FromLTRB(0, 0, w, h);//Объявление и инициализация объекта класса Rectangle;
            Graphics g = CreateGraphics();// Объявление и инициализация объекта Graphics;
            Brush br = new SolidBrush(Color.White);//Объявление и инициализация объекта класса Brush;
            g.FillRectangle(br, rectangle);// Вызов метода класса Graphics, отвечающего за заливку прямоугольника;
            bf.Graphics.FillRectangle(br, rectangle);// Передача соответствующего прямоугольника в буфер;
            foreach (Figure f in list)//Цикл, обращающийся к каждому объекту внутри списка;
            {
              
                f.Draw(g, AutoScrollPosition.X, AutoScrollPosition.Y);//Перерисовка фигур из списка;
                f.Draw(bf.Graphics, AutoScrollPosition.X, AutoScrollPosition.Y);//Буферизация фигур списка;
            }
        }

        private void imageform_FormClosing(object sender, FormClosingEventArgs e)//Метод-обработчик события, вызываемый при закрытии формы;
        {
            if (ch == true)//Условие проверки были ли изменения после открытия формы;
            {
                DialogResult dr = MessageBox.Show("Сохранить изменения?", "Закрыть", MessageBoxButtons.YesNoCancel);//Объявление и инициализация объекта класса DialogResult; Также вызов диалогового окна с помощью класса MessageBox;
                if (dr == DialogResult.Cancel)//Проверка нажатия кнопик "Закрыть" в диалоговом окне;
                {
                    e.Cancel = true;//Задает значение указывающее, что стоит отменить закрытие;
                }
                else if (dr == DialogResult.Yes)//Проверка нажатия кнопик "Да" в диалоговом окне;
                {
                    save();//Метод, отвечающий за сохранение изображения в виде файла;
                    

                }
            }

        }

        public void save()//Метод, отвечающий за сохранение изображения в виде файла;
        {
            BinaryFormatter formatter = new BinaryFormatter();// Объявление и инициализация объекта класса BinaryFormatter;

            Stream stream = new FileStream(this.Text, FileMode.Create, FileAccess.Write, FileShare.None);// Объявление и инициализация объекта класса Stream;

            formatter.Serialize(stream, list);// Вызов метода, отвечающего за сохранение изображения в виде файла;
            stream.Close();//Закрытие потока;
            ch = false;// Изменения значения переменной-датчика изменений;
        }
        public void saveas()// Метод, отвечающий за сохранение изображения в виде файла в определенной директории с определенным именем;
        {
            SaveFileDialog save = new SaveFileDialog();//Объявление инициализация объекта диалоговой формы сохранения;
            save.InitialDirectory = Environment.CurrentDirectory;//Задает стартовую директорию для отображения в диалоге сохранения;
            save.ShowDialog();//Вызов метода ShowDialog();
            string fileName = save.FileName;//Получение желаемого пользователем имени файла из формы диалога;
            
            BinaryFormatter formatter = new BinaryFormatter();// Объявление и инициализация объекта класса BinaryFormatter, используемого для преобразования данных для записи в файл;

            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);//Объявление и инициализация объекта класса Stream на запись данных в файл;

            formatter.Serialize(stream, list);//Запись данных из списка list в целевой файл;
            stream.Close();//Закрытие потока;
            ch = false;// Изменения значения переменной-датчика изменений;
            this.Text = fileName;//Название формы изменяется на название файла;
        }

        private void imageform_Load(object sender, EventArgs e)// Метод-обработчик события, вызываемый при загрузке формы;
        {
            context = BufferedGraphicsManager.Current;//Инициализация ранее объявленного объекта;
            bf = context.Allocate(this.CreateGraphics(), System.Drawing.Rectangle.FromLTRB(0, 0, w, h));// Инициализация ранее объявленного объекта;
            System.Drawing.Rectangle rectangle = System.Drawing.Rectangle.FromLTRB(0, 0, w, h);// Объявление и инициалиазция объекта класса Rectangle;
            bf.Graphics.FillRectangle(new SolidBrush(Color.White), rectangle);// Окрашивание фона формы допустимой для рисования в белый  в буфере;

        }

        private void imageform_FormClosed(object sender, FormClosedEventArgs e)//Метод-обработчик события, вызываемый после закрытия формы;
        {
            Form1 f = (Form1)ParentForm;// Объявление и инициализация объекта класса Form1;
            f.saveactive();//Вызов метода класса Form1;
        }

        public void open()//Метод, реализующий открытие сохраненного рисунка;
        {
            OpenFileDialog open = new OpenFileDialog();// Объявление и инициализация объекта класса OpenFileDialog;
            open.ShowDialog();//Вызов диалогового окна для открытия файла;
            this.Text = open.FileName;//Присвоение форме названия открытого файла;
            BinaryFormatter formatter = new BinaryFormatter();// Объявление и инициализация объекта класса BinaryFormatter, используемого для преобразования данных для чтения из файл;

            Stream stream = new FileStream(open.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);//Объявление и инициализация объекта класса Stream на чтение данных из файл;

            list = (List<Figure>)formatter.Deserialize(stream);//Запись данных из файла в список list;

            stream.Close();//Закрытие потока;
            w = list.First().w;//Запись переменной хранящей ширину холста;
            h = list.First().h;//Запись переменной хранящей высоту холста;
            this.Width = w;
            this.Height = h;
        }
    }
}
