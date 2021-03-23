using System;

namespace ItCompany
{
    public class UserToDepartment : Entity
    {
        public int ID { get; } = Guid.NewGuid().GetHashCode();
        public User User { get; }
        public Department Department { get; }

        public UserToDepartment(User user, Department department)
        {
            User = user;
            Department = department;
            Console.WriteLine("Connection: user " + User.FirstName + " to department "+Department.Name+" has been created");
        }

        public override void DisplayName()
        {
            throw new NotImplementedException();
        }
    }
}