using System;

namespace ItCompany
{
    public class User
    {
        public int ID { get; } = Guid.NewGuid().GetHashCode();
        public String FirstName { get; set; } = "No First Name";
        public String LastName { get; set; } = "No Last Name";
        public String Email { get; set; } = "No email";
        public String PasswordHash { get; } = "No Password Hash";
        public Role UserRole { get; } = Role.Employee;
        private int salary =0;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public static User operator ++(User user)
        {
            user.salary++;
            return user;
        }
        public static User operator +(User user, int add)
        {
            user.salary += add;
            return user;
        }
        public static User operator !(User user)
        {
            user.salary = 0;
            return user;
        }
        public static bool operator >(User a, User b)
        {
            return a.salary > b.salary;
        }
        public static bool operator <(User a, User b)
        {
            return a.salary < b.salary;
        }
        public static bool operator ==(User a, User b)
        {
            return a.salary == b.salary;
        }
        public static bool operator !=(User a, User b)
        {
            return a.salary != b.salary;
        }

        public User() => Console.WriteLine("User " + FirstName + " has been created");

        public User(String firstName, String lastName, String email, String passwordHash, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            UserRole = role;
            Console.WriteLine("User " + FirstName + " has been created");
        }

    }
}