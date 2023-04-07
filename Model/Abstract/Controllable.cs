using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Model.Abstract
{
    [INotifyPropertyChanged]
    public abstract partial class Controllable : IOpenClose, ISettable, IDevice
    {
        [ObservableProperty] private bool _openCommand;
        [ObservableProperty] private bool _closeCommand;
        [ObservableProperty] private bool _status;
        [ObservableProperty] private string? _name;
        [ObservableProperty] private int _value;

        public int FeedBack { get; set; }

        [RelayCommand]
        public void SetValue(int value)
        {
            _value = value;
        }
        public bool GetStatus()
        {
            throw new NotImplementedException();
        }

        public void Switch()
        {
            throw new NotImplementedException();
        }
    }
}
