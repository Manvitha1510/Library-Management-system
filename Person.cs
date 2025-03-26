using System;
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

            Library lib = new Library();
            Console.WriteLine();
            //  Creating Books
            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            List<Book> books = new List<Book> { book1, book2, book3 };

            //  Display Books in Library
            Console.WriteLine("\n Books in Library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
            }
            
        }

    }

}
}
