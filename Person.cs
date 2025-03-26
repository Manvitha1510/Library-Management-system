namespace ConsoleApp9
{
    public class Person
    {
        public string Name;
        public string Email;
        public string ID;

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Email: {Email}, ID: {ID}");
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating Staff Members
        Staff staff1 = new Staff("Shivani", "shivani@usf.edu", "ST001", "Librarian", "Library Services");
        Staff staff2 = new Staff("manvitha", "manvitha@usf.edu", "ST002", "Assistant Librarian", "Library Services");

        // List of Staff Members
        //List<Staff> staffMembers = new List<Staff> { staff1, staff2 };

        // Displaying Staff Information
        //Console.WriteLine("\nStaff in Library:");
        //foreach (var staff in staffMembers)
        //{
         //   Console.WriteLine($"Name: {staff.Name}, ID: {staff.ID}, Position: {staff.Position}, Department: {staff.Department}");
        //}
    }
}
}
