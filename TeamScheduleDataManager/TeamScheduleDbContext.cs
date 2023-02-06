using System.Data.Entity;
using TeamScheduleApp.Models;

namespace TeamScheduleDataManager
{
    /// <summary>
    /// Data Base context for TeamScheduleApp
    /// </summary>
    public class TeamScheduleDbContext : DbContext
    {
        public TeamScheduleDbContext() : base("DbTeamSchedule")
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Person> People { get; set; }
    }
}