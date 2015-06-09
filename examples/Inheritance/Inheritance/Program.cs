using System;

namespace Inheritance
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			CommentToken t1 = new CommentToken ("Hello");
			CommentToken t2 = new CommentToken ("World");
			Console.WriteLine (t1 + t2);
			Console.WriteLine (t1.getName());
		}
	}
}
