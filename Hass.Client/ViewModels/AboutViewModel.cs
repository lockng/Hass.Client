﻿using System;
using System.Windows.Input;
using Hass.Client.Core;

namespace Hass.Client.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        public AboutViewModel()
        {
            Title = "About";

            //OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        //public ICommand OpenWebCommand { get; }
    }

}