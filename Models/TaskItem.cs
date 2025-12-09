namespace Capstone_Project_Piyush_Hirdey.Models
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TaskPriority Priority { get; set; }
        public TaskStatus Status { get; set; }

        // Foreign Keys
        public int? EmployeeId { get; set; }
        public int? ProjectId { get; set; }

        // Navigation
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }

}
