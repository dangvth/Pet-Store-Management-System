using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Object
{
    class CommentDetail
    {
        private int cmtd_id;
        private int cmt_id;
        private String cmtd_content;
        private String cmtd_published;
        private String cmtd_status;
        private int cmtd_uID;

        public int Cmtd_id
        {
            get
            {
                return cmtd_id;
            }

            set
            {
                cmtd_id = value;
            }
        }

        public int Cmt_id
        {
            get
            {
                return cmt_id;
            }

            set
            {
                cmt_id = value;
            }
        }

        public string Cmtd_content
        {
            get
            {
                return cmtd_content;
            }

            set
            {
                cmtd_content = value;
            }
        }

        public string Cmtd_published
        {
            get
            {
                return cmtd_published;
            }

            set
            {
                cmtd_published = value;
            }
        }

        public String Cmtd_status
        {
            get
            {
                return cmtd_status;
            }

            set
            {
                cmtd_status = value;
            }
        }

        public int Cmtd_uID
        {
            get
            {
                return cmtd_uID;
            }

            set
            {
                cmtd_uID = value;
            }
        }

        public CommentDetail(int cmtdID, int cmtID, String cmtdContent,
                                  String cmtdPublished, String cmtdStatus, int cmtdUID)
        {
            this.Cmtd_id = cmtdID;
            this.Cmt_id = cmtID;
            this.Cmtd_content = cmtdContent;
            this.Cmtd_published = cmtdPublished;
            this.Cmtd_status = cmtdStatus;
            this.Cmtd_uID = cmtdUID;
        }

    }
}
