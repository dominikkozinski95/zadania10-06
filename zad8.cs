using System;

class Zad8
{
    static void Main()
    {
        int min = 1;
        int max = 20;
        int guess;

        Console.WriteLine("Wybierz liczbę z przedziału od {0} do {1}.", min, max);

        while (true)
        {
            guess = (min + max) / 2;
            Console.WriteLine("Czy Twoja liczba to {0}? Odpowiedz ujemną, dodatnią lub zero:", guess);

            int response = int.Parse(Console.ReadLine());

            if (response < 0)
            {
                max = guess - 1;
            }
            else if (response > 0)
            {
                min = guess + 1;
            }
            else
            {
                Console.WriteLine("Zgadłem! Twoja liczba to {0}.", guess);
                break;
            }
        }
    }
}
