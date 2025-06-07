Console.WriteLine("Enter a number!");

// there's var too :333 hellyea - implic. typed

double number1 = 0;

string userInput = Console.ReadLine();
number1 = double.Parse(userInput);


Console.WriteLine("Enter a second number!");

double number2 = 0;

userInput = Console.ReadLine();
number2 = double.Parse(userInput);

double sum = number1 + number2;

// concat
// Console.WriteLine("The sum of them is: " + sum);

// interp
Console.WriteLine($"The sum of them is {sum}");

Console.ReadKey();
