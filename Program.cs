using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Russia("Петя"));
            people.Add(new Ukraine("Петро"));
            people.Add(new English("Petr"));

            foreach (Person person in people)
            {
                person.SayHello();
            }
            Console.Read(); 
        }
    }
}
