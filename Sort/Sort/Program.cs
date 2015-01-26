using System;

namespace Sort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] x = { -1, 4, 2, 10, 0 };
			for (var i = 0; i < x.Length; ++i) {
				for (int j = 0; j < x.Length; j++) {
					if (x[i] < x[j]) {
						int aux = x[j];
						x[j] = x[i];
						x[i] = aux;
					}
				}
			}
			foreach (var item in x) {
				Console.Write("{0} ", item);
			}
		}
	}
}
