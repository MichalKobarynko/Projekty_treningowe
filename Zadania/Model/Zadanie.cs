using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaWPF.Model
{
	public enum PriorytetZadania : byte { MniejWażne, Ważne, Krytyczne };

	public class Zadanie
	{
		public string Opis { get; private set; }
		public DateTime DataUtworzenia { get; private set; }
		public DateTime PlanowanyTerminRealizacji { get; private set; }
		public PriorytetZadania Priorytet { get; private set; }
		public bool CzyZrealizowane { get; set; }// = false;

		public Zadanie(string opis, DateTime dataUtworzenia, DateTime planowanyTerminRealizacji, PriorytetZadania priorytetZadania, bool czyZrealizowane)			
		{
			this.Opis = opis;
			this.DataUtworzenia = dataUtworzenia;
			this.PlanowanyTerminRealizacji = planowanyTerminRealizacji;
			this.Priorytet = priorytetZadania;
			this.CzyZrealizowane = czyZrealizowane;
		}

		public static string OpisPriorytetu(PriorytetZadania priorytet)
		{
			switch (priorytet)
			{
				case PriorytetZadania.MniejWażne:
					return "mniej ważne";
				case PriorytetZadania.Ważne:
					return "ważne";
				case PriorytetZadania.Krytyczne:
					return "krytyczne";
				default:
					throw new Exception("Nierozpoznany priorytet zadania");
			}
		}

		public static PriorytetZadania ParsujOpisPriorytetu(string opisPriorytetu)
		{
			switch (opisPriorytetu)
			{
				case "mniej ważne":
					return PriorytetZadania.MniejWażne;
				case "ważne":
					return PriorytetZadania.Ważne;
				case "krytyczne":
					return PriorytetZadania.Krytyczne;
				default:
					throw new Exception("Nierozpoznany opis priorytetu zadania");
			}
		}

		public override string ToString()
		{
			return Opis + ", priorytet: " + OpisPriorytetu(Priorytet) + ", data utworzenia: " + DataUtworzenia + ", planowany termin realizacji: " + PlanowanyTerminRealizacji.ToString() + ", " + (CzyZrealizowane ? "zrealizowane" : "niezrealizowane");
		}
	}

	public static class Rozszerzenia
	{
		public static string OpisPriorytetu(this PriorytetZadania priorytet)
		{
			switch (priorytet)
			{
				case PriorytetZadania.MniejWażne:
					return "mniej ważne";
				case PriorytetZadania.Ważne:
					return "ważne";
				case PriorytetZadania.Krytyczne:
					return "krytyczne";
				default:
					throw new Exception("Nierozpoznany priorytet zadania");
			}
		}
	}
}
