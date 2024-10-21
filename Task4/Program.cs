namespace Task4;
class Program
{
    static void Main(string[] args)
    {
        LibraryMember[] members = new LibraryMember[3];
        members[0] = new FacultyMember(1, "Salam Salami", "salam@salam.com", "CS");
        members[1] = new StudentMember(2, "Salam", "a@gmail.com", "IT");
        members[2] = new StudentMember(3, "Ali", "b@gmail.com", "CE");

        foreach (LibraryMember member in members)
        {
            member.GetMemberDetails();
            Console.WriteLine();
        }

        try
        {
            members[5].GetMemberDetails();
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}