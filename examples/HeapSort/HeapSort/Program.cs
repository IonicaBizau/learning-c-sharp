using System;

namespace HeapSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			HeapS s = new HeapS ();
			int[] foo = new int[5] { 1, 42, 0, 2, 1 };
			s.sort (foo);
			s.show(foo);
		}
	}
}
