using System.Xml.Linq;

namespace ConsoleAppjustask
{
    internal class Program
    {
        class Person
        {
            private string name = "Ali";


            //public void UserDetail(string name,int age )
            //{
                //Console.WriteLine(name);
                //Console.WriteLine($"Name:{name}\nbpsAge:{age}");
            //}
            public string Abc(string msg)
            {
                Console.WriteLine(name);
                return msg;
            }
        }   
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");




            Person person = new Person();
            //Console.WriteLine(person.name);
            //Person.UserDetail("Taimoor",12);
            //person.UserDetail("Alina",12);

        }
    }
}
