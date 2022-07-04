namespace MakhshafAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******---------Welcome to Fare Management System-----------******");

            Console.WriteLine("How many vehicles do you want to calculate the fare?");
            int quantity = Convert.ToInt32(Console.ReadLine());


            for(int i = 0;  i < quantity; i++)
            {
                Console.WriteLine("Please Enter Vehicle Type. For Example: Car");
                string vehicleType = Console.ReadLine();

                Console.WriteLine("Please Enter Parked Hours");
                double hours = Convert.ToDouble(Console.ReadLine());

                double fare = 0.0;
                if (vehicleType == "Bike")
                {
                    fare = GetBikeFare(hours);
                }

                if (vehicleType == "Car")
                {
                    fare = GetCarFare(hours);
                }

                if (vehicleType == "Bus")
                {
                    fare = GetBusFare(hours);
                }

                Console.WriteLine("Total Fare for this " + vehicleType + " is: " + fare);
            }

            Console.ReadKey();
        }

        public static double GetBikeFare(double hours)
        {
            double result;

            if (hours <= 3)
                result = 2.00;
            else if (hours >= 19)
                result = 10.00;
            else
                result = 2.00 + (hours - 3) * 0.50;
            return result;
        }
        

        public static double GetCarFare(double hours)
        {
            var test = 4.00 + (hours - 3) * 1.00;

            double result;

            if (hours <= 3)
                result = 4.00;
            else if (hours >= 19)
                result = 20.00;
            else
                result = 4.00 + (hours - 3) * 1.00;
            return result;
        }

        public static double GetBusFare(double hours)
        {
            double result;

            if (hours <= 3)
                result = 6.00;
            else if (hours >= 19)
                result = 30.00;
            else
                result = 6.00 + (hours - 3) * 1.50;
            return result;
        }
    }
}
