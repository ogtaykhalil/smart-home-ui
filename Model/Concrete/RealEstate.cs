using CommunityToolkit.Mvvm.ComponentModel;
using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    [INotifyPropertyChanged]
    public partial class RealEstate : IRealEstate
    {
        [ObservableProperty] private ILiveArea _livingRoom;
        [ObservableProperty] private ILiveArea _bedRoom;
        [ObservableProperty] private Kitchen _kitchen;
        [ObservableProperty] private BathRoom _bathRoom;
        [ObservableProperty] private Balcony _balcony;
        [ObservableProperty] private INonLiveArea _entrance;
        [ObservableProperty] private Switchable _alwaysOff;
        [ObservableProperty] private Switchable _partTimeOff;
        [ObservableProperty] private Switchable _neverOff;
        [ObservableProperty] private Switchable _boilerOnOff;
        [ObservableProperty] private Valve _bathRoomWaterValve;
        [ObservableProperty] private Valve _kitchenWaterValve;
        [ObservableProperty] private Valve _generalWaterValve;
        [ObservableProperty] private Valve _gasValve;
        // [ObservableProperty] private Balcony _balcony;
        // [ObservableProperty] private INonLiveArea _entrance;

        //public static IEnumerable<ILiveArea> DefineLiveAreas( params ILiveArea[] liveAreas)
        //{
        //    foreach (var item in liveAreas)
        //    {
        //        yield return item;
        //    }         
        //}

        public void DefineLiveAreas(params ILiveArea[] liveAreas)
        {
            _livingRoom = liveAreas[0];
            _bedRoom = liveAreas[1];
        }
        public static ILiveArea DefineLiveAreas(ILiveArea liveArea)
        {
            return liveArea;
        }
        public void DefineNonLiveAreas(params INonLiveArea[] nonLiveArea)
        {
            _entrance = nonLiveArea[0];
        }
        public static INonLiveArea DefineNonLiveAreas(INonLiveArea nonLiveArea)
        {
            return nonLiveArea;
        }
        public void DefineNonLiveAreas(Balcony balcony)
        {
            _balcony = balcony;
        }
        public void DefineNonLiveAreas(Kitchen kitchen)
        {
            _kitchen = kitchen;
        }
        public void DefineNonLiveAreas(BathRoom bathRoom)
        {
            _bathRoom = bathRoom;
        }

    }
}
