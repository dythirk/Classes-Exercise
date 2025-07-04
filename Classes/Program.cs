namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            Car Daily = new Car();

            Daily.Make = "Porsche";
            Daily.Model = "Cayman";
            Daily.Year = 2025;

            Console.WriteLine("Make: " + Daily.Make);
            Console.WriteLine("Model: " + Daily.Model);
            Console.WriteLine("Year: " + Daily.Year);

        }
    }
}
