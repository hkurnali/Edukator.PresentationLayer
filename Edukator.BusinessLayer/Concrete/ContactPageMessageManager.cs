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
    public class ContactPageMessageManager : IContactPageMessageService
    {
        private readonly IContactPageMessageDal _contactPageMessageDal;

        public ContactPageMessageManager(IContactPageMessageDal contactPageMessageDal)
        {
            _contactPageMessageDal = contactPageMessageDal;
        }

        public void TDelete(ContactPageMessage t)
        {
           _contactPageMessageDal.Delete(t);
        }

        public ContactPageMessage TGetByID(int id)
        {
          return _contactPageMessageDal.GetByID(id);
        }

        public List<ContactPageMessage> TGetList()
        {
            return _contactPageMessageDal.GetList();
        }

        public void TInsert(ContactPageMessage t)
        {
           _contactPageMessageDal.Insert(t);
        }

        public void TUpdate(ContactPageMessage t)
        {
           _contactPageMessageDal.Update(t);
        }
    }
}
