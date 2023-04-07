using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    public interface ILiveArea
    {
        Switchable Spot { get; set; }
        Switchable HiddenLight { get; set; }
        Dimmable DimmableLight { get; set; }
        Controllable HeatFloor { get; set; }

    }
}
