using System;

namespace Exercitiu4
{
    class Greutate
    {
        int inaltime;
        int varsta;
        string gen;
        double greutateM;
        double greutateF;

        public Greutate(int inaltime, int varsta, string gen)
        {
            this.inaltime = inaltime;
            this.varsta = varsta;
            this.gen = gen;
        }

        public void GreutateM()
        {
            this.greutateM = inaltime - 100 - (inaltime - 150) / 4 + (varsta - 20) / 4;
        }

        public void GreutateF()
        {
            this.greutateF = inaltime - 100 - Convert.ToDouble((inaltime) - 150) / 2.5 + (varsta - 20) / 6;
        }

        public void Afisare()
        {
            if (gen == "M")
                Console.WriteLine("Greutatea ideala pentru dvs. este : " + greutateM);
            if (gen == "F")
                Console.WriteLine("Greutatea ideala pentru dvs. este : " + greutateF);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string read;
            bool ok = false;
            string gen="";
            int inaltime=0;
            int varsta=0;
            Console.WriteLine("Introduceti sexul dvs. (M sau F): ");
            read = Console.ReadLine();
            while (ok == false)
            {
                if (read == "M" || read == "F")
                {
                    ok = true;
                    gen = read;
                }
                else
                {
                    Console.WriteLine("Reintroduceti sexul dvs. (M sau F): ");
                    read = Console.ReadLine();
                }
            }
            ok = false;
            Console.WriteLine("Introduceti inaltimea (in cm !) ");
            read = Console.ReadLine();
            while (ok == false)
            {
                try
                {
                    inaltime = int.Parse(read);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Reintroduceti inaltimea (in cm !) ");
                    read = Console.ReadLine();
                }
            }
            ok = false;
            Console.WriteLine("Introduceti varsta dvs ");
            read = Console.ReadLine();
            while (ok == false)
            {
                try
                {
                    varsta = int.Parse(read);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Reintroduceti varsta dvs ");
                    read = Console.ReadLine();
                }
            }
            Greutate greutateaideala = new Greutate(inaltime, varsta, gen);
            greutateaideala.GreutateF();
            greutateaideala.GreutateM();
            greutateaideala.Afisare();
            Console.ReadKey();
        }
    }
}
