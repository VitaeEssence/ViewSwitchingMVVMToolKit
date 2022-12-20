using CommunityToolkit.Mvvm.ComponentModel;
using SingletonMvvmToolKit.Commands;
using SingletonMvvmToolKit.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SingletonMvvmToolKit.ViewModels
{
    public partial class AccountViewModel : ObservableObject
    {
        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}
