namespace Task4;

public class StudentMember : LibraryMember
{
    public string Course { get; set; }

    public StudentMember(int memberId, string name, string email, string course) : base(memberId, name, email)
    {
        Course = course;
    }
    public override void GetMemberDetails()
    {
        Console.WriteLine($"Member ID: {MemberId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Course: {Course}");
    }
}
