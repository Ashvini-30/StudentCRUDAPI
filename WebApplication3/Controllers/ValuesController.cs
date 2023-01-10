#region usings

using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;
using WebApplication3.Models.Dto;

#endregion

namespace WebApplication3.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IStudentRepo _repo;
        public ValuesController()
        {
            _repo = new StudentRepo();
        }
      
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        public StudentDto Get(int id)
        {
            return _repo.GetStudentDto(id);
        }
    
    }
}
