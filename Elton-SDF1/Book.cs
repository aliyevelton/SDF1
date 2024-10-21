namespace Elton_SDF1;

public class Book
{
    private string _isbn;
    private string _title;
    private string _author;
    private int _publishedYear;
    private bool _isCheckedOut;

    public string ISBN
    {
        get { return _isbn; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("ISBN cannot be empty.");
            _isbn = value;
        }
    }

    public string Title
    {
        get { return _title; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Title cannot be empty.");
            _title = value;
        }
    }

    public string Author
    {
        get { return _author; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Author cannot be empty.");
            _author = value;
        }
    }

    public int PublishedYear
    {
        get { return _publishedYear; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Published year can't be lower than zero.");
            _publishedYear = value;
        }
    }

    public bool IsCheckedOut
    {
        get { return _isCheckedOut; }
        set { _isCheckedOut = value; }
    }

    public Book(string isbn, string title, string author, int publishedYear)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        PublishedYear = publishedYear;
        _isCheckedOut = false;
    }

    public void CheckOut()
    {
        if (!_isCheckedOut)
        {
            _isCheckedOut = true;
        }
        else
        {
            throw new InvalidOperationException("The book is already checked out.");
        }
    }

    public void Return()
    {
        if (_isCheckedOut)
        {
            _isCheckedOut = false;
        }
        else
        {
            throw new InvalidOperationException("The book is not checked out.");
        }
    }

    public virtual void DisplayBookDetails()
    {
        if (this == null)
        {
            throw new NullReferenceException("The book does not exist.");
        }

        Console.WriteLine($"\nISBN: {ISBN}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Published Year: {PublishedYear}");
        Console.WriteLine($"Is Checked Out: {IsCheckedOut}");
    }
}

public class EBook : Book
{
    public double FileSize { get; set; }

    public EBook(string isbn, string title, string author, int publishedYear, double fileSize)
        : base(isbn, title, author, publishedYear)
    {
        FileSize = fileSize;
    }

    public override void DisplayBookDetails()
    {
        base.DisplayBookDetails();
        Console.WriteLine($"File Size: {FileSize} MB");
        Console.WriteLine("This is an E-Book.");
    }
}

public class PrintedBook : Book
{
    public int NumberOfPages { get; set; }

    public PrintedBook(string isbn, string title, string author, int publishedYear, int numberOfPages)
        : base(isbn, title, author, publishedYear)
    {
        NumberOfPages = numberOfPages;
    }

    public override void DisplayBookDetails()
    {
        base.DisplayBookDetails();
        Console.WriteLine($"Number of Pages: {NumberOfPages}");
        Console.WriteLine("This is a Printed Book.");
    }
}
