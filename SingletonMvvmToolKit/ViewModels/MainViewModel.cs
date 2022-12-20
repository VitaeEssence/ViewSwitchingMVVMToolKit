using CommunityToolkit.Mvvm.ComponentModel;
using SingletonMvvmToolKit.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMvvmToolKit.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;

        [ObservableProperty] public object? _currentViewModel; // => _navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModel = _currentViewModel;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnCurrentViewModelChanged(nameof(_currentViewModel));
        }
    }
}
