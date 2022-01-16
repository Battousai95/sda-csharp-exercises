using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Wyswietl(int mnoznik)
        {
            Console.WriteLine($"Liczba sztuk: {mnoznik} łączna cena: {mnoznik * 5}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ile linii: ");
            int linie = int.Parse(Console.ReadLine());

            for (int i = 1; i <= linie; i++)
                Wyswietl(i);
        }
    }
}
