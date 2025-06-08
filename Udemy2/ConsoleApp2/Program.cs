// bool isRainy = true;
// bool hasUmbrella = true;

// if (isRainy && hasUmbrella)
// {
//     Console.WriteLine("It's rainyyyy and it's ok");
// }

// switch (isRainy)
// {
//     case true:
//         Console.WriteLine("rains");
//         break;
//     case false:
//         Console.WriteLine("hell nah");
//         break;
//     default:
//         Console.WriteLine("NOO");
//         break;

// }


// // try parse
// string inputString = Console.ReadLine();
// int num = 0;
// if (!int.TryParse(inputString, out num))
// {
//     Console.WriteLine("Not a number");
// }
// num++;
// Console.WriteLine(num);


// // random number
// Random random = new Random();
// int randomNumber = random.Next(1, 11);
// Console.WriteLine(randomNumber);

string rocket = " |^|\n | |\n | |\n MMM";
Console.WriteLine(rocket);

for (int i = 0; i < 20; ++i)
{
    Console.WriteLine(rocket);
    for (int j = 20; j > i; --j)
    {
        Console.WriteLine("\n");
    }
    Thread.Sleep(1000);
    Console.Clear();
}

Console.WriteLine("Rocket Landed!");