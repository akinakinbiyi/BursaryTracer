using BursaryTracer.Domain;
using BursaryTracer.Domain.Entities;
using System.Collections.Generic;

namespace BursaryTracer.Services
{
    public interface IServicesRepository
    {
        //State
        bool StateExists(int Id);

        IEnumerable<State> GetStates();

        IEnumerable<State> GetStatesWithGovernors();

        State GetState(int Id);
        State GetStateWithGovernorList(int Id);
        State GetStateWithCityList(int Id);
        State GetStateWithSchoolList(int Id);
        State GetStateWithCitizenList(int Id);
        State GetStateWithAll(int Id, bool IncludeRelatedData);

        ///
        bool FacultyExists(int Id);

        IEnumerable<Faculty> GetFaculties();

        Faculty GetFaculty(int Id, bool IncludeCourseList);
        Faculty GetFacultyWithCourseList(int Id);


        ///Schools
        ///

        bool SchoolExists(int Id);

        IEnumerable<School> GetSchools();

        School GetSchool(int Id, bool IncludeFacultyList);
    }
}