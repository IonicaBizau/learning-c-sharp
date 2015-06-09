using System;

namespace BinaryRepresentations
{
    class MainClass
    {
        static char[] IntRepresentation(int n)
        {
            char[] result = new char[32];

            int i = 0;
            int pos = 31;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    result[pos] = '1';
                }
                else
                {
                    result[pos] = '0';
                }
                ++i;
                --pos;
            }

            return result;
        }


        public static void Main(string[] args)
        {
            // 00000000000000000000000000101010
            Console.WriteLine(IntRepresentation(42));
        }
    }
}