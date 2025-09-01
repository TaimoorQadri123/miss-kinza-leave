namespace Records
{
    class User
    {
        public int Id { get; set; }
    }

    public record Person(string Name, int Age);

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ali", 34);
            Console.WriteLine(person);
        }
    }
}
