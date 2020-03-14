using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PetStore.Model;

namespace PetStore
{
    public partial class Staff : DevExpress.XtraEditors.XtraForm
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnPFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PetFoodStaff pfs = new PetFoodStaff();
            pfs.MdiParent = this;
            pfs.Show();
        }

        private void btnCmtList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CommentStaff cs = new CommentStaff();
            cs.MdiParent = this;
            cs.Show();
        }
    }
}