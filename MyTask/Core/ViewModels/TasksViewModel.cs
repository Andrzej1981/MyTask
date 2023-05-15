using MyTask.Core.Models;
using MyTask.Core.Models.Domains;

namespace MyTask.Core.ViewModels
{
    public class TasksViewModel
    {
        public IEnumerable<MyTasks> Tasks { get; set;}
        public IEnumerable<Category> Categories { get; set; }
        public FilterTasks FilterTasks { get; set; }
    }
}
