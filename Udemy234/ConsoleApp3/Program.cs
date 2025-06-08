namespace ConsoleApp3;

class Program
{
    static int myResult;

    static void Main(string[] args)
    {
        int num1 = 1;
        myResult = AddTwoValues(num1, 10);

        Console.WriteLine(myResult);
    }

    static int AddTwoValues(int value1, int value2)
    {
        return value1 + value2;
    }

    static int SubtractTwoValues(int value1, int value2)
    {
        return value1 - value2;
    }

}

