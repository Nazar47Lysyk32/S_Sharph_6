using System;

class Program
{
    static void Main()
    {
        double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

        // Використання лямбда-виразу для обчислення середнього значення
        double average = Array.Exists(numbers, num => true) ? numbers.Average() : 0;

        // Виведення результату
        Console.WriteLine("Середнє значення: " + average);
    }
}
