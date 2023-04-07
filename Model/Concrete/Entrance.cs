using Model.Abstract;

namespace Model.Concrete
{
    public class Entrance : NonLiveArea
    {
        public Entrance(Switchable spot, Controllable heatFllor) : base(spot, heatFllor)
        {
        }
    }
}
