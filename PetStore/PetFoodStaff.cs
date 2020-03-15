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
using PetStore.Model;

namespace PetStore
{
    public partial class PetFoodStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PetFoodStaff()
        {
            InitializeComponent();
        }

        private void PetFoodStaff_Load(object sender, EventArgs e)
        {
            PetFoodModel pfm = new PetFoodModel();
            bindingSourceFood.DataSource = pfm.GetAllPetFoodToArrayList();
            gcFood.DataSource = bindingSourceFood;
        }

        private void btnRefreshFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            PetFoodStaff_Load(sender, e);
        }
    }
}