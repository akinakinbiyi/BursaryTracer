using BursaryTracer.Data;
using BursaryTracer.Domain;
using BursaryTracer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BursaryTracer.Services
{
    public class ServicesRepository : IServicesRepository
    {
        private readonly BTDbContext _context;

        public ServicesRepository(BTDbContext context)
        {
            _context = context;
        }

        public IEnumerable<State> GetStatesWithGovernors()
        {
            return _context.States.Include(s => s.Governors).ToList();
        }

        public State GetState(int Id, bool IncludeGovernorList)
        {
            if (IncludeGovernorList)
            {
                return _context.States.Include(options => options.Governors)
                    .Include(p => p.Schools)
                    .Include(c => c.Cities)
                    .Where(s => s.Id == Id).FirstOrDefault();
            }

            return _context.States.Where(o => o.Id == Id).FirstOrDefault();
        }

        public IEnumerable<State> GetStates()
        {
            return _context.States.ToList();
        }

        public bool StateExists(int Id)
        {
            return _context.States.Any(e => e.Id == Id);
        }

        public bool FacultyExists(int Id)
        {
            return _context.Faculties.Any(e => e.Id == Id);
        }

        public IEnumerable<Faculty> GetFaculties()
        {
            return _context.Faculties.ToList();
        }

        public Faculty GetFaculty(int Id, bool IncludeCourseList)
        {
            if (IncludeCourseList)
            {
                return _context.Faculties.Include(options => options.Courses).Where(s => s.Id == Id).FirstOrDefault();
            }
            return _context.Faculties.Where(o => o.Id == Id).FirstOrDefault();
        }

        public bool SchoolExists(int Id)
        {
            return _context.Schools.Any(e => e.Id == Id);
        }

        public IEnumerable<School> GetSchools()
        {
            return _context.Schools.ToList();
        }

        public School GetSchool(int Id, bool IncludeFacultyList)
        {
            if (IncludeFacultyList)
            {
                return _context.Schools.Include(options => options.Faculties).FirstOrDefault();
            }
            return _context.Schools.Where(o => o.Id == Id).FirstOrDefault();
        }

        public State GetState(int Id)
        {
            return _context.States.Where(o => o.Id == Id).FirstOrDefault();
        }

        public State GetStateWithGovernorList(int Id)
        {
            return _context.States.Include(options => options.Governors)
                .Where(s => s.Id == Id).FirstOrDefault();
        }

        public State GetStateWithCityList(int Id)
        {
            return _context.States.Include(options => options.Cities)
                .Where(s => s.Id == Id).FirstOrDefault();
        }

        public State GetStateWithSchoolList(int Id)
        {
            return _context.States.Include(options => options.Schools)
                .Where(s => s.Id == Id).FirstOrDefault();
        }

        public State GetStateWithCitizenList(int Id)
        {
            return _context.States.Include(options => options.Students)
                .Where(s => s.Id == Id).FirstOrDefault();
        }

        public State GetStateWithAll(int Id, bool IncludeRelatedData)
        {
            if (IncludeRelatedData)
            {
                return _context.States
                    .Include(options => options.Governors)
                    .Include(options => options.Schools)
                    .Include(options => options.Students)
                    .Include(options => options.Cities)
                     .FirstOrDefault();
            }
            return _context.States.Where(o => o.Id == Id).FirstOrDefault();
        }

        public Faculty GetFacultyWithCourseList(int Id)
        {
            return _context.Faculties.Include(options => options.Courses)
                .Where(f => f.Id == Id).FirstOrDefault();
        }
    }
}