using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    class PetFoodModel
    {
        public PetFoodModel()
        {

        }

        public void DeletePetFood(String pf_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Petfood = db.PetFoods.Find(pf_id);
                Petfood.pf_status = "Inactive";
                db.SaveChanges();
            }
        }
        public String getLastID()
        {
            String lastID = "";
            using (var db = new PetStoreEntities())
            {
                var select = from s in db.PetFoods orderby s.pf_id descending select s;
                var selectOne = select.Take(1);
                foreach (var data in selectOne)
                {
                    lastID = data.pf_id.ToString();
                }
            }
            if (lastID == ""){return "PFD0000";}
            else { return lastID; }
        }

        public String getNextID()
        {
            String dID = "";
            dID = getLastID().Remove(0, 3);
            int id = Convert.ToInt32(dID) + 1;
            if (id < 10)
            {
                return "PFD000" + id;
            }
            else if (id >= 10 && id < 100)
            {
                return "PFD00" + id;
            }
            else if (id >= 100 && id < 1000)
            {
                return "PFD0" + id;
            } else
            {
                return "PFD" + id;
            }
        }
    }
}
