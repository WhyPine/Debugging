using System;

class Program
{
    static void Main()
    {
        int result = AddNumbers(5, 7);
        Console.WriteLine("Result: " + result);

        int num1 = 10;
        int num2 = 20;
        int sum = num1 + num2 + num3;
        Console.WriteLine("Sum: " + sum);


        int[] numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;

        int divisor = 0;
        int quotient = 10 / divisor;


        int age = 18;
        if (age > 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Minor");
        }

        int absent = 0;

        if (absent = 0)
        {
            Console.WriteLine("Absent is false");
        }

        Loop();

        LoopException();

        Console.WriteLine("Today is: " + DayOfWeek("Fri"));
    }

    static double AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void Loop()
    {
        while (true)
        {
            Console.WriteLine("HOW IS YOUR DAY!");
        }
    }

    static void LoopException()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 90)
            {
                throw new Exception("Error on iteration 90!");
            }

            Console.WriteLine($"Iteration: {i}");
        }
    }

    static string DayOfWeek(string day)
    {
        var dayMap = new Dictionary<string, string>
        {
            { "Mon", "Monday" },
            { "Tue", "Tuesday" },
            { "Wed", "Wednesday" },
            { "Thu", "Thursday" },
            { "Fri", "Saturday" },
            { "Fri", "Saturday" },
            { "Sun", "Sunday" }
        };
        return dayMap[day];
    }

    static void CodeReachability()
    {
        return;
        Console.WriteLine("This will never be reached");
    }
}
