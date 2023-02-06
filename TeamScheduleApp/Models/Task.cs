using System.ComponentModel.DataAnnotations;
using System;

namespace TeamScheduleApp.Models
{
    /// <summary>
    /// Task class
    /// </summary>
    public class Task
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public Person NextPerformer { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsDone { get; set; }
        public string Description { get; set; }
    }
}