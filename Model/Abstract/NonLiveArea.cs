using CommunityToolkit.Mvvm.ComponentModel;
using Model.Concrete;

namespace Model.Abstract
{
    [INotifyPropertyChanged]
    public partial class NonLiveArea : INonLiveArea
    {
        [ObservableProperty] private Switchable _spot;
        [ObservableProperty] private Controllable _heatFloor;

      
        public NonLiveArea(Switchable spot, Controllable heatFloor)
        {
            _spot = spot;
            _heatFloor = heatFloor;
        }
    }
}
