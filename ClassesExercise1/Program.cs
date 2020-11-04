using System;
using System.Net.Http;

namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car("ford", "ranger", 2020);

            Console.WriteLine($"{Car1.Year} {Car1.Make} {Car1.Model}");
        }
    }
}
