using CommunityToolkit.Mvvm.ComponentModel;
using Model.Abstract;

namespace Model.Concrete
{
    public partial class BathRoom : NonLiveArea
    {
        [ObservableProperty] Protection _waterProtection;
        public BathRoom(Switchable spot, Controllable heatFllor, Protection waterProtection) : base(spot, heatFllor)
        {
            _waterProtection = waterProtection;
        }
    }
}
