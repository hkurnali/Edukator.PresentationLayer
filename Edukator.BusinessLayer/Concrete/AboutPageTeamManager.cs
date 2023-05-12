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
    public class AboutPageTeamManager : IAboutPageTeamService
    {
        private readonly IAboutPageTeamDal _aboutPageTeamDal;

        public AboutPageTeamManager(IAboutPageTeamDal aboutPageTeamDal)
        {
            _aboutPageTeamDal = aboutPageTeamDal;
        }

        public void TDelete(AboutPageTeam t)
        {
           _aboutPageTeamDal.Delete(t);
        }

        public AboutPageTeam TGetByID(int id)
        {
           return _aboutPageTeamDal.GetByID(id);
        }

        public List<AboutPageTeam> TGetList()
        {
            return _aboutPageTeamDal.GetList();
        }

        public void TInsert(AboutPageTeam t)
        {
           _aboutPageTeamDal.Insert(t);
        }

        public void TUpdate(AboutPageTeam t)
        {
            _aboutPageTeamDal.Update(t);
        }
    }
}
