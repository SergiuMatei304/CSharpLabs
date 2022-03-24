using System;

namespace Exercitiu2
{
    class Numere
    {
        float a;
        float b;
        float suma, produs, diferenta, cat;
        public Numere(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public void Adunare()
        {
            this.suma = a + b;
        }
        public void Produs()
        {
            this.produs = a * b;
        }
        public void Diferenta()
        {
            this.diferenta = a - b;
        }
        public void Cat()
        {
            if (b != 0)
                this.cat = a / b;
        }
        public void Afisare()
        {
            Console.WriteLine("Suma numerelor " + a + " si " + b + " este : " + suma);
            Console.WriteLine("Produsul numerelor " + a + " si " + b + " este : " + produs);
            Console.WriteLine("Diferenta numerelor " + a + " si " + b + " este : " + diferenta);
            if (b != 0)
                Console.WriteLine("Catul numerelor " + a + " si " + b + " este : " + cat);
            else
                Console.WriteLine("Nu se poate imparti la 0");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            string read;
            int a=0;
            int b=1;
            Console.WriteLine("Introduceti 2 numere:");
            Console.WriteLine("a=");
            read=Console.ReadLine();
            while (ok == false)
            {
                try
                {
                    a = int.Parse(read);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Introduceti un numar!!");
                    Console.WriteLine("a=");
                    read = Console.ReadLine();
                }
            }
            ok = false;
            Console.WriteLine("b=");
            read = Console.ReadLine();
            while (ok == false)
            {
                try
                {
                    b = int.Parse(read);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Introduceti un numar!!");
                    Console.WriteLine("b=");
                    read = Console.ReadLine();
                }
            }
            Numere numere = new Numere(a, b);
            numere.Adunare();
            numere.Diferenta();
            numere.Cat();
            numere.Produs();
            numere.Afisare();
            Console.ReadKey();
        }
    }
}
