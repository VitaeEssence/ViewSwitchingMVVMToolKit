using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMvvmToolKit.Stores
{
    public partial class NavigationStore : ObservableObject
    {
        public event Action? CurrentViewModelChangedAction;

        /// <summary>
        /// ViewModel Classes
        /// </summary>
        [ObservableProperty] private object? _currentViewModel;

        /// <summary>
        /// Type of Delegate
        /// </summary>
        public event Action? CurrentViewModelChanged;

        partial void OnCurrentViewModelChanged(object? value)
        {
            CurrentViewModelChangedAction?.Invoke();
        }

    }
}
