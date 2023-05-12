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
    public class AboutPageValueManager : IAboutPageValueService
    {
        private readonly IAboutPageValueDal _aboutPageValueDal;

        public AboutPageValueManager(IAboutPageValueDal aboutPageValueDal)
        {
            _aboutPageValueDal = aboutPageValueDal;
        }

        public void TDelete(AboutPageValue t)
        {
            _aboutPageValueDal.Delete(t);
        }

        public AboutPageValue TGetByID(int id)
        {
         return   _aboutPageValueDal.GetByID(id);
        }

        public List<AboutPageValue> TGetList()
        {
            return _aboutPageValueDal.GetList();    
        }

        public void TInsert(AboutPageValue t)
        {
           _aboutPageValueDal.Insert(t);
        }

        public void TUpdate(AboutPageValue t)
        {
            _aboutPageValueDal.Update(t);
        }
    }
}
