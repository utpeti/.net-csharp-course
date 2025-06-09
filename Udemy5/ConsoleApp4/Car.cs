namespace ConsoleApp4;

class Car
{
    private string _brand;
    private string _model;

    public Car(string brand, string model)
    {
        _brand = brand;
        _model = model;
        Console.WriteLine($"A car of the model {_brand} {_model} has been created");
    }
}