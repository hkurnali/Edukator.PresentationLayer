using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccesLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-H080ONB\\SQLEXPRESS01;initial catalog=DbEdukator;integrated security=true;");
        }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactInfo> CategoryInfos { get; set; }
    }
}
