namespace Elton_SDF1;

public class LibraryUser
{
    private int _userId;
    private string _name;
    private string _email;
    private List<Book> _checkedOutBooks;

    public int UserId
    {
        get { return _userId; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("User ID can't be lower than zero.");
            _userId = value;
        }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }

    public string Email
    {
        get { return _email; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email cannot be empty.");
            _email = value;
        }
    }

    public List<Book> CheckedOutBooks
    {
        get { return _checkedOutBooks; }
        private set { _checkedOutBooks = value; }
    }

    public LibraryUser(int userId, string name, string email)
    {
        UserId = userId;
        Name = name;
        Email = email;
        CheckedOutBooks = new List<Book>();
    }

    public void CheckOutBook(Book book)
    {
        if (book.IsCheckedOut)
            throw new InvalidOperationException("Book is already checked out.");

        book.IsCheckedOut = true;
        CheckedOutBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        if (!book.IsCheckedOut)
            throw new InvalidOperationException("Book is not checked out.");

        book.IsCheckedOut = false;
        CheckedOutBooks.Remove(book);
    }
}
