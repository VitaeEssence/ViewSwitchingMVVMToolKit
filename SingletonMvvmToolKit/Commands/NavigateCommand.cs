using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SingletonMvvmToolKit.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SingletonMvvmToolKit.Commands
{
    
    public class NavigateCommand<TViewModel> : ICommand
        where TViewModel : class
    {

        private readonly NavigationStore _navigationStore;

        private readonly Func<TViewModel> _createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }


        #region ICommand

        public event EventHandler? CanExecuteChanged;

        // Not currently used. Default to true
        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
        #endregion
    }
}
