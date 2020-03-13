﻿using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class CommentModel
    {
        ArrayList cmtList;
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
        /// <param name="cmt_id"></param>
        public void RestoreComment(String cmt_id)
        {
            using (var db = new PetStoreEntities())
            {
                var Petfood = db.Comments.Find(cmt_id);
                Petfood.cmt_status = "Active";
                db.SaveChanges();
            }
        }

        public ArrayList LoadTableData()
        {
            cmtList = new ArrayList();
            using (var db = new PetStoreEntities())
            {
                var selectStr = (from cmt in db.Comments
                              join u in db.Users on cmt.u_id equals u.u_id
                              join p in db.Pets on cmt.p_id equals p.p_id
                              select new
                              {
                                  cmt.cmt_id,
                                  cmt.cmt_content,
                                  cmt.cmt_published,
                                  cmt.cmt_status,
                                  p.p_name,
                                  u.u_name
                              }).OrderBy(x=>x.cmt_published);

                foreach (var data in selectStr)
                {
                    cmtList.Add(new Object.Comment(data.cmt_id, data.cmt_content, data.cmt_published.ToString(), data.p_name, data.u_name, data.cmt_status));
                }
            }
            return cmtList;
        }
    }
}
