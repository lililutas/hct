using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fulllab
{
    public partial class Form1 : Form
    {
        public int s = 1;//Объявление и инициализация переменной, отвечающей за размер линии;
        public Color b = Color.White, l = Color.Black;// Объявление и инициализация объектов класса Color, Отвечающих за цвет заливки и цвет линии;
        public int w = 800, h = 600;//Объявление и инициализация переменных, отвечающих за размер холста;
        public bool fill = false;//Объявление инициализация переменной-датчика необходимости заливки;
        public int ch = 0;//Объявление и инициализация переменной, отвечающей за выбранную фигуру;
        public Form1()
        {
            InitializeComponent();
        
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Создать" в меню;
        {
            Form form = new imageform(w, h);//Объявление и инициализация объекта класса Form;
            form.MdiParent = this;//Присвоение созданной форме родительской формы;
            form.Text = "Рисунок " + this.MdiChildren.Length.ToString();//Присвоение названия созданной форме;
            form.Show();//Отображение формы на экране;
            сохранитьToolStripMenuItem.Enabled = true;//Активация кнопки меню "Сохранить"
            сохранитьКакToolStripMenuItem.Enabled = true;// Активация кнопки меню "Сохранить как"

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Сохранить" в меню;
        {
            imageform form = (imageform)this.ActiveMdiChild;//Объявление и инициализация объекта класса imageform и присвоение ему ссылки на дочернюю форму;
            form.save();//Вызов метода, отвечающего за сохранение;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Сохранить как" в меню;
        {
            imageform form = (imageform)this.ActiveMdiChild;//Объявление и инициализация объекта класса imageform и присвоение ему ссылки на дочернюю форму;
            form.saveas();//Вызов метода, отвечающего за сохранение;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Открыть" в меню;
        {
            imageform form = new imageform(w, h); ;//Объявление и инициализация объекта класса imageform;
            form.MdiParent = this;//Присвоение созданной форме родительской формы;
            form.open();// Вызов метода, отвечающего за открытие рисунка из файла;
            form.Show();//Отображение формы на экране;
            сохранитьToolStripMenuItem.Enabled = true;//Активация кнопки меню "Сохранить"
            сохранитьКакToolStripMenuItem.Enabled = true;// Активация кнопки меню "Сохранить как"
        }

        private void толщинаГраницыToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Толщина" в меню;
        {
            mydialog md = new mydialog();//Объявление и инициализация объекта класса mydialog;
            md.Text = "Толщина линии";//Присвоение названия диалоговому окну;
            md.s = s;//Передача значения толщины в поле объекта;
            md.ShowDialog();//Отображение диалога;
            s = md.s;// Получение значения толщины из поля объекта;
            
            
        }

        private void цветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Цвет заливки" в меню;
        {
            ColorDialog cd = new ColorDialog();//Объявление и инициализация объекта класса ColorDialog;
            cd.ShowDialog();//Отображение диалогового окна;
            b = cd.Color;// Получение цвета из поля диалога;
        }

        private void цветГраницыToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Цвет границы" в меню;
        {
            ColorDialog cd = new ColorDialog();//Объявление и инициализация объекта класса ColorDialog;
            cd.ShowDialog();//Отображение диалогового окна;
            l = cd.Color;// Получение цвета из поля диалога;
        }

        private void эллипсToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Прямоугольник" в меню;(На название не смотреть. Ошибся. Бывает)
        {
            ch = 0;//Сохранение в переменной номера выбранной фигуры;
            эллипсToolStripMenuItem.Checked = true;//Отображение галочки напротив выбранной фигуры в меню;
            эллипсToolStripMenuItem1.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
            произвольнаяЛинияToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
            прямаяЛинияToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
        } 

        private void эллипсToolStripMenuItem1_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Эллипс" в меню;
        {
            ch = 1;//Сохранение в переменной номера выбранной фигуры;

            эллипсToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
            эллипсToolStripMenuItem1.Checked = true;//Отображение галочки напротив выбранной фигуры в меню;
            произвольнаяЛинияToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
            прямаяЛинияToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
        }

        private void прямаяЛинияToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Прямая линия" в меню;
        {
            ch = 2;//Сохранение в переменной номера выбранной фигуры;
            эллипсToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив выбранной не фигуры в меню;
            эллипсToolStripMenuItem1.Checked = false;//Отключение отображения галочки напротив выбранной не фигуры в меню;
            произвольнаяЛинияToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
            прямаяЛинияToolStripMenuItem.Checked = true;//Отображение галочки напротив выбранной фигуры в меню;
        }

        private void произвольнаяЛинияToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Произвользая линия" в меню;
        {
            ch = 3;//Сохранение в переменной номера выбранной фигуры;

            эллипсToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
            эллипсToolStripMenuItem1.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
            произвольнаяЛинияToolStripMenuItem.Checked = true;//Отображение галочки напротив выбранной фигуры в меню;
            прямаяЛинияToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив не выбранной фигуры в меню;
        }

        private void заливкаToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Заливка" в меню;
        {
            if (fill == true)//Проверка переменной-датчика необходимости заливки;
            {
                заливкаToolStripMenuItem.Checked = false;//Отключение отображения галочки напротив пункта "Заливка" в меню;
                fill = false;//Смена значения переменной-датчика необходимости заливки;
            }
            else
            {
                заливкаToolStripMenuItem.Checked = true;//Отображение галочки напротив пункта "Заливка" в меню;
                fill = true;//Смена значения переменной-датчика необходимости заливки;
            }

        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)//Метод-Обработчик события клика по кнопке "Размер" в меню;
        {
            mydialogs md = new mydialogs();//Объявление и инициализация объекта класса mydialog;
            md.Text = "Размер";//Присвоение названия диалоговому окну;
            md.ShowDialog();// Отображение диалога;
            w = md.w1;//Получение из диалога значения ширины холста;
            h = md.s1;//Получение из диалога значения высоты холста;


        }

        public void saveactive()//Метод отвечающий за активность кнопок "Сохранить" и "Сохранить как" только при наличии дочерних форм;
        {
            if (this.MdiChildren.Length == 1)//Проверяется наличие дочерних форм;
            {
                сохранитьToolStripMenuItem.Enabled = false;//Отключение кнопки меню "Сохранить";
                сохранитьКакToolStripMenuItem.Enabled = false;//Отключение кнопки меню "Сохранить как";
            }
        }
    }
}
