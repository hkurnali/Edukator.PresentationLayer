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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialdal;

        public TestimonialManager(ITestimonialDal testimonialdal)
        {
            _testimonialdal = testimonialdal;
        }

        public void TDelete(Testimonial t)
        {
            _testimonialdal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
           return _testimonialdal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialdal.GetList();
        }

        public void TInsert(Testimonial t)
        {
           _testimonialdal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
           _testimonialdal.Update(t);
        }
    }
}
