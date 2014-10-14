using System;

namespace Sum
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            Console.Write ("n = ");
            string input = Console.ReadLine ();
            int n = 0;
            try {
                n = int.Parse (input);
            } catch (Exception) {
                Console.WriteLine ("Invalid input");
            }
            Console.WriteLine (Sum(n).ToString());
        }

        public static int Sum(int n) {
            return n * (n + 1) / 2;
        }
    }
}
