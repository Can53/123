using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
   public  class ClassesService
    {
        public static IQueryable GetClasses()
        {
            StudentsEntities entities = new StudentsEntities();
            var obj = from p in entities.classes
                      select new
                      {
                          id = p.id,
                          name = p.name
                      };
            return obj;
        }
    }
}
