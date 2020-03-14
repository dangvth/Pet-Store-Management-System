using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class PetFoodModel
    {
        ArrayList pfList;
        public PetFoodModel()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pf_id"></param>
        public void DeletePetFood(String pf_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Petfood = db.PetFoods.Find(pf_id);
                Petfood.pf_status = "Inactive";
                db.SaveChanges();
            }
        }

        public void RestorePetFood(String pf_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Petfood = db.PetFoods.Find(pf_id);
                Petfood.pf_status = "Active";
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
            if (lastID == "") { return "PFD0000"; }
            else { return lastID; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
            }
            else
            {
                return "PFD" + id;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ArrayList GetAllPetFoodToArrayList()
        {
            pfList = new ArrayList();
            using (var db = new PetStoreEntities())
            {
                var selectStr = (from f in db.PetFoods
                                 join t in db.Types on f.t_id equals t.t_id
                                 select new
                                 {
                                     f.pf_id,
                                     f.pf_name,
                                     f.pf_salePrice,
                                     f.pf_amount,
                                     t.t_name,
                                     f.pf_status
                                 });

                foreach (var data in selectStr)
                {
                    if (data.pf_amount > 0)
                    {
                        pfList.Add(new Object.Food(data.pf_id, data.pf_name, Convert.ToInt32(data.pf_salePrice), Convert.ToInt32(data.pf_amount), data.t_name, "Active"));
                    }
                    else
                    {
                        pfList.Add(new Object.Food(data.pf_id, data.pf_name, Convert.ToInt32(data.pf_salePrice), Convert.ToInt32(data.pf_amount), data.t_name, "Inactive"));
                    }
                    
                }
            }
            return pfList;
        }
    }
}
