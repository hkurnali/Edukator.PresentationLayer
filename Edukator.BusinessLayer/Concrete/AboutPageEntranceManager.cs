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
    public class AboutPageEntranceManager : IAboutPageEntranceService
    {
        private readonly IAboutPageEntranceDal _aboutPageEntranceDal;

        public AboutPageEntranceManager(IAboutPageEntranceDal aboutPageEntranceDal)
        {
            _aboutPageEntranceDal = aboutPageEntranceDal;
        }

        public void TDelete(AboutPageEntrance t)
        {
           _aboutPageEntranceDal.Delete(t);
        }

        public AboutPageEntrance TGetByID(int id)
        {
            return _aboutPageEntranceDal.GetByID(id);
        }

        public List<AboutPageEntrance> TGetList()
        {
         return   _aboutPageEntranceDal.GetList();
        }

        public void TInsert(AboutPageEntrance t)
        {
            _aboutPageEntranceDal.Insert(t);
        }

        public void TUpdate(AboutPageEntrance t)
        {
           _aboutPageEntranceDal.Update(t);
        }
    }
}
