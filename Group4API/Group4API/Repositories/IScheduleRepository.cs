using Group4API.Models;
// MADE BY JOHNY
namespace Group4API.Repositories
{
    public interface IScheduleRepository
    {
        public IEnumerable<Schedule> GetAllSchedules();
        public Schedule GetScheduleById(int id);
        public Schedule AddSchedule(Schedule schedule);
        public void DeleteScheduleById(int id);
        public void UpdateSchedule(Schedule schedule);
    }
}
