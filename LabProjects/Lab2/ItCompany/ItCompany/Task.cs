using System;

namespace ItCompany
{
    public class Task
    {
        public int ID { get; } = Guid.NewGuid().GetHashCode();
        public User AssignedUser { get; set; } = null;
        public String Name { get; set; } = "Untitled";
        public String Description { get; set; } = "No description";
        public Status TaskStatus { get; set; } = Status.Open;

        public Task() => Console.WriteLine("Task " + Name + " has been created");

        public Task(User assignedUser, String taskName, String description, Status taskStatus)
        {
            AssignedUser = assignedUser;
            Name = taskName;
            Description = description;
            TaskStatus = taskStatus;
            Console.WriteLine("Task " + Name + " has been created");
        }
    }
}