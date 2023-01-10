#region usings

using System.Collections.Generic;

#endregion

namespace WebApplication3.Models
{
    public interface ISubjectRepo
    {
        Subject GetSubjectById(int id);

        List<Subject> GetSubjectList();

        List<Subject> AddSubject(Subject model);

        Subject UpdateSubject(int id, Subject model);
        void DeleteSubject(int id);
    }
}