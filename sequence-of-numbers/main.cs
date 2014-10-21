/**
 * Usage:
 *  ./Sequence.exe <n>
 *  Where <n> should be an integer greater than 0.
 *
 * </> with <3 and C# by Ionică Bizău
 * */
using System;

namespace Secvente {
    class Secvente {

        static void printNumber (int x, bool end) {
            Console.Write("{0}" + (end ? "\n" : ", "), x);
        }

        static void Main(string[] args) {
            int n = -1;

            try {
                n = int.Parse(args[0]);
                if (n <= 0) {
                    throw new Exception("Invalid input.");
                }
            } catch (Exception) {
                n = 42;
                Console.WriteLine("Invalid input. n takes the default value: 42");
            }

            /*
             * 1
             * 1 2
             * 1 2 3
             * 1 2 3 4
             * => 1 1 2 1
             * */
            var line = 1;
            var col = 0;
            for (int i = 1; i <= n; ++i) {
                printNumber(++col, i == n);
                if (col == line) {
                    ++line;
                    col = 0;
                }
            }

            /*
             * 1
             * 2 3
             * 3 4 5
             * 4 5 6 7
             * => 1 2 3 3
             * */
            line = 1;
            col = 0;
            bool end = false;
            while (true) {
                end = !Convert.ToBoolean(--n);
                int x = line + (++col) - 1;
                printNumber(x, end);
                if (end) {
                    break;
                }
                if (col == line) {
                    ++line;
                    col = 0;
                }
            }
        }
    }
}
