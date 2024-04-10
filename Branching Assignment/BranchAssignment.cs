using System;

class BranchingAssignment{
    static void Main(){
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        // Package Weight
        Console.WriteLine("Enter Package Weight:");
        double weight = Convert.ToDouble(Console.ReadLine());
        // If weight > 50 then end.
        if (weight > 50){
            Console.WriteLine("Package too heavy. Bye.");
            Console.ReadLine();
            return;
        }
        
        // Ask for dimensions; Width, Height Length.
        Console.WriteLine("Enter Width:");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Height:");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Length:");
        double length = Convert.ToDouble(Console.ReadLine());
        // Check if dimension > 50
        double dimensions = width + height + length;
        if (dimensions > 50){
            Console.WriteLine("Package too big. Bye.");
            Console.ReadLine();
            return;
        }
        // Calculate the quote
        double quote = ((width*height*length)*weight)/100;
        Console.WriteLine("Quote: $"+quote.ToString("0.####"));
        Console.ReadLine();
    }
}