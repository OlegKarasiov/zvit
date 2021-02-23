using System;

namespace ItCompany
{
    public class User
    {
        public int ID { get; } = Guid.NewGuid().GetHashCode();
        public String FirstName { get; } = "No First Name";
        public String LastName { get; } = "No Last Name";
        public String Email { get; } = "No email";
        public String PasswordHash { get; } = "No Password Hash";
        public Role UserRole { get; } = Role.Employee;

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