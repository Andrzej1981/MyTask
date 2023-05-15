using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using MyTask.Core.ViewModels;

namespace MyTask.Core.Models.Domains
{
    public class Category
    {

        public Category()
        {
            Tasks = new Collection<MyTasks>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<MyTasks> Tasks { get;set; }

    }
}
