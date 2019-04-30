using System;
using System.Collections.Generic;
using System.Linq;
using BursaryTracer.Data;
using BursaryTracer.Domain;
using Microsoft.EntityFrameworkCore;

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
                return _context.States.Include(options => options.Governors).Include(p=>p.Schools).Where(s => s.Id == Id).FirstOrDefault(/*o => o.Id == Id*/);
            }
            //if (IncludeSchoolList)
            //{
            //    return _context.States.Include(options => options.Schools).Where(s => s.Id == Id).FirstOrDefault(/*o => o.Id == Id*/);
            //}
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
                return _context.Faculties.Include(options => options.Courses).Where(s => s.Id == Id).FirstOrDefault(/*o => o.Id == Id*/);
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
    }
}
