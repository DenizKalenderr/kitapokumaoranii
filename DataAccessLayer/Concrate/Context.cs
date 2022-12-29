using EntityLaye.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{ //verileri entitty den çektik
   public  class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Ekle> Users { get; set; }
    }
}
