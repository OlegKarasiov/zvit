using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ItCompany
{
    public class Project
    {
        public int ID { get; } = Guid.NewGuid().GetHashCode();
        public String Name { get; set; } = "Untitled";
        public List<Task> Tasks { get; set; } = new List<Task>();

        public Project() => Console.WriteLine("Project "+Name+" has been created\n");
        public Project(String name)
        {
            Name = name;
            Console.WriteLine("Project " + Name + " has been created\n");
        }

        public Project(String name, List<Task> tasks)
        {
            Name = name;
            Tasks = tasks;
            Console.WriteLine("Project " + Name + " has been created\n");
        }
    }
}