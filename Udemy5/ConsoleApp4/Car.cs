namespace ConsoleApp4;

class Car
{
    private string _brand;
    private string _model;
    private bool _isLuxury;

    public string Brand
    {
        get
        {
            if (_isLuxury)
            {
                return _brand + " - Luxury edition";
            }
            else
            {
                return _brand;
            }
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You entered nothing");
                _brand = "DEFAULT VALUE";
            }
            else
            {
                _brand = value;
            }
        }
    }
    public string Model { get => _model; set => _model = value; }
    public bool isLuxury { get => _isLuxury; set => _isLuxury = value; }

    public Car(string brand, string model, bool isLuxury)
    {
        Brand = brand;
        Model = model;
        _isLuxury = isLuxury;
        Console.WriteLine($"A car of the model {_brand} {_model} has been created");
    }
}