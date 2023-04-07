using CommunityToolkit.Mvvm.ComponentModel;
using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    [INotifyPropertyChanged]
    public partial class LiveArea : ILiveArea
    {
       [ObservableProperty] private Switchable _spot;
       [ObservableProperty] private Switchable _hiddenLight;
       [ObservableProperty] private Dimmable _dimmableLight;
       [ObservableProperty] private Controllable _heatFloor;
        public LiveArea(Switchable spot, Switchable hiddenLight, Dimmable light, Controllable heatFloor)
        {
            DimmableLight = light;
            Spot = spot;
            HiddenLight = hiddenLight;
            HeatFloor = heatFloor;
        }
    }

}
