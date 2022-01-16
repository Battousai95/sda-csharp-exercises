using System;

namespace sda_csharp_exercises
{
    class Program
    {

        static void Potegowanie(int podstawa, int wykladnik)
        {
            int wynik = podstawa;
            for(int i=1;i<wykladnik;i++)
            {
                wynik *= podstawa;
            }
            Console.Write($"Wynik: {wynik}");
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj podstawę i wykładnik: ");
            string s = Console.ReadLine();
            string[] a = s.ToString().Split(' ');

            if (int.Parse(a[1]) > 0)
                Potegowanie(int.Parse(a[0]), int.Parse(a[1]));
            else
                Console.WriteLine("Zły wykładnik");
        }
    }
}
