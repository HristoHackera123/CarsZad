namespace Cars_9A_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cars do you want?");
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Car {i}");
                Console.Write("Mark: ");
                string mark = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Registration Number: ");
                int regNum = int.Parse(Console.ReadLine());
                Console.Write("Year of making: ");
                int year = int.Parse(Console.ReadLine());
                Car car = new Car(mark, model, regNum, year);
                Console.WriteLine("Would you like to add that car to the race?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    cars.Add(car);
                }
            }
            Car.CarRace(cars);
        }
    }
}
