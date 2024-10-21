namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("978-3-16-148410-0", "The Hobbit", "J.R.R. Tolkien", 1937);
        Magazine magazine = new Magazine("978-3-16-148410-1", "National Geographic", "National Geographic Society", 1888);

        try
        {
            book.CheckOut(); 
            book.CheckOut(); 
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}"); 
        }

        try
        {
            book.CheckIn(); 
            magazine.CheckIn(); 
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}"); 
        }
    }
}
