using AppForBinding.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AppForBinding.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private int _Clicks;

        public int Clicks
        {
            get { return _Clicks; }
            set 
            { 
                _Clicks = value;
                OnPropertyChanged(nameof(Clicks));
            }
        }       

        private DelegateCommand _ClickOnButton;
        public DelegateCommand ClickOnButton
        {
            get
            {
                return _ClickOnButton ??
                    (_ClickOnButton = new DelegateCommand(obj =>
                    {
                        Clicks++;
                    }, (obj => Clicks < 10)));
            }
        }

        private DelegateCommand _ButtonExitClick;
        public DelegateCommand ButtonExitClick
        {
            get
            {
                return _ClickOnButton ??
                    (_ClickOnButton = new DelegateCommand(obj =>
                    {
                        Application.Current.Shutdown();
                    }));
            }
        }

        
    }
}
