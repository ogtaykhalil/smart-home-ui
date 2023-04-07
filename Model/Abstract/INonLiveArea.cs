using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    public interface INonLiveArea
    {
        Switchable Spot { get; set; }
        Controllable HeatFloor { get; set; }
    }
}
