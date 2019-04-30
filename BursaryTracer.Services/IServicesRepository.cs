using BursaryTracer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BursaryTracer.Services
{
    public interface IServicesRepository
    {
        //State
        bool StateExists(int Id);

        IEnumerable<State> GetStates();

        IEnumerable<State> GetStatesWithGovernors();


        State GetState(int Id, bool IncludeGovernorList/*, bool IncludeSchoolList*/);


        ///Faculties
        ///
        bool FacultyExists(int Id);

        IEnumerable<Faculty> GetFaculties();
        Faculty GetFaculty(int Id, bool IncludeCourseList);


        ///Schools
        ///

        bool SchoolExists(int Id);

        IEnumerable<School> GetSchools();
        School GetSchool(int Id, bool IncludeFacultyList);
    }
}
