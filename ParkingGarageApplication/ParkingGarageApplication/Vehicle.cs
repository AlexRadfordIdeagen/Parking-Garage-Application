namespace ParkingGarageApplication
{
    public abstract class Vehicle
    {
        public string vehicleReg;
        public double height;
        public Vehicle(string vehicleReg, double height)
        {
            this.vehicleReg = vehicleReg;
            this.height = height;
        }

    }
  
}
