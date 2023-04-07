using Model.Abstract;

namespace Model.Concrete
{
    public class BedRoom : LiveArea
    {
        public BedRoom(Switchable spot, Switchable hiddenLight, Dimmable light, Controllable heatFloor) 
            : base(spot, hiddenLight, light, heatFloor)
        {
        }
    }
}
