using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace PetStore.Model
{
    class PetAccessoriesModel
    {
        public PetAccessoriesModel()
        {

        }
        public void RestorePetAccessories(String pa_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetAccessories = db.PetAccessories.Find(pa_id);
                  PetAccessories.pa_status = "Active";
                db.SaveChanges();
            }
        }
        public void DeletePetAccessories(String pa_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetAccessories = db.PetAccessories.Find(pa_id);
                 PetAccessories.pa_status = "Inactive";  
                db.SaveChanges();
            }
        }
        public void DeleteAcc(String pa_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetAccessories = db.PetAccessories.Find(pa_id);
                
            }
        }
        public String getLastID()
        {
            String lastID = "";
            using (var db = new PetStoreEntities())
            {
                var select = from s in db.PetAccessories orderby s.pa_id descending select s;
                var selectOne = select.Take(1);
                foreach (var data in selectOne)
                {
                    lastID = data.pa_id.ToString();
                }
            }
            if (lastID == "")
            {
                return "PAS0000";
            }
            else
            {
                return lastID;
            }
        }

        public String getNextID()
        {
            String dID = "";
            dID = getLastID().Remove(0, 3);
            int id = Convert.ToInt32(dID) + 1;
            if (id < 10)
            {
                return "PAS000" + id;
            }
            else if (id >= 10 && id < 100)
            {
                return "PAS00" + id;
            }
            else if (id >= 100 && id < 1000)
            {
                return "PAS0" + id;
            }
            else
            {
                return "PAS" + id;
            }
        }

       
    }
}
