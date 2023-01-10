#region usings

using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;

#endregion

namespace WebApplication3.Controllers
{
    public class SubjectController : ApiController

    {
        private readonly ISubjectRepo _repo;
        public SubjectController()
        {
            _repo = new SubjectRepo();
        }

        public List<Subject> Get()
        {
            return _repo.GetSubjectList();

        }
        public Subject GetSubjectById(int id)
        {
            return _repo.GetSubjectById(id);
        }

        public List<Subject> Post(Subject request)
        {
            var subject = _repo.AddSubject(request);

            return subject;
        }

        public Subject Put(int id, Subject request)
        {
            var subject = _repo.GetSubjectById(id);
            if (subject == null)
            {
                throw new Exception("Subject Id is not exist");
            }
            return _repo.UpdateSubject(id, request);
        }
        public List<Subject> Delete(int id)
        {
            var subject = _repo.GetSubjectById(id);
            if (subject == null)
            {
                throw new Exception("Subject Id is not exist");
            }
            _repo.DeleteSubject(id);
            return _repo.GetSubjectList(); ;
        }

    }
}
