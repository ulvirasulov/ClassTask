namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "", 15000, 4);
            car.ShowFullInfo();

            Motorcycle motorcycle = new Motorcycle("Yamaha", "YZF-R1", 5000, 2);
            motorcycle.ShowFullInfo();
        }
    }
    class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;

        public Vehicle(string brand, string model, double mile)
        {
            if (brand != null && model != null)
            {
                Brand = brand;
                Model = model;
                Mile = mile;
            }
        }
    }
    class Car : Vehicle
    {
        public int DoorsNum;

        public Car(string brand, string model, double mile, int doorsNum):base(brand, model, mile)
        {
            DoorsNum = doorsNum;
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, Doors: {DoorsNum}");
        }
    }
    class Motorcycle : Vehicle
    {
        public int WheelNum;

        public Motorcycle(string brand, string model, double mile, int wheelNum):base(brand, model, mile)
        {
            WheelNum = wheelNum;
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, Wheels: {WheelNum}");
        }
    }
}
