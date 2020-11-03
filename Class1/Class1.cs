using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_x
{
    public class Class1
    {
        //textBox1 – сгенерированные числа
        //textBox2 – результат расчета
      
        public static void NeMas( ref TextBox textBox1, ref TextBox textBox2 )
        {
            Random rnd = new Random();//Создаем объект Random
            double a=0, b, a1;
            do
            {
                b = a;
                a = rnd.Next(-5,4);//генерируем число
                textBox1.Text = textBox1.Text + a.ToString() + " ";//выводим сгенерированое число

                if (a > 0) a1 = Math.Sqrt(a);//если число > 0, извлекаем квадратный корень
                else a1 = a * a;//иначе возводим в квадрат

                a1 = Math.Round(a1, 2);//округление числа
                textBox2.Text = textBox2.Text + a1.ToString() + " ";//вывод числа 

            } while (a != b);
        }
    }
}
