using System.Collections.ObjectModel;
using System.Collections.Specialized;

using System.Windows.Input;

namespace ZadaniaWPF.ModelWidoku
{
	public class Zadania
	{
		private const string ścieżkaPlikuXml = "zadania.xml";

		//przechowywanie dwóch kolekcji
		private Model.Zadania model;
		//public ObservableCollection<Zadanie> ListaZadań { get; } = new ObservableCollection<Zadanie>();
        public ObservableCollection<Zadanie> ListaZadań { get; private set; }

		private void KopiujZadania()
		{
			ListaZadań.CollectionChanged -= SynchronizacjaModelu;
			ListaZadań.Clear();
			foreach (Model.Zadanie zadanie in model) ListaZadań.Add(new Zadanie(zadanie));
			ListaZadań.CollectionChanged += SynchronizacjaModelu;
		}

		public Zadania()
		{
            ListaZadań = new ObservableCollection<Zadanie>();

			if (System.IO.File.Exists(ścieżkaPlikuXml))
				model = Model.PlikXML.Czytaj(ścieżkaPlikuXml);
			else model = new Model.Zadania();

			/*
			//testy - początek
			model.DodajZadanie(new Model.Zadanie("Pierwsze", DateTime.Now, DateTime.Now.AddDays(2), Model.PriorytetZadania.Ważne, false));
			model.DodajZadanie(new Model.Zadanie("Drugie", DateTime.Now, DateTime.Now.AddDays(2), Model.PriorytetZadania.Ważne, false));
			model.DodajZadanie(new Model.Zadanie("Trzecie", DateTime.Now, DateTime.Now.AddDays(1), Model.PriorytetZadania.MniejWażne, false));
			model.DodajZadanie(new Model.Zadanie("Czwarte", DateTime.Now, DateTime.Now.AddDays(3), Model.PriorytetZadania.Krytyczne, false));
			model.DodajZadanie(new Model.Zadanie("Piąte", DateTime.Now, new DateTime(2015, 03, 15, 1, 2, 3), Model.PriorytetZadania.Krytyczne, false));
			model.DodajZadanie(new Model.Zadanie("Szóste", DateTime.Now, new DateTime(2015, 03, 14, 1, 2, 3), Model.PriorytetZadania.Krytyczne, false));
			//testy - koniec
			*/

			KopiujZadania();
		}

		private void SynchronizacjaModelu(object sender, NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
					Zadanie noweZadanie = (Zadanie)e.NewItems[0];
					if (noweZadanie != null)
						model.DodajZadanie(noweZadanie.GetModel());
					break;
				case NotifyCollectionChangedAction.Remove:
					Zadanie usuwaneZadanie = (Zadanie)e.OldItems[0];
					if (usuwaneZadanie != null)
						model.UsuńZadanie(usuwaneZadanie.GetModel());
					break;
			}
		}

		private ICommand zapiszCommand;

		public ICommand Zapisz
		{
			get
			{
				if (zapiszCommand == null)
					zapiszCommand = new RelayCommand(argument => { Model.PlikXML.Zapisz(ścieżkaPlikuXml, model); });
				return zapiszCommand;
			}
		}

	    private ICommand usuńZadanie;

		public ICommand UsuńZadanie
		{
			get
			{
				if (usuńZadanie == null)
					usuńZadanie = new RelayCommand(
						o =>
						{
							int indeksZadania = (int)o;
							Zadanie zadanie = ListaZadań[indeksZadania];
							ListaZadań.Remove(zadanie);
						},
						o =>
						{
							if (o == null) return false;
							int indeksZadania = (int)o;
							return indeksZadania >= 0;
						});
				return usuńZadanie;
			}
		}

		private ICommand dodajZadanie;

		public ICommand DodajZadanie
		{
			get
			{
				if (dodajZadanie == null)
					dodajZadanie = new RelayCommand(
						o =>
						{
							Zadanie zadanie = o as Zadanie;
							if (zadanie != null) ListaZadań.Add(zadanie);
						},
						o =>
						{
							return (o as Zadanie) != null;
						});
				return dodajZadanie;
			}
		}

		private ICommand sortujZadania;

		public ICommand SortujZadania
		{
			get
			{
				if (sortujZadania == null)
					sortujZadania = new RelayCommand(
						o =>
						{
							bool porównywaniePriorytetówCzyPlanowanychTerminówRealizacji = bool.Parse((string)o);
							model.SortujZadania(porównywaniePriorytetówCzyPlanowanychTerminówRealizacji);
							KopiujZadania();
						});
				return sortujZadania;
			}
		}

		private ICommand eksportujZadaniaDoPlikuTekstowego;

		public ICommand EksportujZadaniaDoPlikuTekstowego
		{
			get
			{
				if (eksportujZadaniaDoPlikuTekstowego == null)
					eksportujZadaniaDoPlikuTekstowego = new RelayCommand(
						o =>
						{
							string ścieżkaPliku = (string)o;
							Model.PlikTXT.Zapisz(ścieżkaPliku, model);
						});
				return eksportujZadaniaDoPlikuTekstowego;
			}
		}
	}
}
