using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Footer
    {
        public int FooterID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
