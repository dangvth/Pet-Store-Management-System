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

namespace PetStore
{
    public partial class Staff : DevExpress.XtraEditors.XtraForm
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnCmtList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CommentStaff cmtStaff = new CommentStaff();
            cmtStaff.ShowDialog();
        }
    }
}