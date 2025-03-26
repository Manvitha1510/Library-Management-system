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
            Console.WriteLine();
            
        }
    }
}
