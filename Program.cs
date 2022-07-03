
namespace Project2
{
    internal class CarParkingSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Parking system");

            Console.WriteLine("How many cars are parked?");
            int amount = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Please Enter Vehicle Type. For Example: Car");
                string typeofVehicle = Console.ReadLine();

                Console.WriteLine("Please Enter Parked Hours");
                double hours = Convert.ToDouble(Console.ReadLine());

                double fare = 0.0;
                if (typeofVehicle == "Bike")
                {
                    fare = BikeFare(hours);
                }

                if (typeofVehicle == "Car")
                {
                    fare = CarFare(hours);
                }

                if (typeofVehicle == "Bus")
                {
                    fare = BusFare(hours);
                }

                Console.WriteLine("Total Fare for this " + typeofVehicle + " is: " + fare);
            }

            Console.ReadKey();
        }

        public static double BikeFare(double hours)
        {
            double result;

            if (hours <= 3)
                result = 2.00;
            else if (hours >= 11)
                result = 10.00;
            else
                result = 2.00 + (hours - 3) * 0.50;
            return result;
        }


        public static double CarFare(double hours)
        {
            var test = 4.00 + (hours - 3) * 1.00;

            double result;

            if (hours <= 3)
                result = 4.00;
            else if (hours >= 11)
                result = 20.00;
            else
                result = 4.00 + (hours - 3) * 1.00;
            return result;
        }

        public static double BusFare(double hours)
        {
            double result;

            if (hours <= 3)
                result = 6.00;
            else if (hours >= 11)
                result = 30.00;
            else
                result = 6.00 + (hours - 3) * 1.50;
            return result;
        }
    }
}