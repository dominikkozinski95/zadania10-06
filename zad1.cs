namespace cwiczenia_10_06;
class Program
{
    public static int Power(int baseNumber, int exponent)
    {
        int result = 1;
        
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        
        return result;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj podstawę potęgi");
        int baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wykładnik potęgi");
        int exponent = Convert.ToInt32(Console.ReadLine());

        int result = Power(baseNumber, exponent);
        
        Console.WriteLine($"{baseNumber} do potęgi {exponent} wynosi: {result}");
    }
}
