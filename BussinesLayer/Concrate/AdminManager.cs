using DataAccessLayer.Concrate;
using EntityLaye.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrate
{
    public class AdminManager
    {

        Repository<Admin> repoadmin = new Repository<Admin>();
        public List<Admin> GetAll() // getall ı herhangi bir şarta bağlamamak için kullandık
        { // adminleri listelemek için repo. sıunıfından veri çekiyoruz
            return repoadmin.List();
        }

        public int AdminAddL(Admin p)
        { // yeni admin ekledi
            return repoadmin.Insert(p);

        }
        public int DeleteEkle(int p)
        {
            Admin ekleme = repoadmin.Find(x => x.AdminID == p); // şarta bağlı benzersiz id 
            return repoadmin.Delete(ekleme);
        }

    }
}
