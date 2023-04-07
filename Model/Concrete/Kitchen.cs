using CommunityToolkit.Mvvm.ComponentModel;
using Model.Abstract;

namespace Model.Concrete
{
    public partial class Kitchen : NonLiveArea
    {
        [ObservableProperty] Protection _waterProtection;
        [ObservableProperty] Protection _gasProtection;
        public Kitchen(Switchable spot, Controllable heatFllor, Protection waterProtection, Protection gasProtection) : base(spot, heatFllor)
        {
            _waterProtection = waterProtection;
            _gasProtection = gasProtection;
        }
    }
}
