using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class AddUser:IdentityUser<int>

    {

        public string Name {  get; set; }
        public string SUrname { get; set; }
        public string Ctiy { get; set; }
        [StringLength(100)]
        public string ImageUrl { get; set; }
        public List<CourseRegister>  CourseRegisters{ get; set; }
    }
}
