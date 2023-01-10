#region usings

using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

#endregion

namespace WebApplication3.Models
{
    public class MarkRepo : IMarkRepo
    {
        private  readonly StudentContext _markContext;
        public MarkRepo()
        {
            _markContext = new StudentContext();
        }

        public List<Mark> AddMark(Mark model)
        {
            _markContext.Marks.Add(model);
            _markContext.SaveChanges();
            return GetMarkList();
        }

        public void DeleteMark(int id)
        {

            var mark = _markContext.Marks.FirstOrDefault(e => e.Id == id);
            _markContext.Marks.Remove(mark);
            _markContext.SaveChanges();
        }

        public Mark GetMarkById(int id)
        {
            var mark = _markContext.Marks.FirstOrDefault(e => e.Id == id);
            return mark;
        }

        public List<Mark> GetMarkList()
        {
            return _markContext.Marks.ToList();
        }

        public Mark UpdateMark(int id, Mark model)
        {
            var mark = _markContext.Marks.FirstOrDefault(e => e.Id == id);
            mark.Marks = model.Marks;

            _markContext.Marks.AddOrUpdate(mark);
            _markContext.SaveChanges();
            return mark;

        }
    }
}