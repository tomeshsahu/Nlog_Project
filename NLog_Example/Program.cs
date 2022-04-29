using System;
namespace NLog_Example;
class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome To Nlogger");
        AddNumber add = new AddNumber();

        Console.WriteLine($"Sum of Two Number is= {add.Sum(1, 2)}");

    }
}
