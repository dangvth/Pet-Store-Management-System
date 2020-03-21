﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars;
using PetStore.Model;
using System.Windows.Forms;
using System.Drawing;

namespace PetStore.Views.PetMedicineCollectionView{

    public partial class PetMedicineCollectionView : XtraUserControl {
        
        private string pmId_selected = "";
        public PetMedicineCollectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
			mvvmContext.RegisterService(WindowedDocumentManagerService.Create(this));
            var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetMedicineCollectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            // We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(ptbPetMedicine, gControl => gControl.DataSource, x => x.Entities);
			// We want to show loading-indicator when data is loading asynchronously
            fluentAPI.SetBinding(gridView, gView => gView.LoadingPanelVisible, x => x.IsLoading);
						// We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(gridView, "RowClick").EventToCommand(
                    x => x.Edit(null),
					x => x.SelectedEntity,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(gridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as PetStore.PetMedicine,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
			//We want to show ribbon print preview when bbiPrintPreview clicked
			bbiPrintPreview.ItemClick += (s, e) => { ptbPetMedicine.ShowRibbonPrintPreview(); };
			//We want to show RECORDS count on BarStaticItem
			fluentAPI.SetBinding(bsiRecordsCount, item => item.Caption,	x => x.Entities.Count, 
					count => string.Format("RECORDS : {0}", count));
			//We want to show PopupMenu when row clicked by right button
			gridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    popupMenu.ShowPopup(ptbPetMedicine.PointToScreen(e.Location), s);
                }
            };
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pmId_selected != "")
            {
                PetMedicineModel pmm = new PetMedicineModel();
                pmm.DeletePetMedicine(pmId_selected);
                XtraMessageBox.Show("Delete successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to delete !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GetImage(String pm_id)
        {
            using (var db = new PetStoreEntities())
            {
                var PMDImage = db.PetMedicines.Find(pm_id);
                string imagelink = PMDImage.pm_image;
            }
        }
        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            PetMedicineModel pmm = new PetMedicineModel();
            

            int idx = gridView.FocusedRowHandle;
            pmId_selected = gridView.GetRowCellValue(idx, "pm_id").ToString();
           
            // ptbPetMedicines.Image = Image.FromFile(GetImage.);
        }
       
        private void bbiRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pmId_selected != "")
            {
                PetMedicineModel pmm = new PetMedicineModel();
                pmm.RestorePetMedicine(pmId_selected);
                XtraMessageBox.Show("Restore successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose a Accessories item to delete !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
