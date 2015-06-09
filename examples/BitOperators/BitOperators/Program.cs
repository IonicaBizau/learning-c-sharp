using System;

namespace BitOperators
{
    class MainClass
    {
        // 0 -> 1
        // 1 -> 0
        // -----------------------
        // e.g. n == 42, k = 1
        //         n:  1 0 1 0 1 0
        //    1 << k:  0 0 0 0 1 0
        // result(^):  1 0 1 0 0 0
        //  position:  5 4 3 2 1 0
        static int FlipBit(int n, int k)
        {
            return n ^ (1 << k);
        }

        // 1 -> 1
        // 0 -> 1
        // -----------------------
        // e.g. n == 42, k = 2
        //         n:  1 0 1 0 1 0
        //    1 << k:  0 0 0 1 0 0
        // result(|):  1 0 1 1 1 0
        //  position:  5 4 3 2 1 0
        //    change:        ^
        static int SetBit(int n, int k)
        {
            return n | (1 << k);
        }

        // 1 -> 0
        // 0 -> 0
        // -----------------------
        // e.g. n == 42, k = 3
        //         n:  1 0 1 0 1 0
        //    1 << k:  0 0 1 0 0 0
        //         ~:  1 1 0 1 1 1
        // result(&):  1 0 0 0 1 0
        //  position:  5 4 3 2 1 0
        static int ResetBit(int n, int k)
        {
            return n & ~(1 << k);
        }


        // e.g. n == 42, k = 4
        //         n:  1 0 1 0 1 0
        //    n >> k:  0 0 0 0 1 0
        //         1:  0 0 0 0 0 1
        // result(&):  0 0 0 0 0 0
        //  position:  5 4 3 2 1 0
        static int GetBit(int n, int k)
        {
            return n >> k & 1;
        }

        public static void Main(string[] args)
        {
            // Decimal:  42
            // Binary:   1 0 1 0 1 0
            //           -----------
            // Position: 5 4 3 2 1 0
            int number = 42;

            Console.WriteLine(FlipBit(number, 1));  // 101000 -> 40
            Console.WriteLine(SetBit(number, 2));   // 101110 -> 46
            Console.WriteLine(ResetBit(number, 3)); // 100010 -> 34
            Console.WriteLine(GetBit(number, 4));   // 0      -> 0
        }
    }
}