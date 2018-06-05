using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia
{
    class Program
    {
        static void Main()
        {
            int pierwszaLiczba = 10, durgaLiczba = 20, i = 15, j = 5, k = 25;
            Console.WriteLine("Pierwsza Liczba: " + pierwszaLiczba);
            Console.WriteLine("Durga Liczba: " + durgaLiczba);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.ReadLine();

            for (int a = 0; a < 1000; a++)
                Console.WriteLine(a);

           Console.ReadLine();
            

        }
    }
    class Pierwiastki
    {
        static void Main()
        {
            double parametrA = 1, parametrB = 5, parametrC = 4;
            Console.WriteLine("Parametry równania: \n");
            Console.WriteLine("A= " + parametrA + "B= " + parametrB + "C= " + parametrC + "\n");

            if (parametrA == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe! \n");
            }
            else
            {
                double delta = parametrB * parametrB - 4 * parametrA * parametrC;
                if (delta < 0)
                {
                    Console.WriteLine("Delta < 0 \n");
                    Console.WriteLine("Nie można policzyć delty \n");
                }
                else if (delta == 0)
                {
                    double wynik;
                    wynik = -parametrB / 2 * parametrA;
                    Console.WriteLine("x= " + wynik);
                }

                else
                {
                    double wynik;
                    wynik = -parametrB + Math.Sqrt(delta) / (2 * parametrA);
                    Console.WriteLine("x1 = " + wynik);
                    wynik = -parametrB - Math.Sqrt(delta) / (2 * parametrA);
                    Console.WriteLine("x2= " + wynik);
                }
            }
        }
    }
}