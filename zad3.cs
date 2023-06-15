using System;

class Zad3
{
    static void Main()
    {
        int n, k;
        
        // Wczytaj liczby n i k od użytkownika, upewnij się, że są prawidłowe
        do
        {
            Console.Write("Podaj liczbę n (n >= 5): ");
            n = int.Parse(Console.ReadLine());
        } while (n < 5);

        do
        {
            Console.Write("Podaj liczbę k (k >= 5): ");
            k = int.Parse(Console.ReadLine());
        } while (k < 5);

        // Oblicz n! i k!
        long factorialN = CalculateFactorial(n);
        long factorialK = CalculateFactorial(k);

        // Oblicz m
        long m = (factorialN - factorialK) / factorialK;

        // Wyświetl wynik
        Console.WriteLine("Wartość m = {0}", m);
    }

    // Funkcja do obliczania silni
    static long CalculateFactorial(int number)
    {
        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
