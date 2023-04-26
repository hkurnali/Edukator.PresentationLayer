﻿using Edukator.DataAccesLayer.Abstract;
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
    public class EfContactDal : GenericRepostory<Contact>, IContactDal
    {
       
    }
}
