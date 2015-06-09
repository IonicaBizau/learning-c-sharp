using System;

namespace Inheritance
{
	public class Token
	{
		string name = "";
		protected Token (string name) {
			this.name = name;
		}

		public static string operator + (Token t1, Token t2) {
			return t1.name + " _ " + t2.name;
		}

		public string getName () {
			return this.name;
		}

		public virtual void Test () {
		}
	}

}
