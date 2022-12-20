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
    public partial class HomeViewModel : ObservableObject
    {
        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
        }
    }
}
