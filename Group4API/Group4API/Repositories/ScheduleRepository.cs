using Group4API.DataAccessLayer;
using Group4API.Models;

namespace Group4API.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly JobManagementDbContext _context;
        public ScheduleRepository(JobManagementDbContext context)
        {
            _context = context;
        }

        public Schedule AddSchedule(Schedule schedule)
        {
            if (schedule == null)
            {
                throw new ArgumentNullException("Schedule information is invalid.\n");
            }

            _context.Schedules.Add(schedule);
            _context.SaveChanges();

            return schedule;
        }

        public void DeleteScheduleById(int id)
        {
            var Schedule = GetScheduleById(id);
            if (Schedule != null)
            {
                _context.Schedules.Remove(Schedule);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Schedule id is not found.\n");
            }
        }

        public IEnumerable<Schedule> GetAllSchedules()
        {
            return _context.Schedules;
        }

        public Schedule GetScheduleById(int id)
        {
            return _context.Schedules.FirstOrDefault(s => s.ScheduleId == id);
        }

        public void UpdateSchedule(Schedule schedule)
        {
            var existingSchedule = GetScheduleById(schedule.ScheduleId);
            if (existingSchedule != null)
            {
                existingSchedule.StartDate = schedule.StartDate;
                existingSchedule.EndDate = schedule.EndDate;
                existingSchedule.JobId = schedule.JobId;
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Schedule id is not found.\n");
            }
        }
    }
}
