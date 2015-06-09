using System;

namespace TwoMatrices
{
	class MainClass
	{
		static bool isEqual (int sX, int sY, int[,] big, int[,] small)
		{
			for (int y = 0; y < small.GetLength(0); ++y) {
				for (int x = 0; x < small.GetLength(1); ++x) {
					if (big[sY + y, sX + x] != small[y, x]) {
						return false;
					}
				}
			}
			return true;
		}

		public static void Main (string[] args)
		{
			int[,] small = {
				{4, 1},
				{1, 2}
			};

			int[,] big = {
				{2, 3, 4, 5},
				{3, 4, 1, 2},
				{5, 1, 2, 5}
			};

			for (int y = 0; y <= big.GetLength(0) - small.GetLength(0); ++y) {
				for (int x = 0; x <= big.GetLength(1) - small.GetLength(1); ++x) {
					if (isEqual (x, y, big, small)) {
						Console.WriteLine ("x: {0}, y: {1}", x, y);
					}
				}
			}
		}
	}
}
