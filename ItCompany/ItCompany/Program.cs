using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ItCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Made by students of IA-71");
            Console.WriteLine("MELNYK MYKOLA || OLEG KARASIOV || TRUKHAN NAZARII");
            Console.WriteLine(" ");
            Console.WriteLine("\tCreating IT-COMPANY");

            ItCompany itCompany = new ItCompany();

            Console.WriteLine(" ");

            Console.WriteLine("\t=== Testing interfaces ===");

            Console.WriteLine("1. Creating project: ");
            Entity entity = new Project("Test");
            Console.WriteLine("ID: " + entity.Id);

            IEntity copy = entity;

            Console.WriteLine("2. Casting Project to Task: ");
            entity = new Task("Lab 5");
            Console.WriteLine("Entity is now of type : " + entity.GetType().Name);
            Console.WriteLine("ID: " + entity.Id);

            Console.WriteLine("3. Entities are equal: " + copy.Equals(entity));

            Console.WriteLine("4. Casting back: ");
            entity = (Entity)copy;
            Console.WriteLine("Entity is now of type : " + entity.GetType().Name);
            Console.WriteLine("ID: " + entity.Id);

            Console.ReadLine();

            Console.WriteLine();
            User user1 = new User("Oleg", "Karasiov", "dog@dog.dog", "kjn3@f3f", Role.Employee);
            User user2 = new User("Oleg-Copy", "Karasiov", "dog@dog.dog", "kjn3@f3f", Role.Employee);
            
            Console.WriteLine(user1.FirstName + " default salary: " + user1.Salary);
            user1++;
            Console.WriteLine(user1.FirstName + " ++ salary: " + user1.Salary);
            User newUser1 = user1 + 8;
            Console.WriteLine(newUser1.FirstName + " + 8 salary: " + newUser1.Salary);
            Console.WriteLine($"{user1.FirstName} > {user2.FirstName}: " + (user1 > user2));
            Console.WriteLine($"{user1.FirstName} < {user2.FirstName}: " + (user1 < user2));
            Console.WriteLine($"{user1.FirstName} == {user2.FirstName}: " + (user1 == user2));
            Console.WriteLine($"{user1.FirstName} != {user2.FirstName}: " + (user1 != user2));

            Console.ReadLine();
        }
    }
}
