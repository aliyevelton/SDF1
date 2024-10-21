using Task3.Interfaces;

namespace Task3;

public class Book : LibraryItem, IBorrowable
{
    public Book(string isbn, string title, string author, int publishedYear) : base(title, author, isbn, publishedYear)
    {
    }

    public void CheckOut()
    {
        if (IsCheckedOut)
        {
            throw new InvalidOperationException("This book is already checked out.");
        }
        IsCheckedOut = true;
        Console.WriteLine($"{Title} has been checked out.");
    }

    public void CheckIn()
    {
        if (!IsCheckedOut)
        {
            throw new InvalidOperationException("This book was not checked out.");
        }
        IsCheckedOut = false;
        Console.WriteLine($"{Title} has been returned.");
    }

    public override void NotifyUser()
    {
        Console.WriteLine($"Reminder: The book '{Title}' is overdue. Please return it as soon as possible.");
    }
}
