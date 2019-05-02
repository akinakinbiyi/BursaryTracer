using AutoMapper;
using BursaryTracer.Domain.StatesFolder;
using BursaryTracer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BursaryTracer.API.Controllers
{
    [Route("api/States")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IServicesRepository repository;

        public StatesController(IServicesRepository servicesRepository)
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

        //// GET: api/States
        //[HttpGet("{Id}/GetStateWithAll", Name = "GetStateWithAll")]
        //public IActionResult GetStateWithAll(int Id, bool IncludeRelatedData)
        //{
        //    var stateEntitiy = repository.GetSchool(Id, IncludeRelatedData);

        //    if (stateEntitiy == null)
        //    {
        //        return NotFound();
        //    }

        //    if (IncludeRelatedData)
        //    {
        //        var results = Mapper.Map<StateDto>(stateEntitiy);
        //        return Ok(results);
        //    }

        //    var stateWithoutListsResults = Mapper.Map<StateWithoutLists>(stateEntitiy);

        //    return Ok(stateWithoutListsResults);
        //}

        // GET: api/States/5
        [HttpGet("{Id}", Name = "GetState")]
        public IActionResult GetState(int Id, bool IncludeRelatedData = false)
        {
            var stateEntitiy = repository.GetStateWithAll(Id, IncludeRelatedData);

            if (stateEntitiy == null)
            {
                return NotFound();
            }

            if (IncludeRelatedData)
            {
                var results = Mapper.Map<StateDto>(stateEntitiy);
                return Ok(results);
            }

            var stateWithoutListsResults = Mapper.Map<StateWithoutLists>(stateEntitiy);

            return Ok(stateWithoutListsResults);
        }

        // GET: api/States/5/Governors
        [HttpGet("{Id}/Governors", Name = "GetStateWithGovernorList")]
        public IActionResult GetStateWithGovernorList(int Id)
        {
            var stateEntitiy = repository.GetStateWithGovernorList(Id);

            if (stateEntitiy == null)
            {
                return NotFound();
            }

            var results = Mapper.Map<StateWithGovernorList>(stateEntitiy);
            return Ok(results);
        }

        // GET: api/States/5/Cities
        [HttpGet("{Id}/Cities", Name = "GetStateWithCityList")]
        public IActionResult GetStateWithCityList(int Id)
        {
            var stateEntitiy = repository.GetStateWithCityList(Id);

            if (stateEntitiy == null)
            {
                return NotFound();
            }

            var results = Mapper.Map<StateWithCityList>(stateEntitiy);
            return Ok(results);
        }

        // GET: api/States/5/Schools
        [HttpGet("{Id}/Schools", Name = "GetStateWithSchoolList")]
        public IActionResult GetStateWithSchoolList(int Id)
        {
            var stateEntitiy = repository.GetStateWithSchoolList(Id);

            if (stateEntitiy == null)
            {
                return NotFound();
            }

            var results = Mapper.Map<StateWithSchoolList>(stateEntitiy);
            return Ok(results);
        }

        // GET: api/States/5/Students
        [HttpGet("{Id}/Students", Name = "GetStateWithCitizenList")]
        public IActionResult GetStateWithCitizenList(int Id)
        {
            var stateEntitiy = repository.GetStateWithCitizenList(Id);

            if (stateEntitiy == null)
            {
                return NotFound();
            }

            var results = Mapper.Map<StateWithCitizenList>(stateEntitiy);
            return Ok(results);
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