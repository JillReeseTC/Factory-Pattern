namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            var numberOfWheels = 0;
            var answer = Console.ReadLine();
            bool success = int.TryParse(answer, out numberOfWheels);
            while ((!(success)) && (answer != null))
            {
                Console.WriteLine("Enter the number of wheels: ");
                answer = Console.ReadLine();
                success = int.TryParse(answer, out numberOfWheels);
            }

            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            vehicle.Drive();
        }



    }
}
