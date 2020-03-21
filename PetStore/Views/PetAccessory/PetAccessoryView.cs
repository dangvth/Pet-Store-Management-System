using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using PetStore.Model;
using System;
using System.Linq;

namespace PetStore.Views.PetAccessoryView
{
    public partial class PetAccessoryView : XtraUserControl
    {
        public PetAccessoryView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
            pa_times.Start();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetAccessoryViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                petAccessoryViewBindingSource, x => x.Entity, x => x.Update());
            #region BillDetails Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BillDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PetAccessoryBillDetailsDetails.SelectedEntity,
                    args => args.Row as PetStore.BillDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            //We want to show PopupMenu when row clicked by right button
            BillDetailsGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    BillDetailsPopUpMenu.ShowPopup(BillDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the PetAccessoryBillDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(BillDetailsGridControl, g => g.DataSource, x => x.PetAccessoryBillDetailsDetails.Entities);

            fluentAPI.BindCommand(bbiBillDetailsRefresh, x => x.PetAccessoryBillDetailsDetails.Refresh());
            #endregion

            bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
        }

        private void pa_idTextEdit_Click(object sender, EventArgs e)
        {
            PetAccessoriesModel pam = new PetAccessoriesModel();
            pa_idTextEdit.Text = pam.getNextID();
        }

        private void buttonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        /*private void pa_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                PetAccessoriesModel pam = new PetAccessoriesModel();
                if (openDialog.FileName.EndsWith(".jpg"))
                    {
                        pa_image.Text = pam.getNextID() + ".jpg";
                    }
                else
                    {
                        pa_image.Text = pam.getNextID() + ".png";
                    }
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            String fileName = openDialog.FileName;
            pa_image.Text = fileName;
        }*/

        private void pa_idTextEdit_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void pa_idTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void pa_nameTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }


        private void pa_times_Tick(object sender, EventArgs e)
        {
            pa_publishedDateEdit.Text = System.DateTime.Now.ToString();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
