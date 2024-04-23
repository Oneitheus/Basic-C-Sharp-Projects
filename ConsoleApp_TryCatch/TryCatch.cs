using System;
using System.Collections.Generic;

class TryCatch{
    static void Main(){
        List<int> intList = new List<int>() {10,20,30,45,56,67,78,99,100};
        bool exitLoop = false;
        while (!exitLoop){
            try{
                Console.WriteLine("Enter a Number");
                double dividend = Convert.ToDouble(Console.ReadLine());
                if (dividend == 0){
                    Console.WriteLine("Can not divide by 0");
                } else {
                    for (int i = 0; i < intList.Count; i++){
                        double result = intList[i]/dividend;
                        Console.WriteLine(intList[i] + "/" + dividend + " = " + result);
                    }
                    exitLoop = true;
                }
            }
            catch (FormatException e){
                Console.WriteLine("Only enter numbers.");
            }
            finally{
                Console.ReadLine();
            }
        }
    }
}