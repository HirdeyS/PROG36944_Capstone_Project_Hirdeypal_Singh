namespace Capstone_Project_Piyush_Hirdey.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
