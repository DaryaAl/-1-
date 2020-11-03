using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_x;

namespace Практическая_работа__1
{
    //Главная форма программы
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка Справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №1" +
                "Разработчик Алешина Дарья группа ИСП-31" +
                "Вариант 6. Задание: Генерировать случайные числа Х," +
                " распределенные в диапазоне от -5 до 4 и вычислять для чисел > 0 X ," +
                " а для чисел < 0 функцию x2. " +
                "Вычисления прекратить, когда подряд появится два одинаковых случайных числа. " +
                "На экран необходимо выводить сгенерированное число и результат расчета функции на разных строках.  ");
        }

        //Кнопка Сгенерировать
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            Class1.NeMas(ref textBox1, ref textBox2);//используем библиотеку
        }

        //Кнопка Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
