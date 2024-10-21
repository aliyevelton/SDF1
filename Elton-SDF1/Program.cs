namespace Elton_SDF1;

class Program
{
    static void Main(string[] args)
    {
        // Task 1

        var book1 = new Book("978-0-306-40615-7", "The Art of Computer Programming", "Donald Knuth", 1968);
        var book2 = new Book("978-0-07-352340-8", "Introduction to Algorithms", "Thomas H. Cormen", 1990);
        var book3 = new Book("978-0-13-110362-7", "Design Patterns", "Erich Gamma", 1994);
        var book4 = new Book("978-0-321-33461-3", "Refactoring", "Martin Fowler", 1999);

        try
        {
            //var book5 = new Book("978-0-321-81172-3", "Clean Code", "Robert C. Martin", -2);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            //var user2 = new LibraryUser(-2, "Bob", "salam2@salam.com");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        var user1 = new LibraryUser(1, "Alice", "salam1@salam.com");
        var user3 = new LibraryUser(3, "Charlie", "salam3@salam.com");

        try
        {
            user1.CheckOutBook(book1);

            user1.ReturnBook(book1);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Task 2

        //book1.DisplayBookDetails();

        EBook eBook1 = new EBook("978-0-306-40615-7", "The Art of Computer Programming", "Donald Knuth", 1968, 10.5);
        EBook eBook2 = new EBook("978-0-07-352340-8", "Introduction to Algorithms", "Thomas H. Cormen", 1990, 15.5);
        EBook eBook3 = new EBook("978-0-13-110362-7", "Design Patterns", "Erich Gamma", 1994, 20.5);
        EBook eBook5 = null;
        //eBook1.DisplayBookDetails();

        PrintedBook printedBook1 = new PrintedBook("978-0-306-40615-7", "The Art of Computer Programming", "Donald Knuth", 1968, 100);
        PrintedBook printedBook2 = new PrintedBook("978-0-07-352340-8", "Introduction to Algorithms", "Thomas H. Cormen", 1990, 150);
        PrintedBook printedBook3 = new PrintedBook("978-0-13-110362-7", "Design Patterns", "Erich Gamma", 1994, 200);
        //printedBook1.DisplayBookDetails();

        List<Book> books = new List<Book> { eBook1, eBook2, eBook3, printedBook1, printedBook2, printedBook3 };

        try
        {
            //eBook5.DisplayBookDetails();
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}