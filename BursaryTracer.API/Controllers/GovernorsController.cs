using BursaryTracer.Data;
using BursaryTracer.Domain;
using BursaryTracer.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BursaryTracer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernorsController : ControllerBase
    {
        private readonly BTDbContext _context;

        public GovernorsController(BTDbContext context)
        {
            _context = context;
        }

        // GET: api/Governors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Governor>>> GetGovernors()
        {
            return await _context.Governors.ToListAsync();
        }

        // GET: api/Governors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Governor>> GetGovernor(int id)
        {
            var governor = await _context.Governors.FindAsync(id);

            if (governor == null)
            {
                return NotFound();
            }

            return governor;
        }

        // PUT: api/Governors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGovernor(int id, Governor governor)
        {
            if (id != governor.Id)
            {
                return BadRequest();
            }

            _context.Entry(governor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GovernorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Governors
        [HttpPost]
        public async Task<ActionResult<Governor>> PostGovernor(Governor governor)
        {
            _context.Governors.Add(governor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGovernor", new { id = governor.Id }, governor);
        }

        // DELETE: api/Governors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Governor>> DeleteGovernor(int id)
        {
            var governor = await _context.Governors.FindAsync(id);
            if (governor == null)
            {
                return NotFound();
            }

            _context.Governors.Remove(governor);
            await _context.SaveChangesAsync();

            return governor;
        }

        private bool GovernorExists(int id)
        {
            return _context.Governors.Any(e => e.Id == id);
        }
    }
}