using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nxLINEadminAPI.Entity;
using System.Collections.Generic;

namespace nxLINEadminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RallyController : ControllerBase
    {
        private readonly nxLINEadminAPIContext _context;

        public RallyController(nxLINEadminAPIContext context)
        {
            _context = context;
        }

        // GET: api/Event
        [HttpGet("Event")]
        public async Task<ActionResult<Event>> GetEvent(string liffId)
        {
            if (_context.Events == null)
            {
                return NotFound();
            }

            var ev = _context.Events.Where(c => c.EventLiffid == liffId).FirstOrDefault();
            if (ev != null)
            {
                var cps = _context.Checkpoints.Where(c => c.CheckpointEventId == ev.EventId).ToList();
            }
            return ev;
        }

        // GET: api/Event
        [HttpGet("Event_with_Checkins")]
        public async Task<ActionResult<Event>> GetEvent_with_Checkinst(string liffId, string userId)
        {
            if (_context.Events == null)
            {
                return NotFound();
            }

            var ev = _context.Events.Where(c => c.EventLiffid == liffId).FirstOrDefault();
            if (ev != null)
            {
                var cps = _context.Checkpoints.Where(c => c.CheckpointEventId == ev.EventId).ToList();
                foreach (var cp in cps)
                {
                    var ci = _context.Checkins.Where(c => c.CheckinCheckpointId == cp.CheckpointId && c.CheckinUserid == userId).ToList();
                }
            }
            return ev;
        }

        // GET: api/Checkins
        [HttpGet("Checkins")]
        public async Task<ActionResult<ICollection<Checkin>>> GetCheckins(string lineId)
        {
            if (_context.Checkins == null)
            {
                return NotFound();
            }

            return await _context.Checkins.Where(c => c.CheckinLineid == lineId).ToListAsync();
        }
    }
}
