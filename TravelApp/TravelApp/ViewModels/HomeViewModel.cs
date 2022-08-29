using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows.Input;
using TravelApp.Models;
using TravelApp.Resources.Images;
using TravelApp.Services;
using TravelApp.ViewModels.Base;
using Xamarin.Forms;

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

        public ObservableCollection<Destination> TopDestination
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
        public ICommand DetailCommand => new Command<Destination>(OnNavigate);

        public void LoadData()
        {
            RecommendedDestinations = new ObservableCollection<Destination>(DestinationServices.Instance.RecommendedDestinations);
            TopDestination = new ObservableCollection<Destination>(DestinationServices.Instance.TopDestination);
        }

        void OnNavigate(Destination parameter)
        {
            NavigationService.Instance.NavigateToAsync<DetailViewModel>(parameter);
        }
    }
}
