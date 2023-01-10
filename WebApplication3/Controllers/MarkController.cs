#region usings

using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;

#endregion

namespace WebApplication3.Controllers
{
    public class MarkController : ApiController
    {
        private readonly IMarkRepo _repo;
        public MarkController()
        {
            _repo = new MarkRepo();
        }

        public List<Mark> Get()
        {
            return _repo.GetMarkList();

        }
        public Mark GetMarkById(int id)
        {
            return _repo.GetMarkById(id);
        }

        public List<Mark> Post(Mark request)
        {
            var mark = _repo.AddMark(request);

            return mark;
        }

        public Mark Put(int id, Mark request)
        {
            var mark = _repo.GetMarkById(id);
            if (mark == null)
            {
                throw new Exception("Mark Id is not exist");
            }
            return _repo.UpdateMark(id, request);
        }

        public List<Mark> Delete(int id)
        {
            var mark = _repo.GetMarkById(id);
            if (mark == null)
            {
                throw new Exception("Mark Id is not exist");
            }
            _repo.DeleteMark(id);
            return _repo.GetMarkList(); ;
        }

    }
}
