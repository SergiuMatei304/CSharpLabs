using System;
using System.Globalization;

namespace Exercitiul3
{
    class Temperatura
    {
        float temperaturaC;
        float temperaturaF;
        string grade;
        public Temperatura(float temperatura,string grade)
        {
            if(grade== "C")
                this.temperaturaC = temperatura;
            if (grade == "F")
                this.temperaturaF = temperatura;
            this.grade = grade;
        }
        public void convertToF()
        {
            if(grade == "C")
                this.temperaturaF = temperaturaC * 9 / 5 + 32;
        }
        public void convertToC()
        {
            if (grade == "F")
                this.temperaturaC = (temperaturaF - 32) * 5 / 9;
        }
        public void Afisare()
        {
            Console.WriteLine("Temperatura in grade C : " + temperaturaC);
            Console.WriteLine("Temperatura in grade F : " + temperaturaF);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string read;
            string grade;
            float numarGrade=0;
            bool ok = false;
            Console.WriteLine("Introduceti tipul de grade (F sau C) : ");
            grade = Console.ReadLine();
            while (ok == false)
            {
                if(grade== "C" || grade== "F")
                    ok = true;
                else
                {
                    Console.WriteLine("Reintroduceti tipul de grade(F sau C) : ");
                    grade = Console.ReadLine();
                }
            }
            ok = false;
            Console.WriteLine("Introduceti numarul de grade : ");
            read = Console.ReadLine();
            while (ok == false)
            {
                try
                {
                    numarGrade = float.Parse(read);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Reintroduceti numarul de grade : ");
                    read = Console.ReadLine();
                }
            }
            Temperatura temperatura = new Temperatura(numarGrade, grade);
            temperatura.convertToC();
            temperatura.convertToF();
            temperatura.Afisare();
            Console.ReadKey();
        }
    }
}
