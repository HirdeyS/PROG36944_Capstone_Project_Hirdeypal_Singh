namespace Capstone_Project_Piyush_Hirdey.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }

        // Navigation
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
