using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contrete
{
    public class ProjectDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-59IK1A6E\\SQLEXPRESS03;database=DbNewAgriculture;integrated security=true;trusted_connection=true;encrypt=false;");
        }
        // aşağıdaki işlemleri yapmak için referanslama işlemini yapacağız
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<Services> Serviceses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Attention> Attentions { get; set; }
        public DbSet<RecentProject> RecentProjects { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
