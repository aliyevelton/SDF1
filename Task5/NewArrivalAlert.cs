namespace Task5;

public class NewArrivalAlert : LibraryAlert
{
    public string BookTitle { get; set; }
    
    public NewArrivalAlert(int alertID, string message, string bookTitle) : base(alertID, message)
    {
        BookTitle = bookTitle;
    }

    public override void DisplayAlert()
    {
        Console.WriteLine($"Alert {AlertID}: {Message} - New Arrival: {BookTitle}");
    }
}
