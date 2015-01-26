using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace IntegerValuesCount
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Read numbers and build the integer array
			StreamReader sr = new StreamReader ("./values.txt");
			int[] numbers = new int[50];
			string x;
			int i = -1;
			while ((x = sr.ReadLine()) != null) {
				numbers [++i] = int.Parse(x);
			}
			sr.Close ();

			// Check what is the number that appears 
			var dict = new Dictionary<int, int>();
			for (int j = 0; j <= i; ++j) {
				if (!dict.ContainsKey (numbers[j])) {
					dict[numbers[j]] = 1;
				} else {
					++dict [numbers[j]];
				}
			}

			var ordered = from entry in dict orderby entry.Value descending select entry;

			Console.WriteLine(ordered.ToList ()[0].Key);
		}
	}
}