using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace PetStore
{
    public partial class CommentDetailStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CommentDetailStaff()
        {
            InitializeComponent();
        }

        private void CommentDetailStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petStoreDataSet1.CommentDetail' table. You can move, or remove it, as needed.
            this.commentDetailTableAdapter1.Fill(this.petStoreDataSet1.CommentDetail);
            // TODO: This line of code loads data into the 'petStoreDataSet.CommentDetail' table. You can move, or remove it, as needed.
            this.commentDetailTableAdapter.Fill(this.petStoreDataSet.CommentDetail);

        }
    }
}