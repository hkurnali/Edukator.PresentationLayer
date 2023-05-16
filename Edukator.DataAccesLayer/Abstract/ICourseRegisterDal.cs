using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccesLayer.Abstract
{
    public interface ICourseRegisterDal:IGenericDal<CourseRegister>
    {
        List<CourseRegister> CourseRegisterListWithCoursesAndUsers();
      
    }
}
