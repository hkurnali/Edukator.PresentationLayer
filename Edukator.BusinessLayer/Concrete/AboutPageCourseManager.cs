using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccesLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class AboutPageCourseManager : IAboutPageCourseService
    {
        private readonly IAboutPageCourseDal _aboutPageCourseDal;

        public AboutPageCourseManager(IAboutPageCourseDal aboutPageCourseDal)
        {
            _aboutPageCourseDal = aboutPageCourseDal;
        }

        public void TDelete(AboutPageCourse t)
        {
            _aboutPageCourseDal.Delete(t);
        }

        public AboutPageCourse TGetByID(int id)
        {
           return _aboutPageCourseDal.GetByID(id);
        }

        public List<AboutPageCourse> TGetList()
        {
           return _aboutPageCourseDal.GetList();
        }

        public void TInsert(AboutPageCourse t)
        {
            _aboutPageCourseDal.Insert(t);
        }

        public void TUpdate(AboutPageCourse t)
        {
            _aboutPageCourseDal.Update(t);
        }
    }
}
