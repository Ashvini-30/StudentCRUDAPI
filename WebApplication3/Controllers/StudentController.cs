#region usings

using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;

#endregion

namespace WebApplication3.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentRepo _repo;
        public StudentController()
        {
            _repo = new StudentRepo();
        }

        public List<Student> Get()
        {
            return _repo.GetStudentList();
        }
        public Student GetStudentById(int id)
        {
            return _repo.GetStudentById(id);
        }

        public List<Student> AddStudent(Student request)
        {
            var student = _repo.AddStudent(request);

            return student;
        }

        public Student Put(int id, Student request)
        {
            var student = _repo.GetStudentById(id);
            if (student == null)
            {
                throw new Exception("Student Id is not exist");
            }
            return _repo.UpdateStudent(id, request);
        }

        public List<Student> Delete(int id)
        {
            var student = _repo.GetStudentById(id);
            if (student == null)
            {
                throw new Exception("Student Id is not exist");
            }
            _repo.DeleteStudent(id);
            return _repo.GetStudentList(); ;
        }

    }
}
