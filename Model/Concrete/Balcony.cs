using CommunityToolkit.Mvvm.ComponentModel;
using Model.Abstract;

namespace Model.Concrete
{
    public partial class Balcony : NonLiveArea
    {
        
        [ObservableProperty] Controllable _curtain;
        public Balcony(Switchable spot, Controllable heatFloor, Controllable curtain) : base(spot, heatFloor)
        {
            _curtain = curtain;
        }

    }
}
