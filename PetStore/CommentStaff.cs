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
    public partial class CommentStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CommentStaff()
        {
            InitializeComponent();
        }

        private void CommentStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petStoreDataSet.Comment' table. You can move, or remove it, as needed.
            this.commentTableAdapter.Fill(this.petStoreDataSet.Comment);
        }
    }
}