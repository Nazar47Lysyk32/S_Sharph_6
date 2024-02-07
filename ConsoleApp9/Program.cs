using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Використання лямбда-виразу для виведення лише парних чисел
        var evenNumbers = Array.FindAll(numbers, num => num % 2 == 0);

        // Виведення результатів
        Console.WriteLine("Парні числа:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
