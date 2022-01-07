using System;

using System.ComponentModel;
using System.Windows.Input;

namespace ZadaniaWPF.ModelWidoku
{
	public class Zadanie : INotifyPropertyChanged
	{
		private Model.Zadanie model;

		public string Opis
		{
			get
			{
				return model.Opis;
			}
		}

		public Model.PriorytetZadania Priorytet
		{
			get
			{
				return model.Priorytet;
			}
		}

		public DateTime DataUtworzenia
		{
			get
			{
				return model.DataUtworzenia;
			}
		}

		public DateTime PlanowanyTerminRealizacji
		{
			get
			{
				return model.PlanowanyTerminRealizacji;
			}
		}

		public bool CzyZrealizowane
		{
			get
			{
				return model.CzyZrealizowane;
			}
		}

		public bool CzyZadaniePozostajeNiezrealizowanePoPlanowanymTerminie
		{
			get
			{
				return !CzyZrealizowane && (DateTime.Now > PlanowanyTerminRealizacji);
			}
		}

		public Zadanie(Model.Zadanie zadanie)
		{
			this.model = zadanie;
		}

		public Zadanie(string opis, DateTime dataUtworzenia, DateTime planowanyTerminRealizacji, Model.PriorytetZadania priorytetZadania, bool czyZrealizowane)
		{
			model = new Model.Zadanie(opis, dataUtworzenia, planowanyTerminRealizacji, priorytetZadania, czyZrealizowane);
		}

		public Model.Zadanie GetModel()
		{
			return model;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(params string[] nazwyWłasności)
		{
			if (PropertyChanged != null)
			{
				foreach (string nazwaWłasności in nazwyWłasności)
					PropertyChanged(this, new PropertyChangedEventArgs(nazwaWłasności));
			}
		}

		ICommand oznaczJakoZrealizowane = null;

		public ICommand OznaczJakoZrealizowane
		{
			get
			{
				if (oznaczJakoZrealizowane == null)
					oznaczJakoZrealizowane = new RelayCommand(
						o =>
						{
							model.CzyZrealizowane = true;
							OnPropertyChanged("CzyZrealizowane", "CzyZadaniePozostajeNiezrealizowanePoPlanowanymTerminie");
						},
						o =>
						{
							return !model.CzyZrealizowane;
						});
				return oznaczJakoZrealizowane;
			}
		}

		ICommand oznaczJakoNiezrealizowane = null;

		public ICommand OznaczJakoNiezrealizowane
		{
			get
			{
				if (oznaczJakoNiezrealizowane == null)
					oznaczJakoNiezrealizowane = new RelayCommand(
						o =>
						{
							model.CzyZrealizowane = false;
							OnPropertyChanged("CzyZrealizowane", "CzyZadaniePozostajeNiezrealizowanePoPlanowanymTerminie");
						},
						o =>
						{
							return model.CzyZrealizowane;
						});
				return oznaczJakoNiezrealizowane;
			}
		}
	}
}