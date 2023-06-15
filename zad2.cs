namespace cwiczenia_10_06;
class Program2
{
   static void Main()
   {
        Console.WriteLine("Podaj ile chcesz wygenerować wyrazów ciągu Fibonacciego");
        int n = int.Parse(Console.ReadLine());
   }

   static void GenerujCiagFibonacci(int n)
   {
        int first = 0; // pierwszy
        int second = 1;  // drugi
        Console.WriteLine("Pierwsze {0} wyrazy ciągu Fibonacciego: ", n);

        // wypisywanie dwóch pierwszych wyrazów ciągu
        Console.Write("{0}{1}", first, second);

        for (int i = 2; i < n; i++)
        {   
            int next = first + second;
            Console.Write("{0}", next);

            // przesuwanie 
            first = second; 
            second = next; 
        }
   }
}
