using Examen.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EventsController: ControllerBase
    {
        private readonly DatabaseContext _context;

        public EventsController(DatabaseContext context){
            _context = context;
        }

        public async Task<ActionResult<Event>> GetEvent(long id)
        {
            var branch = await _context.Events.FindAsync(id);
            if (branch == null) {
                return NotFound();
            }
            return branch;
        }

        [HttpPost]
    
        public async Task<ActionResult<Event>> PostEvent(Event branch){
             DateTime.Parse(branch.initialDate.ToString());
            _context.Events.Add(branch);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetBranch", new { id = branch.Id }, branch);
        }
        
        [HttpGet]
        // https://localhost:5001/api/branches
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }
        [HttpDelete("{id}")]
       
        public async Task<ActionResult<Event>> DeleteEvent(long id){
            var branch = await _context.Events.FindAsync(id);
            if (branch == null) {
                return NotFound();
            }

            _context.Events.Remove(branch);
            await _context.SaveChangesAsync();
            return branch;
        }
        
    }
}