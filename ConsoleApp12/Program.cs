using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp12
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] z = new double[7];
            double[] f = new double[7];

            double Ravny0 = 0;
            double j = 0;
            
            string Nomer = "";
            int k = 1;
            double Proizved = 1;
            Random rnd = new();

            // Ввод массива
            for (int i = 0; i <= 6; i++)
            {
                z[i] = rnd.Next(0, 5);
            }

            

            // Количество элементов массива z[i], равных 0, и номера таких элементов
            for (int i = 0; i <= 6; i++)
            {
                if (z[i] == 0)
                {
                    Ravny0++;
                    Nomer += $"{i + 1}";
                }
                Console.Write($"z[{i + 1}] = {z[i]}\n");
            }
            Console.WriteLine();
            if (Ravny0 != 0)
            {
                Console.Write($"Кол-во элементов равных нулю - {Ravny0}, номера таких элементов - {Nomer}\n"); 
            }
            else
            {
                Console.WriteLine("Элементов равных нулю нет!");
            }
            Console.WriteLine();

            // Элементы массива f[i], i = 1..7 по формуле ...
            for (int i = 0; i <= 6; i++)
            {
                j = z[i] / (-6);
                Console.Write($"f[{i + 1}] = {j} \n");

            }


            // произведение отрицательных элементов массива f[i], расположенных на нечетных позициях

            for (int i = 0; i <= 6; i++)
            {
                if (j < 0 && k % 2 != 0)
                {
                    Proizved *= j;
                }
            }
            Console.WriteLine($"\nПроизведение - {Proizved}\n");

        }
    }
}
