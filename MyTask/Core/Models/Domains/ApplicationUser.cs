using Microsoft.AspNetCore.Identity;
using System.Collections.ObjectModel;
using MyTask.Core.ViewModels;

namespace MyTask.Core.Models.Domains
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser()
        {
            Tasks = new Collection<MyTasks>();
        }
        public ICollection<MyTasks> Tasks { get; set; }
    }
}
