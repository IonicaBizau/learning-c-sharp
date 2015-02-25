using System;

namespace PooHelloWorld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			World foo = new World ();
			foo.SayHello ();

			World foo2 = new World("Bar");
			foo2.SayHello ();
		}
	}
}
