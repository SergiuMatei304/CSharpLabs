using System;

namespace Exercitiu1
{
    class Program
    {
        static void Main(string[] args)
        {
            string read;
            int n = 0;
            int f1 = 1;
            int f2 = 1;
            int f3;
            Console.WriteLine("Introduceti numarul n pentru afisarea primilor n termeni din sirul Fibbonacci(Mai Mare decat 1) : ");
            read = Console.ReadLine();
            try 
            {
                n = int.Parse(read);
            }
            catch (Exception e)
            {

            }
            while (n < 2)
            {
                Console.WriteLine("n nu este introdus corect! Reintroduceti un numar n mai mare decat 1 :");
                read = Console.ReadLine();
                try
                {
                    n = int.Parse(read);
                }
                catch (Exception e)
                {

                }
            }
                Console.Write(f1 + " " + f2);
                for(int i=2;i<n;i++)
                {
                    f3 = f1 + f2;
                    Console.Write(" " + f3);
                    f1 = f2;
                    f2 = f3;
                }
            Console.ReadKey();
        }
    }
}
