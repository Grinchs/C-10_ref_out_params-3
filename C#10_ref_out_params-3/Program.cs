using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_10_ref_out_params_3
{
    internal class Program
    {
        static int ParaSkaitluSumma(int[] mas, out int paraSkaitluSkaits)
        {
            paraSkaitluSkaits = 0;
            int sum = 0;

            foreach (int i in mas)
            {
                if (i % 2 == 0)
                {
                    paraSkaitluSkaits += i;
                    sum++;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi masīva lielumu: ");
            int liels = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] mas = new int[liels];
            Random rand = new Random();

            for (int i = 0; i < liels; i++)
            {
                mas[i] = rand.Next(1, 10);
                Console.WriteLine(mas[i]);
            }

            int sum;
            int paraSkaitluSkaits = ParaSkaitluSumma(mas, out sum);

            Console.WriteLine("Summa: " + sum);
            Console.WriteLine("Pāra skaitļu skaits: " + paraSkaitluSkaits);
        }
    }
}