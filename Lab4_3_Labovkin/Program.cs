using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, l, w, sum, k; string s;

            Console.Write("Введите положительное число A=");
            s = Console.ReadLine();
            A = Convert.ToDouble(s);
            Console.Write("Введите положительное число B=");
            s = Console.ReadLine();
            B = Convert.ToDouble(s);
            Console.Write("Введите положительное число C=");
            s = Console.ReadLine();
            C = Convert.ToDouble(s);
            w = 0;
            while (A >= C)
            {
                A -= C;
                w++;//количество квадратов по длине
            }
            l = 0;
            while (B >= C)
            {
                B -= C;
                l++; //количество квадратов по высоте
            }
            k = 0; sum = 0;
            while (k < l)
            {
                sum += w;//общее число квадратов
                k++;
            }
            Console.Write("Количество квадратов C, помещающихся в прямоуг-ке АхB {0}", sum);
            Console.ReadKey();
        }
    }
}
