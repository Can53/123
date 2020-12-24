using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class StudentsService
    {
        //获取数据表的总条数
        public static int GetRows()
        {
            StudentsEntities entities = new StudentsEntities();
            return entities.students.Count();
        }

        public static PageList PageListDemo(int pageindex,int pagesize)
        {
            StudentsEntities entities = new StudentsEntities();
            PageList list = new PageList();
            var obj = from p in entities.students
                      orderby p.id
                      select new
                      {
                          id = p.id,
                          name = p.name,
                          age = p.age,
                          cName = p.classes.name,
                      };
            //设置分页数据
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);

            int rows = entities.students.Count();
            //设置总页数
            list.PageCount = rows % pagesize == 0 ? rows / pagesize : rows / pagesize + 1;
            return list;

        }

        public static int Del(int id)
        {
            StudentsEntities entities = new StudentsEntities();
            var obj = (from p in entities.students where p.id == id select p).First();
            entities.students.Remove(obj);
            return entities.SaveChanges();
        }

        public static int Add(students s)
        {
            StudentsEntities entities = new StudentsEntities();
            entities.students.Add(s);
            return entities.SaveChanges();
        }

        public static IQueryable GetById(int id)
        {
            StudentsEntities entity = new StudentsEntities();
            var obj = from p in entity.students
                      where p.id == id
                      select new
                      {
                          id = p.id,
                          name = p.name,
                          age = p.age,
                          class_id = p.class_id
                      };
            return obj;

        }


        public static int Edit(students s)
        {
            StudentsEntities entity = new StudentsEntities();
            var obj = (from p in entity.students where p.id == s.id select p).First();
            obj.name = s.name;
            obj.age = s.age;
            obj.class_id = s.class_id;
            return entity.SaveChanges();
        }



    }
}
