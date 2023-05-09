using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccesLayer.Concrete
{
    public class Context:IdentityDbContext< AddUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-H080ONB\\SQLEXPRESS01;initial catalog=DbEdukator;integrated security=true;");
        }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactInfo> CategoryInfos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<MailSubscribe> MailSubscribes { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
       public DbSet<Feature> Features { get; set; }

        public DbSet<About> Abouts { get; set; }
    }

   
}