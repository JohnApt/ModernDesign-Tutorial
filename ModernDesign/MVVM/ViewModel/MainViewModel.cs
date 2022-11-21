using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
	class MainViewModel : ObservableObject
	{
		public RelayCommand HomeViewCommand { get; set; }

		public RelayCommand DiscoverViewCommand { get; set; }


		public HomeViewModel HomeVM { get; set; }

		public DiscoverViewModel DiscoverVM { get; set; }

		private object _currentView;

		public object currentView
		{
			get { return _currentView; }
			set
			{
				_currentView = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel()
		{
			HomeVM = new HomeViewModel();
			DiscoverVM = new DiscoverViewModel();

			currentView = HomeVM;

			HomeViewCommand = new RelayCommand(o =>
			{
				currentView = HomeVM;
			});

			DiscoverViewCommand = new RelayCommand(o =>
			{
				currentView = DiscoverVM;
			});
		}
	}
}
