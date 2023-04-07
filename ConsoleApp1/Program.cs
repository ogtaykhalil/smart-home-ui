using Sharp7;
using Model.Abstract;
using Model.Concrete;
using System;
using System.Collections.ObjectModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputByteZero = new byte[5];
            S7Client myPlc = new();
            myPlc.SetConnectionParams("192.168.0.5", 3200, 2200);
            myPlc.Connect();
            RealEstate myApartment = new();
            myPlc.EBRead(1024, 1, inputByteZero);
            

            var kitchen = new Kitchen(new SpotLight(),
                                            new Heater(),
                                            new WaterProtection(),
                                            new GasProtection());

            var livingRoom = new LiveArea(new SpotLight(),
                                                 new HiddenLight(),
                                                 new DimmableLight(),
                                                 new Heater());

            var bedRoom = new LiveArea(new SpotLight(),
                                              new HiddenLight(),
                                              new DimmableLight(),
                                              new Heater());

            var bathRoom = new BathRoom(new SpotLight(),
                                               new Heater(),
                                               new WaterProtection());

            var balcony = new Balcony(new SpotLight(),
                                            new Heater(),
                                            new Curtain());

            var entrance = new NonLiveArea(new SpotLight(),
                                                    new Heater());

            myApartment.BathRoom = bathRoom;
            myApartment.BedRoom = bedRoom;
            myApartment.Balcony = balcony;
            myApartment.Kitchen = kitchen;
            myApartment.Entrance = entrance;
            myApartment.LivingRoom = livingRoom;

            var livingRoomLight = myApartment.LivingRoom.DimmableLight;
            var livingRoomSpot = myApartment.LivingRoom.Spot;
            var livingRoomHiddenLight = myApartment.LivingRoom.HiddenLight;
            var livingRoomHeatFloor = myApartment.LivingRoom.HeatFloor;

            var bedRoomLight = myApartment.BedRoom.DimmableLight;
            var bedRoomSpot = myApartment.BedRoom.Spot;
            var bedRoomHiddenLight = myApartment.BedRoom.HiddenLight;
            var bedRoomHeatFloor = myApartment.BedRoom.HeatFloor;

            var balconySpot = myApartment.Balcony.Spot;
            var balconyHeatFloor = myApartment.Balcony.HeatFloor;
            var balconyCurtain = myApartment.Balcony.Curtain;

            var bathRoomSpot = myApartment.BathRoom.Spot;
            var bathRoomHeatFloor = myApartment.BathRoom.HeatFloor;

            var kitchenSpot = myApartment.Kitchen.Spot;
            var kitchenHeatFloor = myApartment.Kitchen.HeatFloor;

            var entranceSpot = myApartment.Entrance.Spot;
            var entranceHeatFloor = myApartment.Entrance.HeatFloor;
            

            myApartment.BathRoom.WaterProtection.Status = false;
            livingRoomLight.Value = 25;
            livingRoomLight.OnOffCommand = true;
            myApartment.BedRoom.DimmableLight.OnOffCommand = true;

            Console.WriteLine(myApartment.BathRoom.WaterProtection.Status);
            Console.WriteLine(livingRoomLight.Value);
            Console.WriteLine(balconyCurtain.Value);
        }
    }

}