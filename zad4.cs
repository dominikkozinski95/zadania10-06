 using System;

class Zad4
{
    static void Main()
    {
        double initialAmount, annualInterestRate;
        int months;

        // Wczytaj dane od użytkownika
        Console.Write("Podaj kwotę początkową: ");
        initialAmount = double.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie w skali roku: ");
        annualInterestRate = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        months = int.Parse(Console.ReadLine());

        // Oblicz końcową kwotę z uwzględnieniem oprocentowania i podatku Belki
        double interestRatePerMonth = annualInterestRate / 12;
        double finalAmount = initialAmount;

        for (int i = 0; i < months; i++)
        {
            double monthlyInterest = finalAmount * (interestRatePerMonth / 100);
            finalAmount += monthlyInterest;

            // Naliczanie podatku Belki (19%)
            double tax = monthlyInterest * 0.19;
            finalAmount -= tax;
        }

        // Wyświetl końcową kwotę
        Console.WriteLine("Końcowa kwota: {0}", finalAmount);
    }
}
