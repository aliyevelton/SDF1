namespace Task3;

public abstract class LibraryItem
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string ISBN { get; private set; }
    public int PublishedYear { get; private set; }
    protected bool IsCheckedOut { get;  set; }

    public LibraryItem(string title, string author, string isbn, int publishedYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublishedYear = publishedYear;
        IsCheckedOut = false; 
    }

    public abstract void NotifyUser();
}
