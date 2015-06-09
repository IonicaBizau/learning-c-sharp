using System;
using System.Collections.Generic;

namespace ConvertToAnyBase
{
    class MainClass
    {
        public static string[] allChars = new string[]
        {
            "0","1","2","3","4","5","6","7","8","9",
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        };

        public static string IntToString(int b, int x)
        {
            string result = "";
            string[] baseChars = new List<string>(allChars).GetRange(0, b).ToArray();
            do
            {
                result = baseChars[x % b] + result;
                x /= b;
            } while (x > 0);

            return result;
        }

        public static void Main (string[] args)
        {
            Console.Write ("x = ");
            int x = int.Parse (Console.ReadLine ());

            Console.Write ("b = ");
            int b = int.Parse (Console.ReadLine ());

            Console.WriteLine ("{0} in base {1} is {2}", x, b, IntToString (b, x));
        }
    }
}
