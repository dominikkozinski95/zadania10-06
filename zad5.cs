using System;

class Zad5
{
    static void Main()
    {
        double x, approximation;
        int n;

        // Wczytaj dane od użytkownika
        Console.Write("Podaj wartość x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę wyrazów n: ");
        n = int.Parse(Console.ReadLine());

        // Oblicz przybliżoną wartość funkcji e^x za pomocą szeregu Taylora
        approximation = CalculateExponential(x, n);

        // Wyświetl wynik
        Console.WriteLine("Przybliżona wartość funkcji e^{0} = {1}", x, approximation);
    }

    // Funkcja do obliczania przybliżonej wartości funkcji e^x za pomocą szeregu Taylora
    static double CalculateExponential(double x, int n)
    {
        double result = 1.0; // Pierwszy wyraz szeregu (n=0)

        for (int i = 1; i <= n; i++)
        {
            double term = Math.Pow(x, i) / CalculateFactorial(i);
            result += term;
        }

        return result;
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
