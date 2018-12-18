using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
   public class ModelDal
    {
       public List<Model> GetAll()
        {
            using (Entities db = new Entities())
            {
                return db.Models.ToList();
            }
        }

        public void Add(Model model)
        {
            using(Entities db=new Entities())
            {
                var entity = db.Entry(model);
                entity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(Model model)
        {
            using(Entities db=new Entities())
            {
                var entitystate = db.Entry(model);

                entitystate.State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public void Delete(Model model)
        {
            DeletedProcess(model);
        }

        public static void DeletedProcess(Model model)
        {
            using(Entities db=new Entities())
            {
                var entity = db.Entry(model);
                entity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<Model> GetName(string key)
        {
            using (Entities db = new Entities())
            {
                return db.Models.Where(r => r.ModelName.Contains(key)).ToList();
            }
        }
    }
}
