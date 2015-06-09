using System;

namespace SpiralIteration
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int[][] v = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                v[i] = new int[m];
            }

            int c = 0;
            for (int y = 0; y < n; ++y)
            {
                for (int x = 0; x < m; ++x) {
                    v[y][x] = ++c;
                }
            }

            int maxX = m;
            int maxY = n;
            int offsetX = 0;
            int offsetY = 1;

            while (offsetY < maxY || offsetX < maxX)
            {
                // v[0][x: 0 -> m] = ...
                for (int x = offsetX; x < maxX; ++x)
                {
                    Console.WriteLine("{0}", v[offsetX][x]);
                }

                // v[y: offsetY -> maxY][maxX - 1] = ...
                for (int y = offsetY; y < maxY; ++y)
                {
                    Console.WriteLine("{0}", v[y][maxX - 1]);
                }

                --maxX;
                // v[maxY - 1][x: maxX - 1 -> offsetX] = ...
                for (int x = maxX - 1; x >= offsetX; --x)
                {
                    Console.WriteLine("{0}", v[maxY - 1][x]);
                }

                --maxY;
                // v[y: maxY - 1 -> offsetY][offsetX] = ...
                for (int y = maxY - 1; y >= offsetY; --y)
                {
                    Console.WriteLine("{0}", v[y][offsetX]);
                }


                ++offsetX;
                ++offsetY;
            }
        }
    }
}
