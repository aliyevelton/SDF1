namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        LibraryAlert[] alerts = new LibraryAlert[]
        {
            new OverdueAlert(1, "Return your book!", new DateTime(2021, 12, 1)),
            new OverdueAlert(2, "Return your book!", new DateTime(2021, 12, 2)),
            new NewArrivalAlert(2, "New book available!", "The Hobbit"),
            new NewArrivalAlert(3, "New book available!", "The Lord of the Rings")
        };

        //foreach (LibraryAlert alert in alerts)
        //{
        //    alert.DisplayAlert();
        //}

        try
        {
            alerts[0].DisplayAlert();
            alerts[1].DisplayAlert();
            alerts[2].DisplayAlert();
            alerts[3].DisplayAlert();
            //alerts[4].DisplayAlert();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}