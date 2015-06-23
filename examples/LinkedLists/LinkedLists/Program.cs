using System;

namespace LinkedLists
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			LinkedList ll = new LinkedList ();
			ll.AddLast ("Hello");
			ll.AddLast ("World");
			ll.AddFirst ("Hello there!");
			ll.printAllNodes ();
		}
	}
}
