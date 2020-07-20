using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person("Yurii", new DateTime(2000, 10,10)),
                new Person("Yurii", new DateTime(2001, 10,10)),
                new Person("Sasha", new DateTime(2005, 10,10)),
                new Person("Sasha", new DateTime(2001, 10,10)),
                new Person("Masha", new DateTime(2015, 10,10)),
                new Person("Baba", new DateTime(2000, 10,10)),
            };
            //var persons = new List<Person>();
            //const int  COUNT = 6;

            //for (int i = 0; i < COUNT; i++)
            //{
            //    Console.Write("Enter name person: ");
            //    var name = Console.ReadLine();
            //    Console.Write("Enter birthday: ");
            //    var birthday = Convert.ToDateTime(Console.ReadLine());

            //    persons.Add(new Person(name, birthday));
            //}
            Console.WriteLine("All persons");

            persons.ForEach(item => Console.WriteLine(item.ToString()));
            Console.WriteLine();

            Console.WriteLine("Change name person which age < 16");
            persons.ForEach(item =>
            {
                item.ChangeName();
                Console.WriteLine(item.ToString());
            });
            Console.WriteLine();

            Console.WriteLine("Persons with the same name:");
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = i + 1; j < persons.Count; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i].Name} and {persons[j].Name} are equals");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
