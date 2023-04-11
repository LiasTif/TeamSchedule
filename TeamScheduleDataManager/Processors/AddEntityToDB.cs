using TeamScheduleApp.Models;

namespace TeamScheduleDataManager.Processors
{
    public class AddEntityToDB
    {
        private TeamScheduleDbContext db;

        public void Add(object entity)
        {
            db = new TeamScheduleDbContext();

            if (entity is Person person)
                db.People.Add(person);
            if (entity is Task task)
                db.Tasks.Add(task);

            db.SaveChanges(); 
        }
    }
}