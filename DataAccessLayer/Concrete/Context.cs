using EntityLayer.Concrete;//diger class tan 
using System;
using System.Collections.Generic;
using System.Data.Entity;//dbcontext sınıfının kütüphanesi.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext//dbcontext sınıfını miras aldık.
    {
        public DbSet<About> Abouts { get; set; }//about classını kullanmak icin kütüphanesini ekledik ampülden.about:sınıfın ismi,abouts:sqldeki tablonun ismi
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
