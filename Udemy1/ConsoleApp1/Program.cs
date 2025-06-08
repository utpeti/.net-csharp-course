Console.WriteLine("Enter a number!");

// there's var too :333 hellyea - implic. typed

double number1 = 0;

string userInput = Console.ReadLine();
number1 = double.Parse(userInput);


Console.WriteLine("Enter a second number!");

double number2 = 0;

userInput = Console.ReadLine();
number2 = double.Parse(userInput);

// concat
// Console.WriteLine("The sum of them is: " + sum);

// interp
Console.WriteLine($"The sum of them is {number1 + number2}");

Console.WriteLine($"The sub of them is {number1 - number2}");

Console.WriteLine($"The mul of them is {number1 * number2}");

Console.WriteLine($"The div of them is {number1 / number2}");

Console.ReadKey();

// string formatting

int num = 10;
double price = 19.75;
string name = "Frank";

// interpolation
Console.WriteLine($"The number is {num}");

// concat
Console.WriteLine("The number is" + num);

// formatting
Console.WriteLine("The number is {0}, price is {1}, name is {2}", num, price, name);
