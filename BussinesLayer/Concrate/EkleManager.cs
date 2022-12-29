using DataAccessLayer.Concrate;
using EntityLaye.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrate
{
    public class EkleManager
    {
        Repository<Ekle> repoekle = new Repository<Ekle>();
        public List<Ekle> GetAll()
        {
            return repoekle.List(); // bütün şehirleri getiriyor
        }
        public List<Ekle> EkleByID(int id)
        {
            return repoekle.List().Where(x => x.SehirID == id).ToList();

        }
        public int EkleAddL(Ekle p)
        {
            return repoekle.Insert(p);
        }
        public int DeleteEkle(int p)
        {
            Ekle ekleme = repoekle.Find(x => x.SehirID == p);
            return repoekle.Delete(ekleme);
        }

    }
}
