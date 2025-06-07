Console.WriteLine("Enter a number!");

int number1 = 0;

string userInput = Console.ReadLine();
number1 = int.Parse(userInput);


Console.WriteLine("Enter a second number!");

int number2 = 0;

userInput = Console.ReadLine();
number2 = int.Parse(userInput);

int sum = number1 + number2;

Console.WriteLine("The sum of them is: " + sum);

Console.ReadKey();
