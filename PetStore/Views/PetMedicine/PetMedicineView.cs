﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;
using PetStore.Model;
using System.Drawing;

namespace PetStore.Views.PetMedicineView{
    public partial class PetMedicineView : XtraUserControl {
        public PetMedicineView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<PetStore.ViewModels.PetMedicineViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                petMedicineViewBindingSource, x => x.Entity, x => x.Update());
						#region BillDetails Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BillDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.PetMedicineBillDetailsDetails.SelectedEntity,
                    args => args.Row as PetStore.BillDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						//We want to show PopupMenu when row clicked by right button
			BillDetailsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BillDetailsPopUpMenu.ShowPopup(BillDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the PetMedicineBillDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BillDetailsGridControl, g => g.DataSource, x => x.PetMedicineBillDetailsDetails.Entities);
				
														fluentAPI.BindCommand(bbiBillDetailsRefresh, x => x.PetMedicineBillDetailsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }

       

        private void pm_idTextEdit_Properties_Click(object sender, EventArgs e)
        {
            PetMedicineModel pmm = new PetMedicineModel();
            pm_idTextEdit.Text = pmm.getNextID();
        }

        private void pm_imageTextEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (openDialog.FileName != "" && (openDialog.FileName.EndsWith(".jpg") || openDialog.FileName.EndsWith(".png")))
            {
                PetMedicineModel pmm = new PetMedicineModel();
                if (openDialog.FileName.EndsWith(".jpg"))
                {
                    pm_imageTextEdit.Text = pmm.getNextID() + ".jpg";
                }
                else
                {
                    pm_imageTextEdit.Text = pmm.getNextID() + ".png";
                }
            }
            else
            {
                XtraMessageBox.Show("Please choose a image with (*.jpg)/(*.png) file !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            String fileName = openDialog.FileName;
            pm_imageTextEdit.Text = fileName;
            PictureBox ptbPetMedi = new PictureBox();//tạo 1 cái picturebox mới
             string filepath = fileName;

            ptbPetMedi.Image = Image.FromFile(filepath.ToString());//gán cái hình ảnh cho cái picturebox mới đó
           // objpt.SizeMode = PictureBoxSizeMode.AutoSize; 
        }
    }
}
