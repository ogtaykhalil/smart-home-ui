using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    internal interface IRealEstate
    {
        //ObservableCollection<ILiveArea> LiveAreas { get; set; }
        //ObservableCollection<INonLiveArea> NonLiveAreas { get; set; }
        ILiveArea LivingRoom { get; set; }
        ILiveArea BedRoom { get; set; }
        Kitchen Kitchen { get; set; }
        BathRoom BathRoom { get; set; }
        Balcony Balcony { get; set; }
        INonLiveArea Entrance { get; set; }
    }
}
