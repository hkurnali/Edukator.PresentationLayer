using Edukator.DataAccesLayer.Abstract;
using Edukator.DataAccesLayer.Concrete;
using Edukator.DataAccesLayer.Repostories;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccesLayer.EntityFramework
{
    public class EfCourseRegisterDal : GenericRepostory<CourseRegister>, ICourseRegisterDal

    {
        public List<CourseRegister> CourseRegisterListWithCoursesAndUsers()
        {
            using var context = new Context();
            var values = context.CourseRegisters.Include(x => x.Course).Include(y => y.AddUser).ToList();
            return values;
        }

        
    }
}
