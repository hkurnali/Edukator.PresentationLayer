using Edukator.DataAccesLayer.Abstract;
using Edukator.DataAccesLayer.Concrete;
using Edukator.DataAccesLayer.Repostories;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccesLayer.EntityFramework
{
    public class EfCourseDal : GenericRepostory<Course>, ICourseDal
    {
        

        public List<Course> GetCoursesWithCategory()
            {
                Context context = new Context();
                return context.Courses.Include(x => x.Category).ToList();
            }

        public List<Course> GetCoursesWithCategories()
        {
            Context context = new Context();
            return context.Courses.Include(x => x.Category).ToList();
        }


    }
}
