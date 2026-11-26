using Group4API.Models;
using Group4API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Group4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleRepository _scheduleRepository;
        
        public ScheduleController(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        [HttpGet]
        public ActionResult<Schedule> GetSechules()
        {
            var schedules = _scheduleRepository.GetAllSchedules();
            return Ok(schedules);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Schedule> GetScheduleById(int id)
        {
            var schedule = _scheduleRepository.GetScheduleById(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return Ok(schedule);
        }

        [HttpPost]
        public ActionResult<Schedule> AddSchedule(Schedule schedule)
        {
            var addedSchedule = _scheduleRepository.AddSchedule(schedule);
            return CreatedAtAction(nameof(GetScheduleById), new { id = addedSchedule.ScheduleId }, addedSchedule);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Schedule> UpdateSchedule(int id, Schedule schedule)
        {
            if (id != schedule.ScheduleId)
            {
                return NotFound();
            }
            _scheduleRepository.UpdateSchedule(schedule);
            return Ok(schedule);
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteSchedule(int id)
        {
            var schedule = _scheduleRepository.GetScheduleById(id);
            if (schedule == null)
            {
                return NotFound();
            }
            _scheduleRepository.DeleteScheduleById(id);
            return NoContent();
        }
    }
}
