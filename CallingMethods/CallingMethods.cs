using System;

namespace CallingMethods{
    public class Methods{
        public static int increment(int num){
            return num++;
        }
        public static int decrement(int num){
            return num--;
        }
        public static int multiplyBy10(int num){
            return num*10;
        }
    }
}

namespace mainMethod
{
    using System;
    using CallingMethods;

    class MainClass{
        static void Main(){
            int inc = Methods.increment(5);
            Console.WriteLine(inc);
            Console.ReadLine();
        }
    }
}