using System;
using System.Collections.Generic;

namespace ParkingGarageApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var garage = AddGarage();
            garage[0].VehicleOccupancy = new List<Vehicle>
            {
                new Bike("U2E980AKTW", 12.5),
                new Car("9N148GYAYV", 29),
                new Car("Z39T3IQEDJ", 23),
            };

            garage[1].VehicleOccupancy = new List<Vehicle>
            {
                new Bike("55XKZQ6CRT", 12),
                new Van("2OS0XAQBUH", 25)
            };
            garage[2].VehicleOccupancy = new List<Vehicle>
            {
                new Car("9RHJS13JFV", 19),
                new Car("8X6JOOK4C2", 19.8),
                new Van("P32BHSLOE8", 30),
                new Bike("MH98M5XQ8V", 12)
            };
            garage[3].VehicleOccupancy = new List<Vehicle>
            {
                new Car("6BR4FCDNYL", 21)
            };

            foreach (var item in garage)
            {
                Console.WriteLine($"Current vehicles occupying {item.level}:");

                item.checkForOccupancy();
                foreach (var vehicle in item.Result)
                {
                    Console.WriteLine($"{vehicle.vehicleReg}");
                }
                Console.WriteLine($"With {item.spaces} spaces left");
                Console.WriteLine("--------------------------------------------");

            }
            Console.ReadLine();
        }

        private static List<Floor> AddGarage()
        {
            var garage = new List<Floor>
            {
                new Floor(50, 50, "F1"),
                new Floor(23, 30, "F2"),
                new Floor(10, 24, "F3"),
                new Floor(0, 40, "F4")
            };
            return garage;
        }
    }
}
