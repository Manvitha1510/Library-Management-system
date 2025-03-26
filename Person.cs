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
