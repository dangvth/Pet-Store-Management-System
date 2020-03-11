using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class CommentModel
    {
        public CommentModel()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmt_id"></param>
        public void DeleteComment(String cmt_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Petfood = db.Comments.Find(cmt_id);
                Petfood.cmt_status = "Inactive";
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
                var select = from s in db.Comments orderby s.cmt_id descending select s;
                var selectOne = select.Take(1);
                foreach (var data in selectOne)
                {
                    lastID = data.cmt_id.ToString();
                }
            }
            if (lastID == "") { return "CMT0000"; }
            else { return lastID; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String getNextID()
        {
            String ID = "";
            ID = getLastID().Remove(0, 3);
            int id = Convert.ToInt32(ID) + 1;
            if (id < 10)
            {
                return "CMT000" + id;
            }
            else if (id >= 10 && id < 100)
            {
                return "CMT00" + id;
            }
            else if (id >= 100 && id < 1000)
            {
                return "CMT0" + id;
            }
            else
            {
                return "CMT" + id;
            }
        }
    }
}
