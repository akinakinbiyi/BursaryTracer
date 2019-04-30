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

        public State GetState(int Id, bool IncludeGovernorList)
        {
            if (IncludeGovernorList)
            {
                return _context.States.Include(options => options.Governors).Where(o => o.Id == Id).FirstOrDefault();
            }

            return _context.States.Where(o => o.Id == Id).FirstOrDefault();
        }

        public IEnumerable<State> GetStates()
        {
            return _context.States.OrderBy(options => options.Name).ToList();
        }

        public bool StateExists(int Id)
        {
            return _context.States.Any(e => e.Id == Id);
        }

    }
}
