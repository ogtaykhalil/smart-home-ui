using CommunityToolkit.Mvvm.ComponentModel;
using Model.Abstract;

namespace Model.Concrete
{
    [INotifyPropertyChanged]
    public partial class Valve : IOpenClose, IDevice
    {
        [ObservableProperty] private bool _openCommand;
        [ObservableProperty] private bool _closeCommand;
        [ObservableProperty] private bool _status;
        [ObservableProperty] private string? _name;

      

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
