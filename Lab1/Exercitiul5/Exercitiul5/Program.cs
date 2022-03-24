using System;

namespace Exercitiul5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            float medieAritmetica = 0;
            float medieGeometrica = 1;
            int n = 0;
            bool ok = false;
            string read;
            int i;
            Console.WriteLine("Introduceti numarul de elemente n= ");
            read = Console.ReadLine();
            while (ok == false)
            {
                try
                {
                    n = int.Parse(read);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Reintroduceti numarul de elemente n= ");
                    read = Console.ReadLine();
                }
            }
            Console.WriteLine("Introduceti sirul de numere :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 1; i <= n; i++)
            {
                medieAritmetica += array[i];
            }
            medieAritmetica /= n;
            for (i = 1; i <= n; i++)
            {
                medieGeometrica *= array[i];
            }
            Console.WriteLine("Media aritmetica a numerelor este: " + medieAritmetica + " iar media geometrica a numerelor este: " + Math.Pow(medieGeometrica,1.0/n));
        }
    }
}
