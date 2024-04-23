using System;

namespace methods{
    class Methods{
        public void addition(int num1,int num2){
            // Addition
            Console.WriteLine(num1+num2);
            //Do math operation on the first integer
            int plus40 = num1+40;
            // Display the second integer to the screen
            Console.WriteLine(num2);
        }
    }
}

namespace run{
    using methods;
    class mainClass{
        public static void Main(){
            // Instantiate
            Methods mathObj = new Methods(); 
            // Call method
            mathObj.addition(5,5);
            // Call method but specified
            mathObj.addition(num1: 10, num2:5);
            Console.ReadLine();
        }
    }
}