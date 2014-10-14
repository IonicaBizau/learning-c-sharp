using System;

namespace Celsiusfahrenheit
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            Console.Write ("Celsius: ");
            string line = Console.ReadLine ();
            float value = 0;
            try {
                value = float.Parse(line);
            } catch (Exception ex) {
                Console.WriteLine ("Invalid input value.");
                Environment.Exit (1);
            }
            Console.WriteLine ((value * 1.8 + 32).ToString());
        }
    }
}
