using Todo_List.Model;

namespace Todo_List.Service
{
    public class XMLTaskService
    {
        public XMLTaskService() { }

        private List<ToDoTask> LoadXML() {
            
            Greturn new List<ToDoTask>(); }
        private void SaveXML(List<ToDoTask> task ) {}
        public ToDoTask CreateTask(ToDoTask task) { return new ToDoTask(); }
        public void DeleteTask(int taskId) { }
        public ToDoTask UpdateTask(int taskId, ToDoTask toDoTask) { return new ToDoTask(); }
        public ToDoTask UpdateTaskStatus(int taskId, Model.TaskStatus status) { return new ToDoTask(); }
        public List<ToDoTask> GetAllTask() { return new List<ToDoTask>(); }
    }
}
