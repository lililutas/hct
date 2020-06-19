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
    public partial class mydialog : Form
    {
        public int s;
        public mydialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Метод-обработчик события Клика по кнопке OK
        {
            s = System.Convert.ToInt32(this.comboBox1.SelectedItem.ToString());//Первод значения из формы в числовой формат;
        }
    }
}
