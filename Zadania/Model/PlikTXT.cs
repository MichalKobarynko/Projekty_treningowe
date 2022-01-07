using System.Collections.Generic;

namespace ZadaniaWPF.Model
{
	public static class PlikTXT
	{
		public static void Zapisz(string ścieżkaPliku, Zadania zadania)
		{
			if (!string.IsNullOrWhiteSpace(ścieżkaPliku))
			{
				List<string> opisyZadań = new List<string>();
				foreach (Zadanie zadanie in zadania) opisyZadań.Add(zadanie.ToString());
				System.IO.File.WriteAllLines(ścieżkaPliku, opisyZadań.ToArray());
			}
		}
    }
}
