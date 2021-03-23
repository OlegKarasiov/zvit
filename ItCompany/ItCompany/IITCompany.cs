using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ItCompany
{
    interface IItCompany
    {
         void AddProject(String name, List<Task> tasks);
         void DeleteProject(int id);
         void UpdateProject(int id, String name, List<Task> tasks);

         void AddTask(int ProjectID, User assignedUser, String taskName, String description, Status taskStatus);
         void DeleteTask(int ProjectID, int TaskID);
         void UpdateTask(int ProjectID, int TaskID, User assignedUser, String taskName, String description,
             Status taskStatus);

         void AddUser();
         void DeleteUser();
         void UpdateUser();

         void AddDepartment();
         void DeleteDepartment();
         void UpdateDepartment();

         void Login();
         void Register();
    }
}
