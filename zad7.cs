using System;

class Zad7
{
    static void Main()
    {
        int n;

        // Wczytaj liczbę n od użytkownika
        Console.Write("Podaj liczbę n: ");
        n = int.Parse(Console.ReadLine());

        // Wypisz wszystkie pary liczb naturalnych o sumie n
        Console.WriteLine("Pary liczb o sumie {0}:", n);

        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine("{0} + {1} = {2}", i, j, n);
        }
    }
}
