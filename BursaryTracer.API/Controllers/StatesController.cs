using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BursaryTracer.Data;
using BursaryTracer.Domain;
using BursaryTracer.Services;
using AutoMapper;

namespace BursaryTracer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IServicesRepository repository;

        public StatesController(IServicesRepository  servicesRepository)
        {
            repository = servicesRepository;
        }

        // GET: api/States
        [HttpGet]
        public IActionResult GetStates()
        {
            var stateEntitiy = repository.GetStates();

            var results = Mapper.Map<IEnumerable<StateWithoutLists>>(stateEntitiy);

            return Ok(results);
        }

        // GET: api/States
        [Route("/GetStatesWithGovernors")]
        [HttpGet]
        public IActionResult GetStatesWithGovernors()
        {
            var stateEntitiy = repository.GetStates();

            var results = Mapper.Map<IEnumerable<StateWithoutLists>>(stateEntitiy);

            return Ok(results);
        }

        // GET: api/States/5
        [HttpGet("{Id}", Name = "GetState")]
        public IActionResult GetState(int Id, bool IncludeGovernorList = false)
        {

            var stateEntitiy = repository.GetState(Id, IncludeGovernorList);

            if (stateEntitiy == null)
            {
                return NotFound();
            }

            if (IncludeGovernorList)
            {
                var results = Mapper.Map<StateDTO>(stateEntitiy);
                return Ok(results);
            }

            var stateWithoutGovernorListResults = Mapper.Map<StateWithoutLists>(stateEntitiy);

            return Ok(stateWithoutGovernorListResults);
        }

        //// PUT: api/States/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutState(int id, State state)
        //{
        //    if (id != state.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(state).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StateExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/States
        //[HttpPost]
        //public async Task<ActionResult<State>> PostState(State state)
        //{
        //    _context.States.Add(state);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetState", new { id = state.Id }, state);
        //}

        //// DELETE: api/States/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<State>> DeleteState(int id)
        //{
        //    var state = await _context.States.FindAsync(id);
        //    if (state == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.States.Remove(state);
        //    await _context.SaveChangesAsync();

        //    return state;
        //}

        //private bool StateExists(int Id)
        //{
        //    return _context.States.Any(e => e.Id == id);
        //}
    }
}
