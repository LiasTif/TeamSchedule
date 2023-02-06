using System.ComponentModel.DataAnnotations;

namespace TeamScheduleApp.Models
{
    /// <summary>
    /// Person class
    /// </summary>
    public class Person
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string PinCode { get; set; }
    }
}
