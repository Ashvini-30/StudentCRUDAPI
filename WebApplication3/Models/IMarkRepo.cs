using System.Collections.Generic;

namespace WebApplication3.Models
{
    public interface IMarkRepo
    {
        Mark GetMarkById(int id);
        List<Mark> GetMarkList();
        List<Mark> AddMark(Mark model);
        Mark UpdateMark(int id, Mark model);
        void DeleteMark(int id);
    }
}