namespace Task5;

public class OverdueAlert : LibraryAlert
{
    public DateTime DueDate { get; set; }

    public OverdueAlert(int alertID, string message, DateTime dueDate) : base(alertID, message)
    {
        DueDate = dueDate;
    }

    public override void DisplayAlert()
    {
        Console.WriteLine($"Alert {AlertID}: {Message} - Due Date: {DueDate}");
    }
}
