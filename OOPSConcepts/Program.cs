namespace OOPSConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            
            myCar.Model = "Thar";
            myCar.Color = "Black";
            myCar.Year = 2025;

            
            Console.WriteLine("Car Details:");
            Console.WriteLine("Model: " + myCar.Model);
            Console.WriteLine("Color: " + myCar.Color);
            Console.WriteLine("Year: " + myCar.Year);

            myCar.Start();
            myCar.Stop();

            Console.ReadLine();
        }
    }
    
}