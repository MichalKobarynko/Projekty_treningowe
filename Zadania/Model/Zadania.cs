using System;
using System.Collections.Generic;

using System.Collections;

namespace ZadaniaWPF.Model
{
	public class Zadania : IEnumerable<Zadanie>
	{
		private List<Zadanie> listaZadań = new List<Zadanie>();

		public void DodajZadanie(Zadanie zadanie)
		{
			listaZadań.Add(zadanie);
		}

		public bool UsuńZadanie(Zadanie zadanie)
		{
			return listaZadań.Remove(zadanie);
		}

		public int LiczbaZadań
		{
			get
			{
				return listaZadań.Count;
			}
		}

		public Zadanie this[int indeks]
		{
			get
			{
				return listaZadań[indeks];
			}
		}

		public IEnumerator<Zadanie> GetEnumerator()
		{
			return listaZadań.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)this.GetEnumerator();
		}

		private Comparison<Zadanie> porównywaniePriorytetów = new Comparison<Zadanie>(
			(Zadanie zadanie1, Zadanie zadanie2) =>
			{
				int wynik = -zadanie1.Priorytet.CompareTo(zadanie2.Priorytet);
				if (wynik == 0) wynik = zadanie1.PlanowanyTerminRealizacji.CompareTo(zadanie2.PlanowanyTerminRealizacji);
				return wynik;
			});

		private Comparison<Zadanie> porównywaniePlanowanychTerminówRealizacji = new Comparison<Zadanie>(
			(Zadanie zadanie1, Zadanie zadanie2) =>
			{
				int wynik = zadanie1.PlanowanyTerminRealizacji.CompareTo(zadanie2.PlanowanyTerminRealizacji);
				if (wynik == 0) wynik = -zadanie1.Priorytet.CompareTo(zadanie2.Priorytet);
				return wynik;
			});

		public void SortujZadania(bool porównywaniePriorytetówCzyPlanowanychTerminówRealizacji)
		{
			if (porównywaniePriorytetówCzyPlanowanychTerminówRealizacji)
				listaZadań.Sort(porównywaniePriorytetów);
			else
				listaZadań.Sort(porównywaniePlanowanychTerminówRealizacji);
		}
	}
}
