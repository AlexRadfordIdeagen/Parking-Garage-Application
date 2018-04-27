namespace ParkingGarageApplication
{
    public abstract class Floors
    {
        public int spaces;
        public double heightLimit;
        public string level;

        public Floors(int spaces, double heightLimit, string level)
        {
            this.spaces = spaces;
            this.heightLimit = heightLimit;
            this.level = level;
        }
    }

    
}
