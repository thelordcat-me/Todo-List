using System.ComponentModel.DataAnnotations;

namespace Todo_List.Model
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; } = string.Empty;
        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
