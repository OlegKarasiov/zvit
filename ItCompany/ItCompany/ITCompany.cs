using System;
using System.Collections.Generic;

namespace ItCompany
{
    class ItCompany : IItCompany
    {
        private String name = "NO_NAME_COMPANY";
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Project> projects;
        private List<User> users;
        private List<Department> departments;
        private List<UserToDepartment> userToDepartments;

        public ItCompany()
        {
            projects = new List<Project>();
            users = new List<User>();
            departments = new List<Department>();
            userToDepartments = new List<UserToDepartment>();
            
            users.AddRange(new List<User>
            {
                new User(),
                new User("Oleg", "Karasiov", "kentafurik@gmail.com", "123", Role.Employee),
                new User("Nazar", "Trukhan", "kiberbubling@gmail.com", "123", Role.Admin),
                new User("Kolyan", "Melnyk", "BIG_BOY_IS_BACK_IN_TOWN@gmail.com", "123", Role.ProjectManager),
            });

            departments.AddRange( new List<Department>
            {
                new Department(),
                new Department("Dep", users.Find(x=>x.FirstName.Equals("Kolyan")), users)
            });

            userToDepartments.AddRange(new List<UserToDepartment>
            {
                new UserToDepartment(users.Find(x=>x.FirstName.Equals("Oleg")), departments.Find(x=>x.Name.Equals("Dep")))
            });

            projects.AddRange(new List<Project> { 
                new Project(),
                new Project("Project 1"),
                new Project("Project 2", new List<Task>{
                    new Task(),
                    new Task(users.Find(x=>x.FirstName.Equals("Oleg")),"Chill","Chilling",Status.InProgress) 
                })
            });

            Console.WriteLine("IT-Company has been created");
        }

        public void AddProject(String name, List<Task> tasks) => projects.Add(new Project(name, tasks));
        public void DeleteProject(int id) => projects.Remove(projects.Find(x => x.ID.Equals(id)));
        public void UpdateProject(int id, String name, List<Task> tasks)
        {
            Project project = projects.Find(x => x.ID.Equals(id));
            project.Name = name;
            project.Tasks = tasks;
        }


        public void AddTask(int ProjectID, User assignedUser, String taskName, String description, Status taskStatus) => projects.Find(x=>x.ID.Equals(ProjectID)).Tasks.Add(new Task(assignedUser,taskName, description, taskStatus));
        public void DeleteTask(int ProjectID, int TaskID) => projects.Find(x => x.ID.Equals(ProjectID)).Tasks.Remove(projects.Find(x => x.ID.Equals(ProjectID)).Tasks.Find(x=>x.ID.Equals(TaskID)));
        public void UpdateTask(int ProjectID, int TaskID, User assignedUser, String taskName, String description, Status taskStatus)
        {
            Task task = projects.Find(x => x.ID.Equals(ProjectID)).Tasks.Find(x => x.ID.Equals(TaskID));
            task.AssignedUser = assignedUser;
            task.Name = taskName;
            task.Description = description;
            task.TaskStatus = taskStatus;
        }

        public void AddUser()=>throw new NotImplementedException();
        public void DeleteUser()=>throw  new NotImplementedException();
        public void UpdateUser()=>throw new NotImplementedException();

        public void AddDepartment() => throw new NotImplementedException();
        public void DeleteDepartment() => throw new NotImplementedException();
        public void UpdateDepartment() => throw new NotImplementedException();

        public void Login() => throw new NotImplementedException();
        public void Register() => throw new NotImplementedException();
    }
}
