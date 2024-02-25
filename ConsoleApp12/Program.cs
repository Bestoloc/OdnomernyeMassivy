using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] z = new double[7];
            double[] f = new double[7];

            double Ravny0 = 0;
            double j = 0;
            int i = 0;
            string Nomer = "";
            int k = 1;
            double Proizved = 1;

            Random rnd = new Random();

            while (i <= 6)
            {
                z[i] = rnd.Next(0, 5);

                j = z[i] / (-6);

                if (z[i] == 0)
                {
                    Ravny0++;
                    Nomer += $"{i + 1}";
                }
                Console.WriteLine($"z[i] = {z[i]}, f[i] = {j}");

                
                i++;

                if (j < 0 && k % 2 != 0)
                {
                    Proizved *= j;
                }
                k++;
            }

            if (Ravny0 != 0)
            {

                
                Console.WriteLine($"Кол-во элементов равных нулю - {Ravny0}, номера - {Nomer}");
            }
            else
            {
                Console.WriteLine("Элементов равных нулю нет!");
            }
            Console.WriteLine();
            Console.WriteLine($"\nПроизведение - {Proizved}\n");
        }
    }
}
