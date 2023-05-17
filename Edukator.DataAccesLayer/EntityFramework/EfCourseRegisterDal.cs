using Edukator.DataAccesLayer.Abstract;
using Edukator.DataAccesLayer.Concrete;
using Edukator.DataAccesLayer.Repostories;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccesLayer.EntityFramework
{
    public class EfCourseRegisterDal : GenericRepostory<CourseRegister>, ICourseRegisterDal

    {
        public List<CourseRegister> CourseRegisterListWithCourseByUser(int id)
        {
            using var context = new Context();
            var values = context.CourseRegisters.Where(y => y.AddUserID == id).Include(x => x.Course).ToList();
            return values;
        }

        public List<CourseRegister> CourseRegisterListWithCoursesAndUsers()
        {
            using var context = new Context();
            var values = context.CourseRegisters.Include(x => x.Course).Include(y => y.AddUser).ToList();
            return values;
        }

        
    }
}
