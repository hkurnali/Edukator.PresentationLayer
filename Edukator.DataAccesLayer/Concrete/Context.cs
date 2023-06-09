﻿using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
        public DbSet<Footer> Footers { get; set; }
        public DbSet<AboutPageEntrance> AboutPageEntrances { get; set; }
        public DbSet<AboutPageCourse> AboutPageCourses { get; set; }
        public DbSet<AboutPageTeam> AboutPageTeams { get; set; }
        public DbSet<AboutPageValue> AboutPageValues { get; set;}
        public DbSet<ContactPageMessage> ContactPageMessages { get; set; }
        public DbSet<CourseRegister> CourseRegisters { get; set; }
    }

   
}