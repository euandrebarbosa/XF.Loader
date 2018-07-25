﻿using System.Threading.Tasks;

using Xamarin.Forms;

namespace XF.Loader.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private Command _startLoaderCommand;
        public Command StartLoaderCommand
            => _startLoaderCommand ?? (_startLoaderCommand = new Command(() => StartLoader()));
        
        async void StartLoader()
        {
            IsBusy = true;

            LoaderMessage = "Starting...";

            await Task.Delay(3000);

            LoaderMessage = "Almost there...";

            await Task.Delay(3000);

            LoaderMessage = "OK, it's done!";

            await Task.Delay(3000);

            IsBusy = false;
        }
    }
}