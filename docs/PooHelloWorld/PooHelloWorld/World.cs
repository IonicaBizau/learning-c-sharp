using System;

namespace PooHelloWorld
{
	public class World
	{
		string f = "<none>";
		public World() {}
		public World(string foo) {
			f = foo;
		}

		public void SayHello() {
			Console.WriteLine ("Hello, {0}", f);
		}
	}
}

