﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Models;
using TravelApp.Services;
using TravelApp.ViewModels.Base;
using Xamarin.Forms;

namespace TravelApp.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        Destination _destination;

        public Destination Destination
        {
            get { 
                return 
                    _destination; 
            }
            set { _destination
                    = value;
                OnPropertyChanged();
            }
        }

        public ICommand BackCommand => new Command(OnBack);

        void OnBack()
        {
             NavigationService.Instance.NavigateBackAsync();
        }

        public override Task InitializeAsync(object navigationData)
        {
            if(navigationData is Destination destination)
            {
                Destination = destination;
            }
            return base.InitializeAsync(navigationData);
            
        }
    }
}
