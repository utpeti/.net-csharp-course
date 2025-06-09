namespace ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Audi", "A4", false);
        Car car2 = new Car("BMW", "X5", true);

        Console.WriteLine(car1.Brand);
        Console.WriteLine(car2.Brand);
    }
}
