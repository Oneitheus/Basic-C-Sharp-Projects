using System;

class Program
{
    static void Main()
    {
        // x * 50
        int xFifty = Int32.Parse(Console.ReadLine());
        Console.WriteLine(xFifty*50);
        // +25
        int plus25 = Int32.Parse(Console.ReadLine());
        Console.WriteLine(plus25+25);
        // Divide by 12.5
        double div125 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(div125/12.5);
        // Boolean (>50)
        int gt50 = Int32.Parse(Console.ReadLine());
        Console.WriteLine(gt50>50);
        // Modulus divide by 7
        double div7 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(div7%7);
    }
}