using System.Data;

namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title {  get; set; }
        public string? Description { get; set; }
        public DateTime? CreateTDate { get; set; }
        public DateTime? FinishTDate { get; set; }
    }
}
