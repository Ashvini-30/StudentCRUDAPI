#region usings

using System.Collections.Generic;
using WebApplication3.Models.Dto;

#endregion

namespace WebApplication3.Models
{
    public interface IStudentRepo
    {
        Student GetStudentById(int id);
        List<Student> GetStudentList();
        List<Student> AddStudent(Student model);
        Student UpdateStudent(int id, Student model);
        void DeleteStudent(int id);
        StudentDto GetStudentDto(int id);
    }
}