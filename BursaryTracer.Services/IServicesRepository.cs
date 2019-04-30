using BursaryTracer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BursaryTracer.Services
{
    public interface IServicesRepository
    {
        bool StateExists(int Id);

        IEnumerable<State> GetStates();

        State GetState(int Id, bool IncludeGovernorList);

    }
}
