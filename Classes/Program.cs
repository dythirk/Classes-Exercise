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

            Console.WriteLine(Daily.Make);
            Console.WriteLine(Daily.Model);
            Console.WriteLine(Daily.Year);

        }
    }
}
