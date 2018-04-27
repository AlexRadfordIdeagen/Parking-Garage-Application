using System;
using System.Collections.Generic;

namespace ParkingGarageApplication
{
    public class Floor : Floors
    {
        public Floor(int spaces, double heightLimit, string level) : base(spaces, heightLimit, level)
        {
        }

        public List<Vehicle> VehicleOccupancy { get; set; }
        public List<Vehicle> Result { get; set; }

        public void checkForOccupancy()
        {
            
            Result = new List<Vehicle>();
            foreach (var item in VehicleOccupancy)
            {
                if (spaces > 0 && item.height  < heightLimit)
                {
                    Result.Add(item);
                    spaces--;
                    continue;
                }
                else if(spaces <=0)
                {
                    Console.WriteLine( item.vehicleReg + " Could not enter due to max occupancy");
                }
              
                else if (item.height >= heightLimit)
                {

                    Console.WriteLine(item.vehicleReg + " Could not enter due to height exceeding max limit");

                }
                
            }

        }
        public void addVehicles(Vehicle vehicle)
        {
            VehicleOccupancy.Add(vehicle);
        }

    }

 
}
