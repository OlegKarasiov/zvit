using System;
using System.Collections.Generic;

namespace ItCompany
{
    public class Project : Entity
    {
        public int ID { get; } = Guid.NewGuid().GetHashCode();
        public string Name { get; set; } = "Untitled";
        public List<Task> Tasks { get; set; } = new List<Task>();

        public Project() : base() => Console.WriteLine("Project "+Name+" has been created\n");
        public Project(String name) : base()
        {
            Name = name;
        }

        public Project(String name, List<Task> tasks) : base()
        {
            Name = name;
            Tasks = tasks;
            Console.WriteLine("Project " + Name + " has been created\n");
        }

        public override void DisplayName()
        {
            Console.WriteLine("Project " + Name + " has been created\n");
        }
    }
}