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
    public partial class mydialogs : Form
    {
        int w = 800, s = 600;//Переменные высоты и ширины;
        public int w1 = 800, s1 = 600;//Дополнительные переменные для обмена данными;
        public mydialogs()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//Выбор ручного ввода или заранее обозначенных размеров;
        {
            if (checkBox1.Checked)
            {
                radioButton1.Enabled = false;//Перевод всех заранее обозначенных размеров в неактивную форму;
                radioButton2.Enabled = false;//
                radioButton3.Enabled = false;//
                textBox1.Enabled = true;//Активация поля для ввода пользовательского размера;
                textBox2.Enabled = true;//
            }
            else
            {
                radioButton1.Enabled = true;//Обратное написанному выше
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Выбор первого заранее обозначенного размера
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            w = 320;
            s = 240;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Ворого
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            w = 640;
            s = 480;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//Третьего
        {
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            w = 800;
            s = 600;

        }

        private void button1_Click(object sender, EventArgs e)//Клик по кнопке "OK"
        {
            w1 = w;
            s1 = s;
            if (checkBox1.Checked)
            {
                w1 = System.Convert.ToInt32(textBox1.Text);//Перевод в числовое значение введенных пользователем параметров;
                s1 = System.Convert.ToInt32(textBox2.Text);//
            }
        }
    }
}
