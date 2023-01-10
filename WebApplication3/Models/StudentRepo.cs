#region usings

using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using WebApplication3.Models.Dto;

#endregion

namespace WebApplication3.Models
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentContext _studentContext;
        public StudentRepo()
        {
            _studentContext = new StudentContext();
        }

        public List<Student> AddStudent(Student model)
        {
            _studentContext.Students.Add(model);
            _studentContext.SaveChanges();
            return GetStudentList();
        }

        public void DeleteStudent(int id)
        {
            var Student = _studentContext.Students.FirstOrDefault(e => e.StudentId == id);
            _studentContext.Students.Remove(Student);
            _studentContext.SaveChanges();
        }

        public Student GetStudentById(int id)
        {
            var student = _studentContext.Students.FirstOrDefault(e => e.StudentId == id);
            _studentContext.SaveChanges();
            return student;
        }

        public StudentDto GetStudentDto(int id)
        {
            var marks = _studentContext.Marks.Where(m => m.StudentId == id).ToList();

            var subjectDto = new List<SubjectDto>();
            foreach (var mark in marks)
            {
                var sub = new SubjectDto();
                sub.SubjectName = mark.Subjects.SubjectName;
                sub.SubjectId = mark.SubjectId;
                sub.Mark = mark.Marks;
                subjectDto.Add(sub);
            }

            var dto = new StudentDto
            {
                StudentId = id,
                Subjects = subjectDto
            };

            return dto;

        }

        public List<Student> GetStudentList()
        {
            return _studentContext.Students.ToList();
        }

        public Student UpdateStudent(int id, Student model)
        {
            var student = _studentContext.Students.FirstOrDefault(e => e.StudentId == id);

            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Email = model.Email;
            student.MobileNumber = model.MobileNumber;

            _studentContext.Students.AddOrUpdate(student);
            _studentContext.SaveChanges();
            return student;
        }
    }
}