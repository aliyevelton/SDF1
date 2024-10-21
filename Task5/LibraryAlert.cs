namespace Task5;

public abstract class LibraryAlert
{
    public int AlertID { get; private set; }
    public string Message { get; private set; }

    protected LibraryAlert(int alertID, string message)
    {
        AlertID = alertID;
        Message = message;
    }

    public abstract void DisplayAlert();
}