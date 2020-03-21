using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class PetMedicineModel
    {
        public PetMedicineModel()
        {

        }
        public void RestorePetMedicine(String pm_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetMedicine = db.PetMedicines.Find(pm_id);
                PetMedicine.pm_status = "Active";
                db.SaveChanges();
            }
        }
      
        public void DeletePetMedicine(String pm_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PetMedicine = db.PetMedicines.Find(pm_id);
                PetMedicine.pm_status = "Inactive";
                db.SaveChanges();
            }
        }
      
        public String getLastID()
        {
            String lastID = "";
            using (var db = new PetStoreEntities())
            {
                var select = from s in db.PetMedicines orderby s.pm_id descending select s;
                var selectOne = select.Take(1);
                foreach (var data in selectOne)
                {
                    lastID = data.pm_id.ToString();
                }
            }
            if (lastID == "")
            {
                return "PMD0000";
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
                return "PMD000" + id;
            }
            else if (id >= 10 && id < 100)
            {
                return "PMD00" + id;
            }
            else if (id >= 100 && id < 1000)
            {
                return "PMD0" + id;
            }
            else
            {
                return "PMD" + id;
            }
        }


    }
}

