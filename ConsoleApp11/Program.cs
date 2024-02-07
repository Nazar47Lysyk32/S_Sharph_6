using System;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        // Створення масиву об'єктів класу Person
        Person[] people = {
            new Person("Іван", 25),
            new Person("Марія", 32),
            new Person("Петро", 28),
            new Person("Олена", 20)
        };

        // Використання лямбда-виразу для виведення осіб з віком менше 30 років
        var youngPeople = people.Where(person => person.Age < 30);

        // Виведення результатів
        Console.WriteLine("Особи з віком менше 30 років:");
        foreach (var person in youngPeople)
        {
            Console.WriteLine($"Ім'я: {person.Name}, Вік: {person.Age}");
        }
    }
}
