﻿using AutoMapper;
using BursaryTracer.Domain.DTOs;
using BursaryTracer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BursaryTracer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultiesController : ControllerBase
    {
        private readonly IServicesRepository repository;

        public FacultiesController(IServicesRepository servicesRepository)
        {
            repository = servicesRepository;
        }

        // GET: api/Faculties
        [HttpGet]
        public IActionResult GetFaculties()
        {
            var facultyEntitiy = repository.GetFaculties();

            var results = Mapper.Map<IEnumerable<FacaultyWithoutCourseList>>(facultyEntitiy);

            return Ok(results);
        }

        // GET: api/Faculties/5
        [HttpGet("{Id}", Name = "GetFaculty")]
        public IActionResult GetFaculty(int Id, bool IncludeCourseList = false)
        {
            var facultyEntitiy = repository.GetFaculty(Id, IncludeCourseList);

            if (facultyEntitiy == null)
            {
                return NotFound();
            }

            if (IncludeCourseList)
            {
                var results = Mapper.Map<FacaultyDto>(facultyEntitiy);
                return Ok(results);
            }

            var facaultyWithoutCourseListResults = Mapper.Map<FacaultyWithoutCourseList>(facultyEntitiy);

            return Ok(facaultyWithoutCourseListResults);
        }

        // GET: api/Faculties/5/Courses
        [HttpGet("{Id}/Courses", Name = "GetFacultyWithCourseList")]
        public IActionResult GetFacultyWithCourseList(int Id)
        {
            var facultyEntitiy = repository.GetFacultyWithCourseList(Id);

            if (facultyEntitiy == null)
            {
                return NotFound();
            }

            var results = Mapper.Map<FacaultyDto>(facultyEntitiy);
            return Ok(results);
        }

        //// PUT: api/Faculties/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFaculty(int id, Faculty faculty)
        //{
        //    if (id != faculty.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(faculty).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FacultyExists(id))
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

        //// POST: api/Faculties
        //[HttpPost]
        //public async Task<ActionResult<Faculty>> PostFaculty(Faculty faculty)
        //{
        //    _context.Faculties.Add(faculty);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFaculty", new { id = faculty.Id }, faculty);
        //}

        //// DELETE: api/Faculties/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Faculty>> DeleteFaculty(int id)
        //{
        //    var faculty = await _context.Faculties.FindAsync(id);
        //    if (faculty == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Faculties.Remove(faculty);
        //    await _context.SaveChangesAsync();

        //    return faculty;
        //}

        private bool FacultyExists(int id)
        {
            return repository.FacultyExists(id);
        }
    }
}