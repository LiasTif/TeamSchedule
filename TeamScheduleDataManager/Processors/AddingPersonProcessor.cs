using TeamScheduleApp.Models;

namespace TeamScheduleDataManager.Processors
{
    public class AddingPersonProcessor
    {
        public void AddPerson(Person person)
        {
            using (var db = new TeamScheduleDbContext())
            {
                db.People.Add(person);
                db.SaveChanges();
            }
        }
    }
}