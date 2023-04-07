using CommunityToolkit.Mvvm.ComponentModel;

namespace Model.Abstract
{
    [INotifyPropertyChanged]
    public abstract partial class Protection : IDevice
    {
        [ObservableProperty] private string? _name;
        [ObservableProperty] private bool _status;

    }
}
