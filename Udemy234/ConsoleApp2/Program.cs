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


// arrays
int[] myIntArray = new int[5];
string[] weekDays = ["mon", "tue", "wen", "..."];

// rest like in cpp

// forEach

foreach (var item in weekDays)
{
    Console.WriteLine(item);
}

// multiple d
int[,,] my3DArray = new int[3, 3, 3];
int[,] new2DArray = { { 1, 2 }, { 2, 3 } };

int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

for (int i = 0; i < 3; ++i)
{
    int sum = 0;
    for (int j = 0; j < 3; ++j)
    {
        sum += array[i, j];
    }
    Console.WriteLine(sum);
}