using System;

namespace LinkedLists
{
	public class LinkedList
	{
		private Node head = null;
		public void AddLast (object data) {
			if (head == null) {
				head = new Node();
				head.data = data;
			} else {
				Node n = new Node();
				n.data = data;

				Node c = head;
				while (c.next != null) {
					c = c.next;
				}

				c.next = n;
			}
		}

		public void AddFirst (object data) {
			Node n = new Node ();
			n.data = data;
			n.next = head;
			head = n;
		}

		public void printAllNodes() {
			Node c = head;
			while (c != null)
			{
				Console.WriteLine(c.data);
				c = c.next;
			}
		}
	}

}
