/*
 * 
 * Se dă un fișier text care conține pe prima linie un număr n de
 * angajați, iar pe următoarele linii informații ale acestora sub
 * forma: <nume> <departament> <data-ang>
 * 
 * Sa se creeze o colecție de date care și să se afișeze într-un
 * fisier de iesire  lista alfabetică a departamentelor, iar pentru
 * fiecare departament, lista alfabetică a angajaților.
 */


using System;
using System.IO;
using System.Collections.Generic;
using System.Data;

namespace angajati
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string inputFilePath = "./angajati.txt";
			string outputFilePath = "./rezultat.txt";

			if (!File.Exists (inputFilePath)) {
				Console.WriteLine ("The input file doesn't exist.");
				Environment.Exit (1);
			}


			StreamReader sr = new StreamReader (inputFilePath);
			StreamWriter sw = new StreamWriter (outputFilePath);
			string[] lines = sr.ReadToEnd ().Split('\n');
			int count = int.Parse(lines [0]);
			// [
			//    [ "Dep1", "Name", "Date", <dep-id> ] 
			// ]

			DataTable dt = new DataTable();
			dt.Columns.Add("Department");
			dt.Columns.Add("Name");
			dt.Columns.Add("Date");

			for (int i = 1; i <= count; ++i) {
				string[] cLine = lines [i].Split(' ');
				if (cLine.Length != 3) {
					continue;
				} 
				DataRow row = dt.NewRow();
				row[0] = cLine[1];
				row[1] = cLine[0];
				row[2] = cLine[2];
				dt.Rows.Add(row);
			}

			DataView view = dt.DefaultView;
			view.Sort = "Department ASC, Name ASC";

			string lastDep = "";
			for (int i = 0; i < count; ++i) {
				if (lastDep != view.ToTable().Rows[i][0].ToString()) {
					lastDep = view.ToTable ().Rows [i] [0].ToString();
					sw.WriteLine("> Departament: " + lastDep);
				}
				sw.WriteLine (">>> Angajat: " + view.ToTable ().Rows [i] [1].ToString() + " Data angajării: " + view.ToTable ().Rows [i] [2].ToString());
			}
			sw.Close ();
		}
	}
}
