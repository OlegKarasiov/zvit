using System;
using System.Collections.Generic;

namespace ItCompany
{
    public class Department
    {
        public int ID { get; } = Guid.NewGuid().GetHashCode();
        public String Name { get; } = "Untitled";
        public User Head { get; } = null;
        public List<User> Employees { get; } = new List<User>();

        public Department() => Console.WriteLine("Department " + Name + " has been created");

        public Department(String name, User departmentHead, List<User> employees)
        {
            Name = name;
            Head = departmentHead;
            Employees = employees;
            Console.WriteLine("Department "+Name+" has been created");
        }
    }
}