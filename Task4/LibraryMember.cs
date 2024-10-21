namespace Task4;

public abstract class LibraryMember
{
    public int MemberId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public LibraryMember(int memberId, string name, string email)
    {
        MemberId = memberId;
        Name = name;
        Email = email;
    }

    public abstract void GetMemberDetails();
}
