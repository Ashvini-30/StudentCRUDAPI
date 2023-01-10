#region usings

using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

#endregion

namespace WebApplication3.Models
{
    public class SubjectRepo : ISubjectRepo
    {
        private readonly StudentContext _subjectContext;
        public SubjectRepo()
        {
            _subjectContext = new StudentContext();
        }

        public List<Subject> AddSubject(Subject model)
        {
            _subjectContext.Subjects.Add(model);
            _subjectContext.SaveChanges();
            return GetSubjectList();
        }

        public void DeleteSubject(int id)
        {

            var subject = _subjectContext.Subjects.FirstOrDefault(e => e.SubjectId == id);
            _subjectContext.Subjects.Remove(subject);
            _subjectContext.SaveChanges();
        }

        public Subject GetSubjectById(int id)
        {
            var subject = _subjectContext.Subjects.FirstOrDefault(e => e.SubjectId == id);
            return subject;
        }

        public List<Subject> GetSubjectList()
        {
            return _subjectContext.Subjects.ToList();
        }

        public Subject UpdateSubject(int id, Subject model)
        {
            var subject = _subjectContext.Subjects.FirstOrDefault(e => e.SubjectId == id);

            subject.SubjectName = model.SubjectName;

            _subjectContext.Subjects.AddOrUpdate(subject);
            _subjectContext.SaveChanges();
            return subject;

        }
    }
}