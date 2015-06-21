using System;

namespace HeapSort
{
	public class HeapS {
		public HeapS () {}

		/// <summary>
		/// Sorteaza vectorul folosind ordinea naturala. Se creeaza un MaxHeap dupa care elementul maxim se interschimba cu cel de pe ultima pozitie.
		/// Se restabileste ordinea heap fara a tine cont de elementul de pe ultima pozitie (N--) iar procesul se repeta 
		/// pana cand dimensiunea vectorului devine 0
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="pq">Vectorul care se sorteaza</param>
		public void sort<T>(T[] pq) where T: IComparable<T>
		{
			int N = pq.Length;
			for (int k = N / 2; k >= 1; k--)
				sink(pq, k, N);
			while (N > 1)
			{
				exch(pq, 1, N--);
				sink(pq, 1, N);
			}
		}

		/// <summary>
		/// Metoda ajutatoare care ne ajuta se restauram invariantul pentru heap
		/// </summary>
		/// <param name="pq"></param>
		/// <param name="k"></param>
		/// <param name="N"></param>
		private static void sink<T>(T[] pq, int k, int N) where T: IComparable<T>
		{
			while (2 * k <= N)
			{
				int j = 2 * k;
				if (j < N && less(pq, j, j + 1)) 
					j++;
				if (!less(pq, k, j)) 
					break;
				exch(pq, k, j);
				k = j;
			}
		}
		private static bool less<T>(T[] pq, int i, int j) where T:IComparable<T>
		{
			return pq[i - 1].CompareTo(pq[j - 1]) < 0;
		}

		private static void exch<T>(T[] pq, int i, int j) where T: IComparable<T>
		{
			T swap = pq[i - 1];
			pq[i - 1] = pq[j - 1];
			pq[j - 1] = swap;
		}


		private static bool less<T>(T v, T w) where T:IComparable<T>
		{
			return (v.CompareTo(w) < 0);
		}
		/// <summary>
		/// Verifica daca vectorul este sortat
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="a"></param>
		/// <returns></returns>
		private static bool isSorted<T>(T[] a) where T : IComparable<T>
		{
			for (int i = 1; i < a.Length; i++)
				if (less(a[i], a[i - 1])) 
					return false;
			return true;
		}


		/// <summary>
		/// Afiseaza elementele vectorului la consola
		/// </summary>
		/// <param name="a">Vectorul care se afiseaza</param>
		public void show<T>(T[] a) where T : IComparable<T>
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
		}
	}
}
