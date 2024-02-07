using System;
using System.Collections.Generic;

// Клас книги
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
}

// Абстрактний декоратор
abstract class BookDecorator : Book
{
    protected Book book;

    public BookDecorator(Book book) : base(book.Title, book.Author, book.Price)
    {
        this.book = book;
    }

    public override string ToString()
    {
        return book.ToString();
    }
}

// Декоратор для обкладинки книги
class CoverDecorator : BookDecorator
{
    public string CoverType { get; set; }

    public CoverDecorator(Book book, string coverType) : base(book)
    {
        CoverType = coverType;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Cover: {CoverType}";
    }
}

// Декоратор для рецензій книги
class ReviewDecorator : BookDecorator
{
    public string Review { get; set; }

    public ReviewDecorator(Book book, string review) : base(book)
    {
        Review = review;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Review: {Review}";
    }
}

// Клас користувача бібліотеки
class LibraryUser
{
    public string Name { get; set; }

    public LibraryUser(string name)
    {
        Name = name;
    }

    public void BorrowBook(Book book)
    {
        Console.WriteLine($"{Name} borrowed the book: {book.Title}");
    }

    public void ReturnBook(Book book)
    {
        Console.WriteLine($"{Name} returned the book: {book.Title}");
    }
}

class Program
{
    static void Main()
    {
        // Створення книги
        Book book = new Book("Introduction to C#", "John Doe", 20.50m);

        // Додавання обкладинки до книги
        Book decoratedBook = new CoverDecorator(book, "Hardcover");

        // Додавання рецензії до книги
        decoratedBook = new ReviewDecorator(decoratedBook, "Great book for beginners");

        // Виведення доданої інформації до книги
        Console.WriteLine(decoratedBook);

        // Створення користувача бібліотеки
        LibraryUser user = new LibraryUser("Alice");

        // Користувач бере книгу в оренду
        user.BorrowBook(decoratedBook);

        // Користувач повертає книгу
        user.ReturnBook(decoratedBook);
    }
}
