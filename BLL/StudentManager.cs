using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class StudentManager
    {
        public static PageList PageListDemo(int pageindex, int pagesize)
        {
            return StudentsService.PageListDemo(pageindex,pagesize);
        }

        public static int Del(int id)
        {
            return StudentsService.Del(id);
        }

        public static int Add(students s)
        {
            return StudentsService.Add(s);
        }

        public static IQueryable GetById(int id)
        {
            return StudentsService.GetById(id);
        }

        public static int Edit(students s)
        {
            return StudentsService.Edit(s);
        }

        public static int GetRows()
        {
            return StudentsService.GetRows();
        }


    }
}
