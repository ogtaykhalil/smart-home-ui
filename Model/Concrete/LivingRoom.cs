using Model.Abstract;

namespace Model.Concrete
{
    public class LivingRoom : LiveArea
    {
        public LivingRoom(Switchable spot, Switchable hiddenLight, Dimmable light, Controllable heatFloor) 
            : base(spot, hiddenLight, light, heatFloor)
        {
        }
    }
}
