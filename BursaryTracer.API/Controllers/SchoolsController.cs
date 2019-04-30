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
    public class SchoolsController : ControllerBase
    {
        private readonly IServicesRepository repository;

        public SchoolsController(IServicesRepository servicesRepository)
        {
            repository = servicesRepository;
        }

        // GET: api/Schools
        [HttpGet]
        public IActionResult GetSchools()
        {
            var schoolEntitiy = repository.GetSchools();

            var results = Mapper.Map<IEnumerable<SchoolWithoutFacultyLists>>(schoolEntitiy);

            return Ok(results);
        }

        // GET: api/Schools/5
        [HttpGet("{Id}", Name = "GetSchool")]
        public IActionResult GetSchool(int Id, bool IncludeFacultyList = false)
        {

            var schoolEntitiy = repository.GetSchool(Id, IncludeFacultyList);

            if (schoolEntitiy == null)
            {
                return NotFound();
            }

            if (IncludeFacultyList)
            {
                var results = Mapper.Map<SchoolDTO>(schoolEntitiy);
                return Ok(results);
            }

            var schoolWithoutFacultyListsResults = Mapper.Map<SchoolWithoutFacultyLists>(schoolEntitiy);

            return Ok(schoolWithoutFacultyListsResults);
        }


        //// PUT: api/Schools/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSchool(int id, School school)
        //{
        //    if (id != school.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(school).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SchoolExists(id))
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

        //// POST: api/Schools
        //[HttpPost]
        //public async Task<ActionResult<School>> PostSchool(School school)
        //{
        //    _context.Schools.Add(school);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSchool", new { id = school.Id }, school);
        //}

        //// DELETE: api/Schools/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<School>> DeleteSchool(int id)
        //{
        //    var school = await _context.Schools.FindAsync(id);
        //    if (school == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Schools.Remove(school);
        //    await _context.SaveChangesAsync();

        //    return school;
        //}

        private bool SchoolExists(int id)
        {
            return repository.SchoolExists(id);
        }
    }
}
