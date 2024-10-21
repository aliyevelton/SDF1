namespace Task4;

public class FacultyMember : LibraryMember
{
    public string Department { get; set; }

    public FacultyMember(int memberId, string name, string email, string department) : base(memberId, name, email)
    {
        Department = department;
    }

    public override void GetMemberDetails()
    {
        Console.WriteLine($"Member ID: {MemberId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Department: {Department}");
    }
}
