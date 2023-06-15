using System;

class Zad6
{
    static void Main()
    {
        int x;
        int n = 1;

        // Wczytaj liczbę x od użytkownika
        Console.Write("Podaj liczbę x: ");
        x = int.Parse(Console.ReadLine());

        // Sprawdź czy x jest silnią liczby n
        while (CalculateFactorial(n) < x)
        {
            n++;
        }

        // Jeśli x jest silnią liczby n, wypisz n
        if (CalculateFactorial(n) == x)
        {
            Console.WriteLine("Liczba {0} jest silnią liczby {1}", x, n);
        }
        else
        {
            Console.WriteLine("Liczba {0} nie jest silnią żadnej liczby", x);
        }
    }

    // Funkcja do obliczania silni
    static long CalculateFactorial(int number)
    {
        long factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
