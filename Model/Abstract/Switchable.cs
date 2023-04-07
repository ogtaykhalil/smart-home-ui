using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    [INotifyPropertyChanged]
    public abstract partial class Switchable : IDevice, ISwitchable
    {
        [ObservableProperty] private string ? _name;
        [ObservableProperty] private bool _onOffCommand;
        [ObservableProperty] private bool _status;

       
        public bool GetStatus()
        {
            return Status;
        }
        [RelayCommand]
        public void Switch()
        {
            OnOffCommand = !OnOffCommand;
        }
    }
}
