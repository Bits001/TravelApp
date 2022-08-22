using System.Collections.ObjectModel;
using TravelApp.Models;
using TravelApp.Services;
using TravelApp.ViewModels.Base;

namespace TravelApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        ObservableCollection<Destination> _recommendedDestinations;
        ObservableCollection<Destination> _topDestinations;

        public HomeViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Destination> RecommendedDestinations
        {
            get
            {
                return _recommendedDestinations;
            }
            set
            {
                _recommendedDestinations = value;
                OnPropertyChanged();
            }
            
        }

        public ObservableCollection<Destination> TopDestinations
        {
            get
            {
                return _topDestinations;
                
            }
            set
            {
                _topDestinations = value;
                OnPropertyChanged();

            }
        }

        void LoadData()
        {
            RecommendedDestinations = new ObservableCollection<Destination>(DestinationServices.Instance.RecommendedDestinations);
            TopDestinations = new ObservableCollection<Destination>(DestinationServices.Instance.TopDestination);
        }
    }
}
