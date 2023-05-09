using Edukator.DataAccesLayer.Abstract;
using Edukator.DataAccesLayer.Repostories;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccesLayer.EntityFramework
{
    public class EfServiceDal : GenericRepostory<Service>, IServiceDal
    {
    }
}
