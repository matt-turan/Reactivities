using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        // private readonly DataContext context;
        private readonly DataContext _context;

        public ActivitiesController(DataContext context) // dependency injection
        {
            // "this" refers "context" --> "private readonly DataContext context;"
            // this.context = context;
            _context = context;
        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //api/activities/idididid
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }

    }
}