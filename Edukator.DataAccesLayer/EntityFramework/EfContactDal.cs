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
       

        public List<Contact> GetLast4Message()
        {
            using var context = new Context();
            var values = context.Contacts.OrderByDescending(x => x.ContactID).Take(4).ToList();
            return values;
        }
    }
}
